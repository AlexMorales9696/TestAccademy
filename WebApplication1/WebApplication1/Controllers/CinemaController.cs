using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.SQL;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route(template: "Cinema")]
    public class CinemaController : ControllerBase
    {
        

        private readonly ILogger<CinemaController> _logger;
        private readonly IDataProvider _dataProvider;

        public CinemaController(ILogger<CinemaController> logger, IDataProvider dataProvider)
        {
            _logger = logger;
            _dataProvider = dataProvider;
        }

        [HttpGet(Name = "GetWeatherForecast")]
       

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
        [HttpGet(template: "Films")]
        public IEnumerable<Film> GetFilms()
        {
            return _dataProvider.GetFilms();
        }

    }
}   