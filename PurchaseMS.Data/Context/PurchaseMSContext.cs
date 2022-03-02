using Microsoft.EntityFrameworkCore;
using PurchaseMS.Data.Configurations;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Data.Context
{
    public class PurchaseMSContext : DbContext
    {
        public PurchaseMSContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Buyer> Buyers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PurchaseConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseItemConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}