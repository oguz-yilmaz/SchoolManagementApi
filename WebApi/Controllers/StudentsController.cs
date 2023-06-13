using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : CrudController<Student>
{
    private readonly IStudentService studentService;

    public StudentsController(IStudentService service) : base(service)
    {
        studentService = service;
    }

    [HttpGet("{studentId:int}/courses")]
    public async Task<ActionResult<List<Course>>> CoursesAsync(int studentId)
    {
        return await studentService.GetStudentCoursesByIdAsync(studentId);
    }
    
    [HttpGet("{studentId:int}/grades")]
    public async Task<ActionResult<List<Grade>>> GradesAsync(int studentId)
    {
        return await studentService.GetAllGradesAsync(studentId);
    }
}