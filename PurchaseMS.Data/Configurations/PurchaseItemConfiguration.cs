using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Data.Configurations
{
    public class PurchaseItemConfiguration : IEntityTypeConfiguration<PurchaseItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseItem> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.PurchaseId);
            builder.Property(x => x.ProductId);
            builder.Property(x => x.UnitPrice);
            builder.Property(x => x.Quantity);

            builder.Ignore(x => x.Product);
        }
    }
}