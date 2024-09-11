using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Project.Models.Domain_Classes
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Clothing> Clothings { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Footwear> Footwears { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customize the table names
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Clothing>().ToTable(nameof(Clothing));
            modelBuilder.Entity<Accessory>().ToTable(nameof(Accessory));
            modelBuilder.Entity<Footwear>().ToTable(nameof(Footwear));
        }
    }
}