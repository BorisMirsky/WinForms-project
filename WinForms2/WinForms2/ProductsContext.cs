
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Diagnostics;



namespace WinForms2
{
    public class ProductsContext : DbContext
    {
        //public ProductsContext(DbContextOptions<ProductsContext> options)
        //: base(options)
        //{
        //}

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        string connectionString = @"Data Source=C:\Users\Alexander\source\WinForms-project\WinForms2\Database\ProductsAndCategories.db;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString); 

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new Configuration.ProductConfiguration());
        //    modelBuilder.ApplyConfiguration(new Configuration.CategoryConfiguration());
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}