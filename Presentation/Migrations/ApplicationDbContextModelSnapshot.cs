﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Presentation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.BrowserStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Browser")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CountUnique")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Version")
                        .HasColumnType("longtext");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Browser");

                    b.HasIndex("Date");

                    b.HasIndex("WebSiteId");

                    b.ToTable("BrowserStats");
                });

            modelBuilder.Entity("Domain.Interaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Browser")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("DevicePixelRatio")
                        .HasColumnType("double");

                    b.Property<bool>("FirstVisit")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Language")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Path")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Referrer")
                        .HasColumnType("longtext");

                    b.Property<double>("ScreenHeight")
                        .HasColumnType("double");

                    b.Property<double>("ScreenWidth")
                        .HasColumnType("double");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Browser");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("DevicePixelRatio");

                    b.HasIndex("FirstVisit");

                    b.HasIndex("Path");

                    b.HasIndex("ScreenHeight");

                    b.HasIndex("ScreenWidth");

                    b.HasIndex("SessionId");

                    b.HasIndex("WebSiteId");

                    b.ToTable("Interactions");
                });

            modelBuilder.Entity("Domain.InteractionByPathCounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("InteractionPathGroupStatsId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.HasIndex("InteractionPathGroupStatsId");

                    b.HasIndex("Path");

                    b.HasIndex("WebSiteId");

                    b.ToTable("InteractionByPathCounts");
                });

            modelBuilder.Entity("Domain.InteractionPathGroupStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TotalRoutes")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.HasIndex("WebSiteId");

                    b.ToTable("InteractionPathGroupStats");
                });

            modelBuilder.Entity("Domain.LocationStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CountUnique")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WebSiteId");

                    b.ToTable("LocationStats");
                });

            modelBuilder.Entity("Domain.PageViewStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Count")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("WebSiteId");

                    b.ToTable("PageViewStats");
                });

            modelBuilder.Entity("Domain.ScreenSizeStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ComputerMonitors")
                        .HasColumnType("int");

                    b.Property<int>("ComputerMonitors4K")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LargePhonesSmallTablets")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPhones")
                        .HasColumnType("int");

                    b.Property<int>("TabletsSmallLaptops")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.HasIndex("WebSiteId");

                    b.ToTable("ScreenSizeStats");
                });

            modelBuilder.Entity("Domain.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastSeen")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SessionUId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("LastSeen");

                    b.HasIndex("SessionUId");

                    b.HasIndex("WebSiteId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Domain.SiteContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BlurgUnderLargerHeader")
                        .HasColumnType("longtext");

                    b.Property<string>("Documentation")
                        .HasColumnType("longtext");

                    b.Property<string>("FinalHeader")
                        .HasColumnType("longtext");

                    b.Property<string>("FinalHeaderContent")
                        .HasColumnType("longtext");

                    b.Property<string>("Header1")
                        .HasColumnType("longtext");

                    b.Property<string>("Header1CodeSnip")
                        .HasColumnType("longtext");

                    b.Property<string>("Header1Content")
                        .HasColumnType("longtext");

                    b.Property<string>("Header2")
                        .HasColumnType("longtext");

                    b.Property<string>("Header2Content")
                        .HasColumnType("longtext");

                    b.Property<string>("Header3")
                        .HasColumnType("longtext");

                    b.Property<string>("Header3Content")
                        .HasColumnType("longtext");

                    b.Property<string>("LargeHeader")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivacyPolicy")
                        .HasColumnType("longtext");

                    b.Property<string>("WhatWeCollect")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SiteContents");
                });

            modelBuilder.Entity("Domain.SystemStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CountUnique")
                        .HasColumnType("int");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Platform")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Version")
                        .HasColumnType("longtext");

                    b.Property<int>("WebSiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Day");

                    b.HasIndex("Platform");

                    b.HasIndex("WebSiteId");

                    b.ToTable("SystemStats");
                });

            modelBuilder.Entity("Domain.WebSites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HomePageLink")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("APIKey")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("WebSites");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Presentation.Cache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("Caches");
                });

            modelBuilder.Entity("Presentation.Models.UserSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CurrentTimeZone")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("Domain.BrowserStats", b =>
                {
                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("BrowserStats")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.Interaction", b =>
                {
                    b.HasOne("Domain.Session", "Session")
                        .WithMany("Interactions")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("Interactions")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.InteractionByPathCounts", b =>
                {
                    b.HasOne("Domain.InteractionPathGroupStats", "InteractionPathGroupStats")
                        .WithMany("InteractionByPathCounts")
                        .HasForeignKey("InteractionPathGroupStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("InteractionByPathCounts")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InteractionPathGroupStats");

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.InteractionPathGroupStats", b =>
                {
                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("InteractionPathGroupStats")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.LocationStats", b =>
                {
                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("LocationStats")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.PageViewStats", b =>
                {
                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("PageViewStats")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.ScreenSizeStats", b =>
                {
                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("ScreenSizeStats")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.Session", b =>
                {
                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("Sessions")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.SystemStats", b =>
                {
                    b.HasOne("Domain.WebSites", "WebSite")
                        .WithMany("SystemStats")
                        .HasForeignKey("WebSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WebSite");
                });

            modelBuilder.Entity("Domain.WebSites", b =>
                {
                    b.HasOne("Domain.ApplicationUser", "Owner")
                        .WithMany("Websites")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Presentation.Models.UserSetting", b =>
                {
                    b.HasOne("Domain.ApplicationUser", "ApplicationUser")
                        .WithOne("UserSettings")
                        .HasForeignKey("Presentation.Models.UserSetting", "ApplicationUserId");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Domain.ApplicationUser", b =>
                {
                    b.Navigation("UserSettings");

                    b.Navigation("Websites");
                });

            modelBuilder.Entity("Domain.InteractionPathGroupStats", b =>
                {
                    b.Navigation("InteractionByPathCounts");
                });

            modelBuilder.Entity("Domain.Session", b =>
                {
                    b.Navigation("Interactions");
                });

            modelBuilder.Entity("Domain.WebSites", b =>
                {
                    b.Navigation("BrowserStats");

                    b.Navigation("InteractionByPathCounts");

                    b.Navigation("InteractionPathGroupStats");

                    b.Navigation("Interactions");

                    b.Navigation("LocationStats");

                    b.Navigation("PageViewStats");

                    b.Navigation("ScreenSizeStats");

                    b.Navigation("Sessions");

                    b.Navigation("SystemStats");
                });
#pragma warning restore 612, 618
        }
    }
}
