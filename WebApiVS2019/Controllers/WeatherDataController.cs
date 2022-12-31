using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApiVS2019.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherDataController : Controller
    {
        string url = @"https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid=6cfbec15314cf97fa5d556eccf500c54";
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
