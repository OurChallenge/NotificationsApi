using Notifications.Application.Models;

namespace Notifications.Application.Services;

public interface IWeatherForecastService
{
    IReadOnlyList<WeatherForecast> GetForecasts();
}
