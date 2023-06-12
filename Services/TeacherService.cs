using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class TeacherService : CrudService<Teacher>, ITeacherService
{
    private readonly TeacherRepository teacherRepository;

    public TeacherService(TeacherRepository repo) : base(repo)
    {
        teacherRepository = repo;
    }

    public Task<List<Teacher>> GetTeachersByCourseIdAsync(int courseId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Course>> GetCoursesByTeacherIdAsync(int teacherId)
    {
        return await teacherRepository.GetCoursesByTeacherIdAsync(teacherId);
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