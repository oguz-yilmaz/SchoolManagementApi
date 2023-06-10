using Entities;

namespace ServiceContracts.Services;

public interface IStudentService
{
    Task<List<Student>> GetAllStudentsAsync();
    
    Task<Student> GetStudentByIdAsync(int id);
    
    Task<Student> AddStudentAsync(Student student);
    
    Task<Student> UpdateStudentAsync(Student student);
    
    Task<Student> DeleteStudentAsync(int id);
    
    Task<Student> DeleteStudentAsync(Student student);
    
    Task<List<Student>> GetStudentsByCourseIdAsync(int courseId);
    
    Task<List<Student>> GetStudentsByCourseNameAsync(string courseName);
}