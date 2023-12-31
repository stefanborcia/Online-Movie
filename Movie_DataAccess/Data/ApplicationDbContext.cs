﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movie_Models;

namespace Movie_DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "History", DisplayOrder = 3 },
                new Category { CategoryId = 4, Name = "Comedy", DisplayOrder = 4 },
                new Category { CategoryId = 5, Name = "Drama", DisplayOrder = 5 }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyId = 1, Name = "Universal Pictures", StreetAddress = "", City = "Universal City", PostalCode = "127458", State = "California", PhoneNumber = "+41 8579 2548"},
                new Company { CompanyId = 2, Name = "Warner Bros", StreetAddress = "", City = "Burbank", PostalCode = "145976", State = "California", PhoneNumber = "+42 8557 6628 "},
                new Company { CompanyId = 3, Name = "Lionsgate", StreetAddress = "", City = "Santa Monica", PostalCode = "157498", State = "California", PhoneNumber = "+41 2548 3657"}
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Title = "Gridlocked",
                    Actors = "Brody Walker",
                    Description = "Former SWAT leader David Hendrix and hard-partying movie star Brody Walker must cut their ride-along short when a police training facility is attacked by a team of mercenaries.",
                    ListPrice = 5,
                    Price = 8,
                    Price3 = 10,
                    Price5 = 15,
                    CatId = 4,
                    ImageUrl = ""
                },
            new Product
            {
                ProductId = 2,
                Title = "Security",
                Actors = "Antonio Banderas",
                Description = "A security guard protects an eleven year-old girl who is being targeted by a gang for participating as a trial witness.",
                ListPrice = 5,
                Price = 8,
                Price3 = 10,
                Price5 = 15,
                CatId = 4,
                ImageUrl = ""
            },
                new Product
                {
                    ProductId = 3,
                    Title = "Blacklight",
                    Actors = "Liam Neeson",
                    Description = "Travis Block is a government operative coming to terms with his shadowy past. When he discovers a plot targeting U.S. citizens, Block finds himself in the crosshairs of the FBI director he once helped protect.",
                    ListPrice = 5,
                    Price = 8,
                    Price3 = 10,
                    Price5 = 15,
                    CatId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    ProductId = 4,
                    Title = "John Wick 4",
                    Actors = "john wick",
                    Description = "With the price on his head ever increasing, legendary hit man John Wick takes his fight against the High Table global as he seeks out the most powerful players in the underworld, from New York to Paris to Japan to Berlin.",
                    ListPrice = 5,
                    Price = 8,
                    Price3 = 10,
                    Price5 = 15,
                    CatId = 4,
                    ImageUrl = ""
                }
            );
        }
    }
}
