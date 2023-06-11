using Entities;

namespace ServiceContracts.Services;

public interface ITeacherService: ICrudService<Teacher>
{
    Task<List<Teacher>> AddTeacherToCourseAsync(int teacherId, int courseId);

    Task<List<Teacher>> RemoveTeacherFromCourseAsync(int teacherId, int courseId);
}