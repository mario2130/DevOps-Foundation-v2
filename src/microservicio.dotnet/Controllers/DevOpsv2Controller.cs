using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace microservicio.dotnet.Controllers
{
    /// <summary>
    /// Controlador del curso devops
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DevOpsv2Controller : ControllerBase
    {
        readonly ILogger<DevOpsv2Controller> _logger;
        /// <summary>
        /// Constructor del api para el examen
        /// </summary>
        /// <param name="logger"></param>
        public DevOpsv2Controller(ILogger<DevOpsv2Controller> logger)
        => _logger = logger;

        /// <summary>
        /// Api expuesta para valiar
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> Get()
        { 
            return Ok("Finaliza el curso DevOpsFoundation V2 - Mario Villanueva");
        }
    }
}
