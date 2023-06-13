using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class StudentRepository : Repository<Student>
{
    private readonly SchoolManagementDbContext _db;

    public StudentRepository(SchoolManagementDbContext context) : base(context)
    {
        _db = context;
    }

    public async Task<List<Course>?> GetByCourseIdAsync(int studentId)
    {
        var student = await _db.Students
            .Include(s => s.Courses)
            .FirstOrDefaultAsync(s => s.StudentId == studentId);

        return student?.Courses.ToList();
    }

    public async Task<List<Grade>?> GetAllGradesAsync(int studentId)
    {
        var student = await _db.Students
            .Include(s => s.Grades)
            .FirstOrDefaultAsync(s => s.StudentId == studentId);

        return student?.Grades.ToList();
    }
}