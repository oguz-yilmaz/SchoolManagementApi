using Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExamsController : CrudController<Exam>
{
    public ExamsController(IExamService examService) : base(examService)
    {
    }
}