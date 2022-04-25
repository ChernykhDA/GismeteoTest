using GismeteoTest.Database;
using GismeteoTest.Shared.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace GismeteoTest
{
    internal class Program
    {
        private static Timer Timer;

        private static void SetTimer()
        {
            //Раз в 30 секунд
            Timer = new Timer(30000); 
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private static async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Timer.Enabled = false;
            DbWorker dbWorker = new DbWorker();
            GismeteoGrabber grab = new GismeteoGrabber();

            List<City> cities = (List<City>)await grab.CitiesGrab();
            await dbWorker.AddCities(cities);

            foreach (var city in cities)
            {
                var cityInfo = await grab.GetCityInfo(city);
                
                if(cityInfo != null)
                {
                    WeatherData data = new WeatherData()
                    {
                        City = city.Name,
                        UpdateTime = DateTime.Now,
                        Weathers = cityInfo
                    };
                    await dbWorker.AddWeatherAsync(data);
                }
            }
            Timer.Enabled = true;
        }

        static async Task Main(string[] args)
        {
            SetTimer();
            OnTimedEvent(null, null);
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
