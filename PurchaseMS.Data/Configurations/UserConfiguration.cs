using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Name);
            builder.Property(x => x.Surname);
            builder.Property(x => x.Email);
            builder.Property(x => x.Username);
        }
    }
}