using GismeteoTest.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GismeteoService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Метод возращающий информацию о погоде в городе
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpGet]
        public WeatherData GetWeatherCity(string city)
        {
            
        }

        /// <summary>
        /// Метод возращающий список городов
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<string> GetCities()
        {

        }
    }
}
