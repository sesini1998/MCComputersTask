using MCComputers.API.Data.Seed;
using MCComputers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Invoice>()
            //.HasMany(i => i.InvoiceItems)
            //.WithOne(ii => ii.Invoice)
            //.HasForeignKey(ii => ii.InvoiceId);

            //modelBuilder.Entity<InvoiceItem>()
            //    .HasOne(ii => ii.Invoice)
            //    .WithMany(i => i.InvoiceItems)
            //    .HasForeignKey(ii => ii.InvoiceId);


            CustomerSeed.Seed(modelBuilder);
            ProductSeed.Seed(modelBuilder);
        }
    }
}
