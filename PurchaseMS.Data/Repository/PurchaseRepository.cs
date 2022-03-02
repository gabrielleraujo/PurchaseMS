using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PurchaseMS.Data.Context;
using PurchaseMS.Domain.Models.Abstracts;
using PurchaseMS.Domain.Models.Entities;
using System.Linq;

namespace PurchaseMS.Infrastructure.Data.Repository
{
    public class PurchaseRepository<T> : BaseRepository<T>, IPurchaseRepository<T> where T : Entity
    {
        public PurchaseRepository(PurchaseMSContext context) : base(context)
        { }

		public async Task<IList<Purchase>> ListIncludingAsync()
		{
			return await IncludeProperties().ToListAsync();
		}

		public async Task<Purchase> GetByIdIncludingAsync(int id)
		{
			return await IncludeProperties().FirstOrDefaultAsync();
		}

		private IIncludableQueryable<Purchase, Buyer> IncludeProperties()
		{
			return context.Purchases
				.Include(x => x.PurchaseItems)
				.Include(x => x.Buyer);
		}
	}
}