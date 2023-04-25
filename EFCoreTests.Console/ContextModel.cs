using EFCoreTests.Console.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTests.Console
{
    public class ContextModel: DbContext
    {
        DbSet<Shopify_Product> Shopify_Product { get; set; }
        DbSet<Shopify_Product_Variant> Shopify_Product_Variant { get; set; }
        DbSet<Shopify_ProductImage> Shopify_ProductImage { get; set; }
        DbSet<Shopify_ProductOption> Shopify_ProductOption { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // DONT USE THIS IN A NORMAL PROJECT!!! THIS IS FOR TESTING OBVIOUSLY!!!!!! THIS SHOULD BE ON CONFIGURATION!!! ALSO DONT USE PASSWORD WITHOUT ENCRIPTION OR TRUST SERVER CERTIFICATE!!!!
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EFTests;Persist Security Info=True;User ID=sa;Password=fruta2005;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            // Primary Keys for all tables:
            modelBuilder.Entity<Shopify_Product>()
                .HasKey(e => e.ID);

            modelBuilder.Entity<Shopify_Product_Variant>()
                .HasKey(e => e.ID);

            modelBuilder.Entity<Shopify_ProductImage>()
                .HasKey(e => e.ID);

            modelBuilder.Entity<Shopify_ProductOption>()
                .HasKey(e => e.ID);

            // Foreign Keys relationships:
            modelBuilder.Entity<Shopify_Product>()
                .HasMany(c => c.Variants)
                .WithOne(e => e.Product)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Shopify_Product>()
                .HasMany(c => c.Images)
                .WithOne(e => e.Product)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Shopify_Product>()
                .HasMany(c => c.Options)
                .WithOne(e => e.Product)
                .OnDelete(DeleteBehavior.Cascade);
            */
        }
    }
}
