using GismeteoTest.Shared.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GismeteoTest.Database
{
    public class DbWorker
    {
        public string ConnectionString { get; set; }

        /// <summary>
        /// Клиент MongoDB
        /// </summary>
        private MongoClient client;

        /// <summary>
        /// Свойство с названием базы данных
        /// </summary>
        private string DbName = "GisMeteo";

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="conn"></param>
        public DbWorker(string conn = "mongodb://localhost:27017")
        {
            ConnectionString = conn;
            client = new MongoClient(ConnectionString);
        }

        /// <summary>
        /// Метод добавляет информацию о погоде
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task AddWeathersAsync(IEnumerable<WeatherData> data)
        {
            try
            {
                var database = client.GetDatabase(DbName);

                var collection = database.GetCollection<WeatherData>("Weathers");

                await collection.InsertManyAsync(data);
            }
            catch
            {
                throw new Exception("Возникла ошибка при добавлении информации о погоде");
            }
        }

        /// <summary>
        /// Метод добавляет информацию о погоде
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task AddWeatherAsync(WeatherData data)
        {
            try
            {
                var database = client.GetDatabase(DbName);

                var collection = database.GetCollection<WeatherData>("Weathers");

                await collection.InsertOneAsync(data);
            }
            catch
            {
                throw new Exception("Возникла ошибка при добавлении информации о погоде");
            }
        }

        /// <summary>
        /// Метод получения уникального списка городов
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<List<string>> GetCitiesAsync()
        {
            try
            {
                var database = client.GetDatabase(DbName);

                var cities = await database.GetCollection<WeatherData>("Weathers").Distinct<string>("City", "").ToListAsync();
                if(cities.Count == 0 || cities == null)
                    throw new Exception("Нет данных о городах");
                return cities;
            }
            catch
            {
                throw new Exception("Возникла ошибка при выборке города из базы данных");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public async Task<List<WeatherData>> GetWeatherByCity(string city)
        {
            try
            {
                var database = client.GetDatabase(DbName);

                var filter = Builders<WeatherData>.Filter.Eq("City", city);

                var weather = (await database.GetCollection<WeatherData>("Weathers")
                    .FindAsync(filter).Result
                    .FirstOrDefaultAsync());

                if (weather == null)
                    throw new Exception("Не данны о погоде в городе");

                return null;
            }
            catch
            {
                throw new Exception("Возникла ошибка при выборке города из базы данных");
            }
        }
    }
}
