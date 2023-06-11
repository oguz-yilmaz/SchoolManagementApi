using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService service)
    {
        _studentService = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAllStudentsAsync()
    {
        return await _studentService.GetAllStudentsAsync();
    }
}