using Entities;
using ServiceContracts.Repositories;
using ServiceContracts.Services;

namespace Services;

public class StudentService: IStudentService
{
    private readonly IGenericRepository<Student> _studentRepository;
    
    public StudentService(IGenericRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }
    
    public Task<List<Student>> GetAllStudentsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Student> GetStudentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Student> AddStudentAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<Student> UpdateStudentAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<Student> DeleteStudentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Student> DeleteStudentAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> GetStudentsByCourseIdAsync(int courseId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> GetStudentsByCourseNameAsync(string courseName)
    {
        throw new NotImplementedException();
    }
}