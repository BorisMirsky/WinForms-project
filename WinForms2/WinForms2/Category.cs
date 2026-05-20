using Microsoft.EntityFrameworkCore.ChangeTracking;
using WinForms2;


namespace WinForms2
{
    public class Category
    {
        public int CategoryId { get; set; }       
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
