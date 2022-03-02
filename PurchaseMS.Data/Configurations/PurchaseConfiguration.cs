using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PurchaseMS.Data.Utils;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Data.Configurations
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BuyerId);
            builder.Property(x => x.Price);
            builder.Property(x => x.Date);
            builder.Property(x => x.FreightValue);

            builder.HasOne(x => x.Buyer);
            builder.HasMany(x => x.PurchaseItems);


            builder.OwnsOne(x => x.Address, y =>
            {
                y.Property(y => y.Street)
                    .HasColumnName("Street");

                y.Property(y => y.ZipCode)
                    .HasColumnName("ZipCode");

                y.Property(y => y.UF)
                    .HasColumnName("UF");

                y.Property(y => y.City)
                    .HasColumnName("City");

                y.Property(y => y.Neighborhood)
                   .HasColumnName("Neighborhood");

                y.Property(y => y.Number)
                    .HasColumnName("Number");

                y.Property(y => y.Complement)
                    .HasColumnName("Complement");
            });


            builder.Property(x => x.State)
                .HasColumnName("Status")
                .HasConversion(
                    v => v.GetType().Name,
                    v => v.GetState());
        }
    }
}