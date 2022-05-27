using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAp.Grafica.Models;


using System.Text.Json;
using WebApplication1.Model;

namespace WebAp.Grafica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _client;

        public Stream Message { get; private set; }

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory client)
        {
            _logger = logger;
            _client = client;
        }

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    var client = _client.CreateClient("CinemaApi");
        //    Message = await client.GetStreamAsync("GetById/SalaCinematografiche");
        //    var M = JsonSerializer.Deserialize<IEnumerable<SalaCinematografica>>(Message);
        //    return View(M);
        //}


        [HttpGet]
        public async Task<IActionResult>  index()
        {
            var client = _client.CreateClient("CinemaApi");
            Message = await client.GetStreamAsync("Films");
            var M = JsonSerializer.Deserialize<IEnumerable<Film>>(Message);
            return View(M);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}