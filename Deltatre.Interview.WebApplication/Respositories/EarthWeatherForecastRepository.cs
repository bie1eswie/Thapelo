namespace Deltatre.Interview.WebApplication.Respositories;

/// <summary>
/// This class cannot be modified!
/// </summary>
public static class WeatherForecastRepository
{
    public static WeatherForecast[] GetForecast()
    {
        var rng = new Random();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
            })
            .ToArray();
    }
}