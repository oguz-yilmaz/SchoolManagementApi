using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class TeacherService : CrudService<Teacher>, ITeacherService
{
    public TeacherService(Repository<Teacher> teacherRepository) : base(teacherRepository)
    {
    }

    public Task<List<Teacher>> AddTeacherToCourseAsync(int teacherId, int courseId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> RemoveTeacherFromCourseAsync(int teacherId, int courseId)
    {
        throw new NotImplementedException();
    }
}