﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SharpCounter.Dapper;
using SharpCounter.Data;
using SharpCounter.Enities;

namespace SharpCounter.Controllers
{
    [Authorize]
    public class WebSitesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly WebSiteRepo _websiteRepo;
        private readonly UserManager<ApplicationUser> _userManager;

        public WebSitesController(UserManager<ApplicationUser> UserManage, WebSiteRepo WebsiteRepo, ApplicationDbContext context)
        {
            _context = context;
            _websiteRepo = WebsiteRepo;
            _userManager = UserManage;
        }

        // GET: WebSites
        public async Task<IActionResult> Index()
        {
            return View(await _websiteRepo.FindAll());
        }

        // GET: WebSites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webSites = await _context.WebSites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webSites == null)
            {
                return NotFound();
            }

            return View(webSites);
        }

        // GET: WebSites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebSites/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HomePageLink,Name")] WebSites webSites)
        {
            if (ModelState.IsValid)
            {
                webSites.APIKey = Guid.NewGuid().ToString();
                webSites.HomePageLink = webSites.HomePageLink;
                webSites.Name = webSites.Name;
                webSites.UpdatedAt = DateTime.UtcNow;
                webSites.CreatedAt = DateTime.UtcNow;
                var curUser = await _userManager.GetUserAsync(HttpContext.User);
                webSites.OwnerId = curUser.Id;
                _context.Add(webSites);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(webSites);
        }

        // GET: WebSites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webSites = await _context.WebSites.FindAsync(id);
            if (webSites == null)
            {
                return NotFound();
            }
            return View(webSites);
        }

        // POST: WebSites/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HomePageLink,Name")] WebSites webSites)
        {
            var modWebsite = await _context.WebSites.FirstOrDefaultAsync(x => x.Id == id);
            if (modWebsite == null)
            {
                return RedirectToAction(nameof(Index));
            }
            modWebsite.HomePageLink = webSites.HomePageLink;
            modWebsite.Name = webSites.Name;
            await _context.SaveChangesAsync();
            return View(webSites);
        }

        // GET: WebSites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webSites = await _context.WebSites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webSites == null)
            {
                return NotFound();
            }

            return View(webSites);
        }

        // POST: WebSites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var webSites = await _context.WebSites.FindAsync(id);
            _context.WebSites.Remove(webSites);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebSitesExists(int id)
        {
            return _context.WebSites.Any(e => e.Id == id);
        }
    }
}
