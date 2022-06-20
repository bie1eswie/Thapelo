using Deltatre.Interview.WebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace Deltatre.Interview.WebApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class EarthWeatherForecastController : ControllerBase
{
    private readonly IEarthWeatherForecastService _forecastService;
    private readonly ILogger<EarthWeatherForecastController> _logger;

    public EarthWeatherForecastController(IEarthWeatherForecastService earthWeatherForecastService, ILogger<EarthWeatherForecastController> logger)
    {
        _forecastService = earthWeatherForecastService;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<IEnumerable<WeatherForecast>> Get()
    {
        try
        {
            return Ok(_forecastService.GetForecast());
        }
        catch (Exception ex)
        {
            _logger.LogError(exception: ex,ex.Message);
            return BadRequest();
        }
    }
}