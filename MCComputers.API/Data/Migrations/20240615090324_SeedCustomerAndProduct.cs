using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MCComputers.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerAndProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("0101ace2-ccc2-41f9-acbe-28003c15d60d"), "456 Elm St, Metropolis", "jane.smith@example.com", "Jane", "Smith", "098-765-4321" },
                    { new Guid("69dcb200-860f-4fbf-873f-698ee68b8e26"), "101 Pine St, Smallville", "bob.brown@example.com", "Bob", "Brown", "432-109-8765" },
                    { new Guid("934ed36e-0e4a-4369-a36a-5103c545d857"), "202 Maple St, Star City", "charlie.davis@example.com", "Charlie", "Davis", "321-654-9870" },
                    { new Guid("a53074dc-640b-48dd-b54c-5c7884206b14"), "789 Oak St, Gotham", "alice.johnson@example.com", "Alice", "Johnson", "567-890-1234" },
                    { new Guid("bb21e3a7-0744-4dc3-ae14-1409a0249270"), "123 Main St, Springfield", "john.doe@example.com", "John", "Doe", "123-456-7890" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("5de0fbb6-4cae-49a0-b43a-2c6ff3bc6980"), "Noise-cancelling headphones", 150.00m, "Headphones", 30 },
                    { new Guid("61750607-2ee3-45da-991d-d2e3a6fd59ea"), "Wireless mouse", 25.00m, "Mouse", 100 },
                    { new Guid("66679521-a1dc-4959-b07d-03f04ed6506f"), "High-performance laptop", 1500.00m, "Laptop", 10 },
                    { new Guid("97b85c0d-90a6-4934-b057-b62da5237613"), "24-inch monitor", 200.00m, "Monitor", 20 },
                    { new Guid("fed5d892-7cc4-4c12-a260-3e682f9acfe9"), "Mechanical keyboard", 75.00m, "Keyboard", 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("0101ace2-ccc2-41f9-acbe-28003c15d60d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("69dcb200-860f-4fbf-873f-698ee68b8e26"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("934ed36e-0e4a-4369-a36a-5103c545d857"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a53074dc-640b-48dd-b54c-5c7884206b14"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("bb21e3a7-0744-4dc3-ae14-1409a0249270"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5de0fbb6-4cae-49a0-b43a-2c6ff3bc6980"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61750607-2ee3-45da-991d-d2e3a6fd59ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66679521-a1dc-4959-b07d-03f04ed6506f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97b85c0d-90a6-4934-b057-b62da5237613"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fed5d892-7cc4-4c12-a260-3e682f9acfe9"));
        }
    }
}
