using Deltatre.Interview.WebApplication.Respositories;

namespace Deltatre.Interview.WebApplication.Services;

public class EarthWeatherForecastService : IEarthWeatherForecastService
{
    public IEnumerable<WeatherForecast> GetForecast()
    {
        var randomForecastData = WeatherForecastRepository.GetForecast();

        foreach (var weatherForecast in randomForecastData)
        {
            if (weatherForecast.TemperatureC is > -21 and <= -10)
                weatherForecast.Summary = "Freezing";
            else if (weatherForecast.TemperatureC is > -10 and <= 1)
                weatherForecast.Summary = "Cold";
            else if (weatherForecast.TemperatureC is > 1 and <= 10)
                weatherForecast.Summary = "Chilly";
            else if (weatherForecast.TemperatureC is > 10 and <= 15)
                weatherForecast.Summary = "Mild";
            else if (weatherForecast.TemperatureC is > 15 and <= 19)
                weatherForecast.Summary = "Warm";
            else if (weatherForecast.TemperatureC is > 19 and <= 25)
                weatherForecast.Summary = "Balmy";
            else if (weatherForecast.TemperatureC is > 25 and <= 31)
                weatherForecast.Summary = "Hot";
            else if (weatherForecast.TemperatureC is > 31 and <= 41)
                weatherForecast.Summary = "Sweltering";
            else if (weatherForecast.TemperatureC is > 41 and <= 55)
                weatherForecast.Summary = "Scorching";
            else
                weatherForecast.Summary = "Unknown";
        }

        return randomForecastData;
    }
}