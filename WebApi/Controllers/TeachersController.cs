using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeachersController : CrudController<Teacher>
{
    private readonly ITeacherService teacherService;

    public TeachersController(ITeacherService service) : base(service)
    {
        teacherService = service;
    }

    [HttpGet("{id:int}/courses")]
    public async Task<ActionResult<List<Course>>> CoursesAsync(int id)
    {
        return await teacherService.GetCoursesByTeacherIdAsync(id);
    }
}