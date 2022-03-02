using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PurchaseMS.Data.Context;

namespace PurchaseMS.Infrastructure.IoC
{
    public static class Database
    {
        public static void AddDatabase(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<PurchaseMSContext>(opt => opt
                        .UseSqlServer(configuration.GetConnectionString("PurchaseMSConnection")));
        }
    }
}