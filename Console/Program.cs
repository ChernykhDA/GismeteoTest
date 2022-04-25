using GismeteoTest.Database;
using GismeteoTest.Shared.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;

namespace GismeteoTest
{
    internal class Program
    {
        private static Timer Timer;

        private static void SetTimer()
        {
            //Раз в час
            Timer = new Timer(3000); 
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private static async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Timer.Enabled = false;
            GismeteoGrabber grab = new GismeteoGrabber();
            List<City> cities = (List<City>)await grab.CitiesGrab();
            foreach(var city in cities)
            {
                var cityInfo = await grab.GetCityInfo(city);
                WeatherData data = new WeatherData()
                {
                    City = city.Name,
                    UpdateTime = DateTime.Now,
                    Weathers = cityInfo
                };
                
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
            //string a = await HTMLGetter.GetHtmlPageSite("https://www.gismeteo.ru/");

            //MongoDbWorker dbWorker = new MongoDbWorker();

            //await dbWorker.GetDatabaseNames();

            /*WeatherType type = new WeatherType()
            {
                Description = "Переменная облачность"
            };

            WeatherData data = new WeatherData()
            {
                WeatherTypeId = new MongoDB.Driver.MongoDBRef("WeatherTypes", new ObjectId("62624678bb1498ea6ad25d92")),
                MaxTemp = 2,
                MinTemp = 4
            };*/

            //await dbWorker.AddWeatherType(type);
            //await dbWorker.AddWeather(data);
            //Console.WriteLine("Hello World!");
        }
    }
}
