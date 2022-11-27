﻿using CornerShop.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace CornerShop.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private IConsoleWriter _IConsoleWriter;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IConsoleWriter? prIConsoleWriter)
    {
        _logger = logger;
        _IConsoleWriter = prIConsoleWriter;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        //Dependency Injection
        _IConsoleWriter.Write();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

