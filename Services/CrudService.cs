using Repositories;

namespace Services;

public class CrudService<T> where T : class
{
    private readonly Repository<T> _entityRepository;

    public CrudService(Repository<T> entityRepository)
    {
        _entityRepository = entityRepository;
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _entityRepository.GetByIdAsync(id) != null;
    }

    public async Task<T?> Get(int id)
    {
        return await _entityRepository.GetByIdAsync(id);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _entityRepository.GetAllAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        return await _entityRepository.AddAsync(entity);
    }

    public async Task<T> UpdateAsync(T entity)
    {
        return await _entityRepository.UpdateAsync(entity);
    }

    public async Task<T> DeleteAsync(int id)
    {
        return await _entityRepository.DeleteAsync(id);
    }
}