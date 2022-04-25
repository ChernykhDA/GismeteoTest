using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GismeteoTest.Shared.Models
{
    public class Weather
    {
        public double MaxTemp { get; set; }

        public double MinTemp { get; set; }

        public string DateString { get; set; }

        public double MaxWindSpeed { get; set; }

        public double Precipitation { get; set; }
    }

    public class WeatherData
    {
        [JsonIgnore]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string City { get; set; }

        public DateTime UpdateTime { get; set; }

        public List<Weather> Weathers { get; set; }
    }
}
