
namespace Deltatre.Interview.WebApplication.Services
{
    public interface IEarthWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetForecast();
    }
}