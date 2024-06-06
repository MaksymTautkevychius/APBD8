using APBD9.Data;
using Microsoft.AspNetCore.Mvc;

namespace APBD9.Controllers;


[Route("api/[controller]")]
[ApiController]
public class TripsController : ControllerBase
{
    private readonly ScaffoldContext _context;
    public TripsController(ScaffoldContext context)
    {
        _context = context;
    }
}