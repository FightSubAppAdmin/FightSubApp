using Microsoft.AspNetCore.Mvc;

namespace DojoConnect.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class GymController : ControllerBase
{
    private readonly ILogger<GymController> _logger;

    public GymController(ILogger<GymController> logger)
    {
        _logger = logger;
    }
}