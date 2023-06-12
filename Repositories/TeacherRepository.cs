using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class TeacherRepository : Repository<Teacher>
{
    private readonly SchoolManagementDbContext _db;

    public TeacherRepository(SchoolManagementDbContext context) : base(context)
    {
        _db = context;
    }

    public async Task<List<Course>?> GetCoursesByTeacherIdAsync(int teacherId)
    {
        var teacher = await _db.Teachers
            .Include(t => t.Courses)
            .FirstOrDefaultAsync(t => t.TeacherId == teacherId);

        return teacher?.Courses.ToList();
    }
}