using Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly SchoolManagementDbContext _db;

    public StudentsController(SchoolManagementDbContext db)
    {
        _db = db;
    }
}