﻿// <auto-generated />
using LocalBusinessLookup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusinessLookup.Migrations
{
    [DbContext(typeof(LocalBusinessLookupContext))]
    partial class LocalBusinessLookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusinessLookup.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<string>("WebSite");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 10,
                            Description = "A bold, bland take on the popular California burrito",
                            Name = "Jeff's Burritos",
                            PhoneNumber = "4355552221",
                            Type = "restaurant",
                            UserId = 1,
                            WebSite = "https://www.google.com/"
                        },
                        new
                        {
                            BusinessId = 11,
                            Description = "Pizza with an inexplicably spicy twist.",
                            Name = "Juan's Pizza Palace",
                            PhoneNumber = "8468618684",
                            Type = "restaurant",
                            UserId = 2,
                            WebSite = "castor oil"
                        },
                        new
                        {
                            BusinessId = 2,
                            Description = "Holiday specialities from your favorite Latinx nuns!",
                            Name = "Joly Jands Joliday Joopla",
                            PhoneNumber = "7878799456",
                            Type = "restaurant",
                            UserId = 2,
                            WebSite = "https://www.google.com/"
                        },
                        new
                        {
                            BusinessId = 3,
                            Description = "The only place you're allowed to eat... Ever...",
                            Name = "Don't Eat Anywhere Else",
                            PhoneNumber = "3743453457",
                            Type = "restaurant",
                            UserId = 1,
                            WebSite = "https://www.google.com/"
                        },
                        new
                        {
                            BusinessId = 4,
                            Description = "Your local purveyor of creeping slimes and fuzzy foilage.",
                            Name = "Mycelium and Moss",
                            PhoneNumber = "9757567677",
                            Type = "shop",
                            UserId = 2,
                            WebSite = "https://www.google.com/"
                        },
                        new
                        {
                            BusinessId = 5,
                            Description = "Get clean and smell great.",
                            Name = "The Soap Shop",
                            PhoneNumber = "3684568654",
                            Type = "shop",
                            UserId = 1,
                            WebSite = "https://www.google.com/"
                        },
                        new
                        {
                            BusinessId = 6,
                            Description = "We got all the healthy stuff here",
                            Name = "Get Wellness!",
                            PhoneNumber = "8141465465",
                            Type = "shop",
                            UserId = 2,
                            WebSite = "https://www.google.com/"
                        },
                        new
                        {
                            BusinessId = 7,
                            Description = "For whatever you need.",
                            Name = "I Need",
                            PhoneNumber = "6565656565",
                            Type = "shop",
                            UserId = 1,
                            WebSite = "lemon"
                        },
                        new
                        {
                            BusinessId = 8,
                            Description = "We have clocks in all the timezones.",
                            Name = "Good Times Clock Shop",
                            PhoneNumber = "9876543212",
                            Type = "shop",
                            UserId = 2,
                            WebSite = "https://www.google.com/"
                        },
                        new
                        {
                            BusinessId = 9,
                            Description = "We make bread that's partially toasted",
                            Name = "Zebra Print Bread",
                            PhoneNumber = "0212121212",
                            Type = "restaurant",
                            UserId = 1,
                            WebSite = "https://www.google.com/"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
