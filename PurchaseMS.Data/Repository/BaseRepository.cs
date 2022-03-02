using Microsoft.EntityFrameworkCore;
using PurchaseMS.Data.Context;

namespace PurchaseMS.Infrastructure.Data.Repository
{
	public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected readonly PurchaseMSContext context;
		protected DbSet<T> dbSet;

        public BaseRepository(PurchaseMSContext dbContext)
        {
			context = dbContext;
			dbSet = context.Set<T>();
        }

		public async Task AddAsync(T entity)
		{
			await dbSet.AddAsync(entity);

			//var id = entity.GetType().GetProperty("Id").GetValue(entity, null);
			//var idInt = Convert.ToInt32(id);
		}

        public async Task<IList<T>> ListAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(Func<T, bool> predicate)
		{
			return dbSet.Where(predicate).FirstOrDefault();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await dbSet.FindAsync(id);
		}

		public async Task Commit()
		{
			await context.SaveChangesAsync();
		}
	}
}