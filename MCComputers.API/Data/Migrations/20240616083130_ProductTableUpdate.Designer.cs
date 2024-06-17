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
    [Migration("20240616083130_ProductTableUpdate")]
    partial class ProductTableUpdate
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
                            Id = new Guid("2ce56de1-99da-47af-a059-fe9af9970a6f"),
                            Address = "123 Main St, Springfield",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            Id = new Guid("104d6b1c-888c-4b5f-8ec3-fa133971fb97"),
                            Address = "456 Elm St, Metropolis",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Phone = "098-765-4321"
                        },
                        new
                        {
                            Id = new Guid("3d3fda79-57ec-44ab-8fe1-23ce979002d3"),
                            Address = "789 Oak St, Gotham",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Phone = "567-890-1234"
                        },
                        new
                        {
                            Id = new Guid("07d13732-5948-4eec-80dc-32b920e499d0"),
                            Address = "101 Pine St, Smallville",
                            Email = "bob.brown@example.com",
                            FirstName = "Bob",
                            LastName = "Brown",
                            Phone = "432-109-8765"
                        },
                        new
                        {
                            Id = new Guid("3f6273c6-215f-4112-8701-1d0155d9e0ec"),
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

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

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
                            Id = new Guid("09e11d2b-79c9-4333-8307-20a721a7e4c6"),
                            Description = "High-performance laptop",
                            Discount = 0.10m,
                            Price = 1500.00m,
                            ProductName = "Laptop",
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = new Guid("7f6cfbb3-3556-4f0a-a901-ce11d09b82cd"),
                            Description = "Wireless mouse",
                            Discount = 0.05m,
                            Price = 25.00m,
                            ProductName = "Mouse",
                            StockQuantity = 100
                        },
                        new
                        {
                            Id = new Guid("37f5eb29-c979-4725-89e1-202d0a340946"),
                            Description = "Mechanical keyboard",
                            Discount = 0.05m,
                            Price = 75.00m,
                            ProductName = "Keyboard",
                            StockQuantity = 50
                        },
                        new
                        {
                            Id = new Guid("d9c7dda2-6fc4-4345-b16c-dc69c8fd0868"),
                            Description = "24-inch monitor",
                            Discount = 0.10m,
                            Price = 200.00m,
                            ProductName = "Monitor",
                            StockQuantity = 20
                        },
                        new
                        {
                            Id = new Guid("b7c49e5f-647c-414d-8afe-bb66ae3036b2"),
                            Description = "Noise-cancelling headphones",
                            Discount = 0.05m,
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