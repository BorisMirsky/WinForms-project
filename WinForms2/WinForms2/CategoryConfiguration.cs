

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace WinForms2
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(d => d.CategoryId);

            builder
                .HasMany(d => d.Products)
                .WithOne(t => t.Category);
        }
        //void IEntityTypeConfiguration<Category>.Configure(EntityTypeBuilder<Category> builder)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
