using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MCComputers.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { new Guid("07d13732-5948-4eec-80dc-32b920e499d0"), "101 Pine St, Smallville", "bob.brown@example.com", "Bob", "Brown", "432-109-8765" },
                    { new Guid("104d6b1c-888c-4b5f-8ec3-fa133971fb97"), "456 Elm St, Metropolis", "jane.smith@example.com", "Jane", "Smith", "098-765-4321" },
                    { new Guid("2ce56de1-99da-47af-a059-fe9af9970a6f"), "123 Main St, Springfield", "john.doe@example.com", "John", "Doe", "123-456-7890" },
                    { new Guid("3d3fda79-57ec-44ab-8fe1-23ce979002d3"), "789 Oak St, Gotham", "alice.johnson@example.com", "Alice", "Johnson", "567-890-1234" },
                    { new Guid("3f6273c6-215f-4112-8701-1d0155d9e0ec"), "202 Maple St, Star City", "charlie.davis@example.com", "Charlie", "Davis", "321-654-9870" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("09e11d2b-79c9-4333-8307-20a721a7e4c6"), "High-performance laptop", 0.10m, 1500.00m, "Laptop", 10 },
                    { new Guid("37f5eb29-c979-4725-89e1-202d0a340946"), "Mechanical keyboard", 0.05m, 75.00m, "Keyboard", 50 },
                    { new Guid("7f6cfbb3-3556-4f0a-a901-ce11d09b82cd"), "Wireless mouse", 0.05m, 25.00m, "Mouse", 100 },
                    { new Guid("b7c49e5f-647c-414d-8afe-bb66ae3036b2"), "Noise-cancelling headphones", 0.05m, 150.00m, "Headphones", 30 },
                    { new Guid("d9c7dda2-6fc4-4345-b16c-dc69c8fd0868"), "24-inch monitor", 0.10m, 200.00m, "Monitor", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("07d13732-5948-4eec-80dc-32b920e499d0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("104d6b1c-888c-4b5f-8ec3-fa133971fb97"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2ce56de1-99da-47af-a059-fe9af9970a6f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d3fda79-57ec-44ab-8fe1-23ce979002d3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3f6273c6-215f-4112-8701-1d0155d9e0ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09e11d2b-79c9-4333-8307-20a721a7e4c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37f5eb29-c979-4725-89e1-202d0a340946"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f6cfbb3-3556-4f0a-a901-ce11d09b82cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7c49e5f-647c-414d-8afe-bb66ae3036b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9c7dda2-6fc4-4345-b16c-dc69c8fd0868"));

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Products");

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
    }
}
