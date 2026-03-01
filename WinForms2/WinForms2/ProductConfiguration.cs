

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace WinForms2
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(d => d.ProductId);

            builder.HasOne(d => d.Category)
                .WithMany(r => r.Products)
                .HasForeignKey(d => d.CategoryId)
                .IsRequired();
        }
        //void IEntityTypeConfiguration<Product>.Configure(EntityTypeBuilder<Product> builder)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
