using CornerShop.DependencyInjection;
using CornerShop.Model.Entities;
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
    private IProductService _IProductService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IConsoleWriter? prIConsoleWriter, IProductService prIProductService)
    {
        _logger = logger;
        _IConsoleWriter = prIConsoleWriter;
        _IProductService = prIProductService;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        //Dependency Injection

        //List<Product> IProducts = _IProductService.GetAll();
        //List<Product> IProducts = _IProductService.GetByName("Milk");

        //_IConsoleWriter.Write();

        //Add Product
        Product INewProduct = new Product() { Name = "Bread" };
        IProductService.Save(INewProduct);
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    } 
}

