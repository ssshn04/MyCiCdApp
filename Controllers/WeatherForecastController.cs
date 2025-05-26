using Microsoft.AspNetCore.Mvc;

namespace MyCiCdApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return Ok("Hello World from MyCiCdApp 🚀");
        }

    }
}
