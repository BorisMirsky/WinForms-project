using Microsoft.EntityFrameworkCore.ChangeTracking;
using WinForms2;


namespace WinForms2
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        public string? Name { get; set; }

        //public virtual ObservableCollectionListSource<Product> Products { get; } = new();
        //public List<MedicalRecord>? MedicalRecords { get; set; }
        public List<Product>? Products { get; set; }
    }
}
