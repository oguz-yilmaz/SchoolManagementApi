namespace ServiceContracts.Services;

public interface ICrudService<T> where T : class
{
    Task<bool> ExistsAsync(int id);

    Task<T?> Get(int id);

    Task<List<T>> GetAllAsync();

    Task<T> AddAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task<T> DeleteAsync(int id);
}