using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace devempower_api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Home()
        {
            return Ok("Welcome To DevEmpower API project");
        }
    }
}
