using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class StudentService : CrudService<Student>, IStudentService
{
    private readonly StudentRepository studentRepository;

    public StudentService(StudentRepository repo) : base(repo)
    {
        studentRepository = repo;
    }

    public async Task<List<Course>?> GetStudentCoursesByIdAsync(int studentId)
    {
        return await studentRepository.GetByCourseIdAsync(studentId);
    }

    public Task<List<Student>> GetStudentsByCourseNameAsync(string courseName)
    {
        throw new NotImplementedException();
    }
}