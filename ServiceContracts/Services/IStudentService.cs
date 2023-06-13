using Entities;

namespace ServiceContracts.Services;

public interface IStudentService : ICrudService<Student>
{
    Task<List<Course>> GetStudentCoursesByIdAsync(int studentId);

    Task<List<Student>> GetStudentsByCourseNameAsync(string courseName);
}