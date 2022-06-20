using Deltatre.Interview.WebApplication.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Deltatre.Interview.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IEarthWeatherForecastService, EarthWeatherForecastService>();
            return services;
        }
    }
}