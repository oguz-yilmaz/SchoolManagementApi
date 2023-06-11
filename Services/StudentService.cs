using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class StudentService : IStudentService
{
    private readonly Repository<Student> _studentRepository;

    public StudentService(Repository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<bool> StudentExistsAsync(int id)
    {
        return await _studentRepository.GetByIdAsync(id) != null;
    }

    public Task<Student> GetStudent(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Student>> GetAllStudentsAsync()
    {
        return await _studentRepository.GetAllAsync();
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