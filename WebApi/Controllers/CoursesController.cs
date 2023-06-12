using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : CrudController<Course>
{
    public CoursesController(ICourseService courseService) : base(courseService)
    {
    }
}