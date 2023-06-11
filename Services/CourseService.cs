using Entities;
using Repositories;
using ServiceContracts.Services;

namespace Services;

public class CourseService : CrudService<Course>, ICourseService
{
    public CourseService(Repository<Course> courseRepository) : base(courseRepository)
    {
    }
}