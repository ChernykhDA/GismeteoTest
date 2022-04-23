using GismeteoTest.Database;
using GismeteoTest.Shared.Models;
using MongoDB.Bson;
using System;
using System.Threading.Tasks;

namespace GismeteoTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //string a = await Test.GetHtmlPageSite("https://www.gismeteo.ru/");

            MongoDbWorker dbWorker = new MongoDbWorker();

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
