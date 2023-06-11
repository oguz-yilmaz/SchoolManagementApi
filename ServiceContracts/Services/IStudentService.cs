using Entities;

namespace ServiceContracts.Services;

public interface IStudentService : ICrudService<Student>
{
    Task<List<Student>> GetStudentsByCourseIdAsync(int courseId);

    Task<List<Student>> GetStudentsByCourseNameAsync(string courseName);
}