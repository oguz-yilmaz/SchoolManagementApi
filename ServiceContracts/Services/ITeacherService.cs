using Entities;

namespace ServiceContracts.Services;

public interface ITeacherService
{
    Task<Teacher> GetTeacherAsync(int id);

    Task<List<Teacher>> GetAllTeachersAsync();

    Task<Teacher> AddTeacherAsync(Teacher teacher);

    Task<Teacher> UpdateTeacherAsync(Teacher teacher);

    Task<Teacher> DeleteTeacherAsync(int id);

    Task<bool> TeacherExistsAsync(int id);

    Task<List<Teacher>> AddTeacherToCourseAsync(int teacherId, int courseId);

    Task<List<Teacher>> RemoveTeacherFromCourseAsync(int teacherId, int courseId);
}