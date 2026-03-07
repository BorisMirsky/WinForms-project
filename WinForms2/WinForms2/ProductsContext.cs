
using Microsoft.EntityFrameworkCore;


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

        string connectionString = @"Data Source = C:\Users\Alexander\source\WinForms-project\WinForms2\WinForms2\Database\ProductsAndCategories.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString);

    }
}