using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEmpowerApiV6.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Welcome To DevEmpower API project. To See swagger, Got to: https://api.devempower.ir/swagger/index.html");
        }
    }
}
