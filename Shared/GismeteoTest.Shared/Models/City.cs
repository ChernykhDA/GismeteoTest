using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GismeteoTest.Shared.Models
{
    public class City
    {
        [JsonIgnore]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }
    }
}
