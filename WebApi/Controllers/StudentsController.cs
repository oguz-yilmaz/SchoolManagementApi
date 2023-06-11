using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : CrudController<Student>
{
    public StudentsController(IStudentService studentService) : base(studentService)
    {
    }
}