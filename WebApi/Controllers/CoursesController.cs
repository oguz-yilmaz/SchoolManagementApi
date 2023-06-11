using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : CrudController<Course>
{
    public CoursesController(ICourseService courseService) : base(courseService)
    {
    }
}