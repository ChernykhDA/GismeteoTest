using GismeteoTest.Database;
using GismeteoTest.Shared.Models;
using GismeteoTest.Shared.ResponseModel;
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
        [Route("GetWeatherCity")]
        public async Task<WeatherResponse> GetWeatherCity(string city)
        {
            try
            {
                DbWorker db = new DbWorker();

                var data = await db.GetWeatherByCity(city);

                if (data == null || data.Count == 0)
                {
                    return new WeatherResponse()
                    {
                        Error = new ErrorResponse()
                        {
                            ErrorCode = 2,
                            Message = $"Нет данных о погоде в городе { city }"
                        },
                        WeatherData = null
                    };
                }
                return new WeatherResponse()
                {
                    WeatherData = data,
                    Error = null
                };
            }
            catch
            {
                return new WeatherResponse()
                {
                    Error = new ErrorResponse()
                    {
                        ErrorCode = 1,
                        Message = "Возникла ошибка при получении погоды в городе"
                    },
                    WeatherData = null
                };
            }
        }

        /// <summary>
        /// Метод возращающий список городов
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCities")]
        public async Task<CitiesResponse> GetCities()
        {
            try
            {
                DbWorker db = new DbWorker();

                var data = await db.GetCitiesAsync();

                if (data == null || data.Count == 0)
                {
                    return new CitiesResponse()
                    {
                        Error = new ErrorResponse()
                        {
                            ErrorCode = 4,
                            Message = $"Нет данных о городах"
                        },
                        Cities = data
                    };
                }
                return new CitiesResponse()
                {
                    Cities = data,
                    Error = null
                };
            }
            catch
            {
                return new CitiesResponse()
                {
                    Error = new ErrorResponse()
                    {
                        ErrorCode = 3,
                        Message = "Возникла ошибка при получении списка городов"
                    },
                    Cities = null
                };
            }
        }
    }
}
