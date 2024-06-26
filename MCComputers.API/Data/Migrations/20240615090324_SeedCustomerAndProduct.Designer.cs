﻿// <auto-generated />
using System;
using MCComputers.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MCComputers.API.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240615090324_SeedCustomerAndProduct")]
    partial class SeedCustomerAndProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MCComputers.API.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb21e3a7-0744-4dc3-ae14-1409a0249270"),
                            Address = "123 Main St, Springfield",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            Id = new Guid("0101ace2-ccc2-41f9-acbe-28003c15d60d"),
                            Address = "456 Elm St, Metropolis",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Phone = "098-765-4321"
                        },
                        new
                        {
                            Id = new Guid("a53074dc-640b-48dd-b54c-5c7884206b14"),
                            Address = "789 Oak St, Gotham",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Phone = "567-890-1234"
                        },
                        new
                        {
                            Id = new Guid("69dcb200-860f-4fbf-873f-698ee68b8e26"),
                            Address = "101 Pine St, Smallville",
                            Email = "bob.brown@example.com",
                            FirstName = "Bob",
                            LastName = "Brown",
                            Phone = "432-109-8765"
                        },
                        new
                        {
                            Id = new Guid("934ed36e-0e4a-4369-a36a-5103c545d857"),
                            Address = "202 Maple St, Star City",
                            Email = "charlie.davis@example.com",
                            FirstName = "Charlie",
                            LastName = "Davis",
                            Phone = "321-654-9870"
                        });
                });

            modelBuilder.Entity("MCComputers.API.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("BalanceAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("MCComputers.API.Models.InvoiceItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("InvoiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceItems");
                });

            modelBuilder.Entity("MCComputers.API.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("66679521-a1dc-4959-b07d-03f04ed6506f"),
                            Description = "High-performance laptop",
                            Price = 1500.00m,
                            ProductName = "Laptop",
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = new Guid("61750607-2ee3-45da-991d-d2e3a6fd59ea"),
                            Description = "Wireless mouse",
                            Price = 25.00m,
                            ProductName = "Mouse",
                            StockQuantity = 100
                        },
                        new
                        {
                            Id = new Guid("fed5d892-7cc4-4c12-a260-3e682f9acfe9"),
                            Description = "Mechanical keyboard",
                            Price = 75.00m,
                            ProductName = "Keyboard",
                            StockQuantity = 50
                        },
                        new
                        {
                            Id = new Guid("97b85c0d-90a6-4934-b057-b62da5237613"),
                            Description = "24-inch monitor",
                            Price = 200.00m,
                            ProductName = "Monitor",
                            StockQuantity = 20
                        },
                        new
                        {
                            Id = new Guid("5de0fbb6-4cae-49a0-b43a-2c6ff3bc6980"),
                            Description = "Noise-cancelling headphones",
                            Price = 150.00m,
                            ProductName = "Headphones",
                            StockQuantity = 30
                        });
                });

            modelBuilder.Entity("MCComputers.API.Models.Invoice", b =>
                {
                    b.HasOne("MCComputers.API.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MCComputers.API.Models.InvoiceItem", b =>
                {
                    b.HasOne("MCComputers.API.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MCComputers.API.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
