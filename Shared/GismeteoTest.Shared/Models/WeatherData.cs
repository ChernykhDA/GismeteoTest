﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace GismeteoTest.Shared.Models
{
    public class Weather
    {
        public string WeatherType { get; set; }

        public double MaxTemp { get; set; }

        public double MinTemp { get; set; }

        public DateTime Day { get; set; }

        public double MaxWindSpeed { get; set; }

        public double Precipitation { get; set; }
    }

    public class WeatherData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string City { get; set; }

        public DateTime UpdateTime { get; set; }

        public List<Weather> Weathers { get; set; }
    }
}