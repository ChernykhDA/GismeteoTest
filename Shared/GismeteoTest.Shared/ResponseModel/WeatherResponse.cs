using GismeteoTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GismeteoTest.Shared.ResponseModel
{
    public class WeatherResponse
    {
        public ErrorResponse Error { get; set; }

        public List<WeatherData> WeatherData { get; set; }
    }
}
