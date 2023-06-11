using Entities;

namespace ServiceContracts.Services;

public interface IStudentService
{
    Task<bool> StudentExistsAsync(int id);

    Task<List<Student>> GetAllStudentsAsync();

    Task<Student> GetStudent(int id);

    Task<Student> AddStudentAsync(Student student);

    Task<Student> UpdateStudentAsync(Student student);

    Task<Student> DeleteStudentAsync(int id);
}