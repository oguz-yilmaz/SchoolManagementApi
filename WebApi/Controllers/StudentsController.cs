using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
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
        try
        {
            return await _studentService.GetAllAsync();
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new { message = "An error occurred while processing your request." });
        }
    }

    [HttpPost]
    public async Task<ActionResult<Student>> CreateStudentAsync([FromBody] Student newStudent)
    {
        try
        {
            return await _studentService.AddAsync(newStudent);
        }
        catch (DbUpdateException ex)
        {
            return Conflict(new { message = "A student with this email already exists." });
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new { message = "An error occurred while processing your request." });
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Student>> GetStudentByIdAsync(int id)
    {
        var student = await _studentService.Get(id);

        if (student == null)
        {
            return NotFound();
        }

        return student;
    }


    [HttpPut("{id:int}")]
    public async Task<ActionResult<Student>> UpdateStudentAsync(int id, [FromBody] Student student)
    {
        student.StudentId = id;

        var updatedStudent = await _studentService.UpdateAsync(student);

        return Ok(updatedStudent);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Student>> DeleteStudentAsync(int id)
    {
        return await _studentService.DeleteAsync(id);
    }
}