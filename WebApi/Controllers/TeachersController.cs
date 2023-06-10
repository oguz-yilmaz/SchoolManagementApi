using Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeachersController : ControllerBase
{
    private readonly SchoolManagementDbContext _db;

    public TeachersController(SchoolManagementDbContext db)
    {
        _db = db;
    }
}