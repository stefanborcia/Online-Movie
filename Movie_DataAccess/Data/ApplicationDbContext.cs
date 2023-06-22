using Microsoft.EntityFrameworkCore;
using Movie_Models;

namespace Movie_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "History", DisplayOrder = 3 },
                new Category { CategoryId = 4, Name = "Comedy", DisplayOrder = 4 },
                new Category { CategoryId = 5, Name = "Drama", DisplayOrder = 5 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Title = "John Wick 4",
                    Actors = "john wick",
                    Description = "With the price on his head ever increasing, legendary hit man John Wick takes his fight against the High Table global as he seeks out the most powerful players in the underworld, from New York to Paris to Japan to Berlin.",
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
                Title = "John Wick 4",
                Actors = "john wick",
                Description = "With the price on his head ever increasing, legendary hit man John Wick takes his fight against the High Table global as he seeks out the most powerful players in the underworld, from New York to Paris to Japan to Berlin.",
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
                    Title = "John Wick 4",
                    Actors = "john wick",
                    Description = "With the price on his head ever increasing, legendary hit man John Wick takes his fight against the High Table global as he seeks out the most powerful players in the underworld, from New York to Paris to Japan to Berlin.",
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
