using Deltatre.Interview.WebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace Deltatre.Interview.WebApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class EarthWeatherForecastController : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var forecastService = new EarthWeatherForecastService();
        return forecastService.GetForecast();
    }
}