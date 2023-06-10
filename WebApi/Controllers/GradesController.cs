using Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GradesController : ControllerBase
{
    private readonly SchoolManagementDbContext _db;

    public GradesController(SchoolManagementDbContext db)
    {
        _db = db;
    }
}