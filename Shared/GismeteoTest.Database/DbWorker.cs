using GismeteoTest.Shared.Models;
using MongoDB.Bson;
using System.Linq;
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
        /// Метод добавляет список городов
        /// </summary>
        /// <param name="cities"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task AddCities(List<City> cities)
        {
            try
            {
                var database = client.GetDatabase(DbName);

                var collection = database.GetCollection<City>("Cities");

                await collection.DeleteManyAsync(Builders<City>.Filter.Empty);

                await collection.InsertManyAsync(cities);
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

                var collection = (await database.GetCollection<City>("Cities")
                    .FindAsync(_ => true)).ToList()
                    .Select(x => x.Name).ToList();

                return collection;
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
        public async Task<WeatherData> GetWeatherByCity(string city)
        {
            try
            {
                var database = client.GetDatabase(DbName);

                var filter = Builders<WeatherData>.Filter.Eq("City", city);

                var collection = (await database.GetCollection<WeatherData>("Weathers").FindAsync(filter))
                    .ToList().OrderByDescending(x => x.UpdateTime).First();

                if (collection == null)
                    throw new Exception("Не данны о погоде в городе");

                return collection;
            }
            catch
            {
                throw new Exception("Возникла ошибка при выборке города из базы данных");
            }
        }
    }
}
