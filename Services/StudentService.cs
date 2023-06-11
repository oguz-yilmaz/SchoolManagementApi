using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class StudentService : CrudService<Student>, IStudentService
{
    public StudentService(Repository<Student> studentRepository) : base(studentRepository)
    {
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