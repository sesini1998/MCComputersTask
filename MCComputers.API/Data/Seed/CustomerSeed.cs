using MCComputers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.API.Data.Seed
{
    public static class CustomerSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Main St, Springfield",
                    Email = "john.doe@example.com",
                    Phone = "123-456-7890"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "456 Elm St, Metropolis",
                    Email = "jane.smith@example.com",
                    Phone = "098-765-4321"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Address = "789 Oak St, Gotham",
                    Email = "alice.johnson@example.com",
                    Phone = "567-890-1234"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Bob",
                    LastName = "Brown",
                    Address = "101 Pine St, Smallville",
                    Email = "bob.brown@example.com",
                    Phone = "432-109-8765"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Charlie",
                    LastName = "Davis",
                    Address = "202 Maple St, Star City",
                    Email = "charlie.davis@example.com",
                    Phone = "321-654-9870"
                }
            );
        }
    }
}
