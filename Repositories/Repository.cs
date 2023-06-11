using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class Repository<TEntity> where TEntity : class
{
    private readonly SchoolManagementDbContext _db;

    public Repository(SchoolManagementDbContext context)
    {
        _db = context;
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _db.FindAsync<TEntity>(id);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _db.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> AddAsync(TEntity student)
    {
        await _db.Set<TEntity>().AddAsync(student);
        await _db.SaveChangesAsync();

        return student;
    }

    public async Task<TEntity> UpdateAsync(TEntity student)
    {
        _db.Set<TEntity>().Update(student);
        await _db.SaveChangesAsync();

        return student;
    }

    public async Task<TEntity> DeleteAsync(int id)
    {
        var entity = await _db.Set<TEntity>().FindAsync(id);

        if (entity != null)
        {
            _db.Set<TEntity>().Remove(entity);

            await _db.SaveChangesAsync();
        }

        return entity;
    }
}