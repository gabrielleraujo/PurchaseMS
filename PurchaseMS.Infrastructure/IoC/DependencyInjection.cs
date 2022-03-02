using Microsoft.Extensions.DependencyInjection;
using PurchaseMS.ApplicationService.Interfaces;
using PurchaseMS.DomainService.Interfaces;
using PurchaseMS.Infrastructure.Data.Repository;
using PurchaseMS.Domain.Models.Discounts;
using PurchaseMS.Domain.Models.Discounts.Interfaces;
using PurchaseMS.DomainService.Mappers;

namespace PurchaseMS.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection service)
        {
            // Mapper
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            service.AddTransient<ICustomMapper, CustomMapper>();

            // Domain
            service.AddTransient<IChainOfDiscounts, ChainOfDiscounts>();

            // ApplicationService
            AddApplicationServices(service);

            // DomainService
            AddDomainServices(service);

            // Repository
            AddRepository(service);
        }

        private static void AddApplicationServices(IServiceCollection service)
        {
            service.AddTransient<IPurchaseApplicationService, PurchaseApplicationService>();
        }

        private static void AddDomainServices(IServiceCollection service)
        {
            service.AddTransient<IPurchaseDomainService, PurchaseDomainService>();
        }

        private static void AddRepository(IServiceCollection service)
        {
            service.AddScoped(typeof(IPurchaseRepository<>), typeof(PurchaseRepository<>));
        }
    }
}