
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;



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

        //string connection = builder.Configuration.GetConnectionString("DefaultConnection");
        //builder.Services.AddDbContext<ForumContext>(options => options.UseSqlServer(connection));

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new Configuration.ProductConfiguration());
        //    modelBuilder.ApplyConfiguration(new Configuration.CategoryConfiguration());
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}