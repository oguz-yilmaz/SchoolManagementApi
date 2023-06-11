using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeachersController : CrudController<Teacher>
{
    public TeachersController(ITeacherService teacherService) : base(teacherService)
    {
    }
}