using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.SQL;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route(template: "Cinema")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDataProvider _dataProvider;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDataProvider dataProvider)
        {
            _logger = logger;
            _dataProvider = dataProvider;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPut(template: "Add/Spettaore")]
        public void Add(Spettatore spettatore)
        {
            
                    _dataProvider.Add(spettatore);
         }

        [HttpGet(template: "GetById/SalaCinematografiche")]
        public IEnumerable<SalaCinematografica> SaleCinematograficheByIdCinema(int Id)
        {
            return _dataProvider.SaleCinematograficheByIdCinema(Id);
        }


    }
}   