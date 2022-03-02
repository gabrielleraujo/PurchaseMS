using PurchaseMS.Infrastructure.Data.Repository;
using PurchaseMS.Domain.Models.Abstracts;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Infrastructure.Data.Repository
{
    public interface IPurchaseRepository<T> : IBaseRepository<T> where T : Entity 
    {
		Task<IList<Purchase>> ListIncludingAsync();
		Task<Purchase> GetByIdIncludingAsync(int id);
	}
}