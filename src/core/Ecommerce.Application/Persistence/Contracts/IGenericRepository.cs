namespace Ecommerce.Application.Persistence.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetAsync(int id);
    Task<T> CreateAsync(T entity);
    Task DeleteAsync(int id);
    Task<T> UpdateAsync(T entity);
    Task<T> SaveChangesAsync();
}
