using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMiddleware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hi Mahmut, it is sunny today!");
        }
    }
}