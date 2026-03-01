
using Microsoft.EntityFrameworkCore;
using System.Configuration;



namespace WinForms2
{
    public class ProductsContext : DbContext
    {

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Database/ProductsAndCategories.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configuration.ProductConfiguration());
            modelBuilder.ApplyConfiguration(new Configuration.CategoryConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}