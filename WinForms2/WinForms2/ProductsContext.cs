
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Configuration;



namespace WinForms2
{
    public class ProductsContext : DbContext
    {

        public DbSet<Product> Products { get; set; } = null!;
        
        public DbSet<Category> Categories { get; set; } = null!;

        static string? connString = ConfigurationManager.AppSettings["ConnectionString"];
        string connectionString = $"Data Source = {connString}";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString);

    }
}