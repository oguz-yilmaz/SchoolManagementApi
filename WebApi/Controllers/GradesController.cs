using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GradesController : CrudController<Grade>
{
    public GradesController(IGradeService gradeService) : base(gradeService)
    {
    }
}