using MCComputers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.API.Data.Seed
{
    public static class ProductSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Laptop",
                    Description = "High-performance laptop",
                    Price = 1500.00M,
                    StockQuantity = 10,
                    Discount = 0.10M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Mouse",
                    Description = "Wireless mouse",
                    Price = 25.00M,
                    StockQuantity = 100,
                    Discount = 0.05M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Keyboard",
                    Description = "Mechanical keyboard",
                    Price = 75.00M,
                    StockQuantity = 50,
                    Discount = 0.05M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Monitor",
                    Description = "24-inch monitor",
                    Price = 200.00M,
                    StockQuantity = 20,
                    Discount = 0.10M
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Headphones",
                    Description = "Noise-cancelling headphones",
                    Price = 150.00M,
                    StockQuantity = 30,
                    Discount = 0.05M
                }
            );
        }
    }
}
