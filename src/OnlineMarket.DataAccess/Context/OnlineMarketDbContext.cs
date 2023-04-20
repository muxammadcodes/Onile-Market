using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Entities;

namespace OnlineMarket.DataAccess.Context
{
    public class OnlineMarketDbContext : DbContext
    {
        public OnlineMarketDbContext(DbContextOptions<OnlineMarketDbContext> options)
            :base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Product> seedData = new List<Product>() {
    new Product {
        Id = 1,
        Name = "Apple iPhone 13 Pro Max",
        Count = 10,
        Price = 1099.99m,
        Description = "A high-end smartphone with 6.7-inch Super Retina XDR display and 5G connectivity.",
        CreatedAt = DateTime.UtcNow
    },
    new Product {
        Id = 2,
        Name = "Samsung Galaxy S21",
        Count = 5,
        Price = 799.99m,
        Description = "A mid-range smartphone with 6.2-inch Dynamic AMOLED display and 5G connectivity.",
        CreatedAt = DateTime.UtcNow

    },
    new Product {
        Id = 3,
        Name = "Motorola Razr 5G",
        Count = 2,
        Price = 1399.99m,
        Description = "A foldable smartphone with 6.2-inch Flex View OLED display and 5G connectivity.",
        CreatedAt = DateTime.UtcNow
    },
    new Product {
        Id = 4,
        Name = "Xiaomi Redmi 10",
        Count = 15,
        Price = 179.99m,
        Description = "A budget smartphone with 6.5-inch IPS LCD display and 4G connectivity.",
        CreatedAt = DateTime.UtcNow

    },
    new Product {
        Id = 5,
        Name = "OnePlus 9 Pro",
        Count = 7,
        Price = 899.99m,
        Description = "A high-end smartphone with 6.7-inch Fluid AMOLED display and 5G connectivity.",
        CreatedAt= DateTime.UtcNow
    }
    
};

            modelBuilder.Entity<Product>().HasData(seedData);

        }
    }
}
