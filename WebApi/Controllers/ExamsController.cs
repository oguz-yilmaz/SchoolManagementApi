using Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExamsController : ControllerBase
{
    private readonly SchoolManagementDbContext _db;

    public ExamsController(SchoolManagementDbContext db)
    {
        _db = db;
    }
}