﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharpCounter.Enities;

namespace SharpCounter.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BrowserStats> BrowserStats { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<InteractionCounts> InteractionCounts { get; set; }
        public DbSet<InteractionStats> InteractionStats { get; set; }
        public DbSet<LocationStats> LocationStats { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<WebSites> WebSites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<WebSites>()
                .HasIndex(b => b.APIKey)
                .IsUnique();


            modelBuilder.Entity<ApplicationUser>()
                .HasMany(c => c.Websites)
                .WithOne(e => e.Owner);

            modelBuilder.Entity<BrowserStats>()
                .HasOne(w => w.WebSite)
                .WithMany(w => w.BrowserStats)
                .HasForeignKey(w => w.WebSiteId)
                .IsRequired();

            modelBuilder.Entity<BrowserStats>()
                .HasIndex(x => x.Browser);

            modelBuilder.Entity<BrowserStats>()
                .HasIndex(x => x.Date);

            modelBuilder.Entity<Interaction>()
                .HasOne(w => w.WebSite)
                .WithMany(w => w.Interactions)
                .HasForeignKey(w => w.WebSiteId)
                .IsRequired();

            modelBuilder.Entity<Interaction>()
                .HasIndex(b => b.CreatedAt);

            modelBuilder.Entity<Interaction>()
                .HasIndex(b => b.FirstVisit);

            modelBuilder.Entity<Interaction>()
                .HasIndex(b => b.Browser);

            modelBuilder.Entity<Interaction>()
                .HasIndex(b => b.Path);

            modelBuilder.Entity<InteractionCounts>()
                .HasOne(w => w.WebSite)
                .WithMany(w => w.InteractionCounts)
                .HasForeignKey(w => w.WebSiteId)
                .IsRequired();

            modelBuilder.Entity<InteractionCounts>()
                .HasIndex(x => x.Path);

            modelBuilder.Entity<InteractionCounts>()
                .HasIndex(x => x.Hour);


            modelBuilder.Entity<InteractionStats>()
                .HasOne(w => w.WebSite)
                .WithMany(w => w.InteractionStats)
                .HasForeignKey(w => w.WebSiteId)
                .IsRequired();

            modelBuilder.Entity<LocationStats>()
                .HasOne(w => w.WebSite)
                .WithMany(w => w.LocationStats)
                .HasForeignKey(w => w.WebSiteId)
                .IsRequired();

            modelBuilder.Entity<Session>()
                .HasOne(w => w.WebSite)
                .WithMany(w => w.Sessions)
                .HasForeignKey(w => w.WebSiteId)
                .IsRequired();

            modelBuilder.Entity<Session>()
                .HasIndex(x => x.CreatedAt);

            modelBuilder.Entity<Session>()
                .HasIndex(x => x.LastSeen);

            modelBuilder.Entity<Session>()
                .HasIndex(x => x.SessionUId);

            modelBuilder.Entity<SystemStats>()
                .HasOne(w => w.WebSite)
                .WithMany(w => w.SystemStats)
                .HasForeignKey(w => w.WebSiteId)
                .IsRequired();

            modelBuilder.Entity<SystemStats>()
                .HasIndex(x => x.Platform);

            modelBuilder.Entity<SystemStats>()
                .HasIndex(x => x.Day);

        }

    }
}
