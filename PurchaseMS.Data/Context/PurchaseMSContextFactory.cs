using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PurchaseMS.Data.Context;

namespace PurchaseMS.Infrastructure.Data.SqlServer.Context
{
    public class PurchaseMSContextFactory : IDesignTimeDbContextFactory<PurchaseMSContext>
    {
        //método utilizado pelo Migrations para inicializar a classe
        //PaymentContext utilizando os atributos do appsettings.json
        public PurchaseMSContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<PurchaseMSContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new PurchaseMSContext(builder.Options);
        }
    }
}