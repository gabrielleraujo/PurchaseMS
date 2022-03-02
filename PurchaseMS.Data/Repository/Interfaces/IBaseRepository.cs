namespace PurchaseMS.Infrastructure.Data.Repository
{
	public interface IBaseRepository<T> where T : class
	{
		Task AddAsync(T entity);
		Task<IList<T>> ListAsync();
		Task<T> GetAsync(Func<T, bool> predicate);
		Task<T> GetByIdAsync(int id);
		Task Commit();
	}
}