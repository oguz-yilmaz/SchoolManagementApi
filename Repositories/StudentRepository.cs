using Entities;
using ServiceContracts.Repositories;

namespace Repositories;

public class StudentRepository: IGenericRepository<Student>
{
    public Task<Student> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Student> AddAsync(Student entity)
    {
        throw new NotImplementedException();
    }

    public Task<Student> UpdateAsync(Student entity)
    {
        throw new NotImplementedException();
    }

    public Task<Student> DeleteAsync(Student entity)
    {
        throw new NotImplementedException();
    }

    public Task<Student> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    private readonly SchoolManagementDbContext _db;
    
    public StudentRepository(SchoolManagementDbContext context)
    {
        _db = context;
    }
}