using Microsoft.AspNetCore.Mvc;
using Notifications.Application.Models;
using Notifications.Application.Services;

namespace Notifications.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<IEnumerable<WeatherForecast>> Get()
    {
        return Ok(_weatherForecastService.GetForecasts());
    }
}
