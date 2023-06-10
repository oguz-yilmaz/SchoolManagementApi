using Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase
{
    private readonly SchoolManagementDbContext _db;

    public CoursesController(SchoolManagementDbContext db)
    {
        _db = db;
    }
}