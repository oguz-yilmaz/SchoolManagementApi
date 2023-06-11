using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GradesController : CrudController<Grade>
{
    public GradesController(IGradeService gradeService) : base(gradeService)
    {
    }
}