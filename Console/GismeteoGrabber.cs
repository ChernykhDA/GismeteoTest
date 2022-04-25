using AngleSharp.Html.Parser;
using GismeteoTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismeteoTest
{
    internal class GismeteoGrabber
    {
        /// <summary>
        /// Строка с адресом на сайт Гисметео
        /// </summary>
        public const string GismeteoUrl = "https://www.gismeteo.ru/";

        /// <summary>
        /// Метод, который берет из блока "Популярные города России" список городов
        /// </summary>
        /// <returns>Коллекция url ссылок для каждого города на сайте</returns>
        public async Task<IEnumerable<City>> CitiesGrab()
        {
            try
            {
                List<City> result = new List<City>();

                string html = await HTMLGetter.GetHtmlPageSite(GismeteoUrl);

                HtmlParser parser = new HtmlParser();

                var document = await parser.ParseDocumentAsync(html);

                var blocks = document
                    .GetElementsByClassName("cities-popular")[0]
                    .GetElementsByClassName("list-item");

                foreach (var block in blocks)
                {
                    var element = block.QuerySelectorAll("a");
                    var href = element[0].Attributes["href"].Value;
                    var cityName = block.TextContent;
                    result.Add(new City()
                    {
                        Name = cityName,
                        Path = href
                    });
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Weather>> GetCityInfo(City city)
        {
            try
            {
                List<Weather> result = new List<Weather>();

                string html = await HTMLGetter.GetHtmlPageSite("https://www.gismeteo.ru" + city.Path + "10-days/");

                HtmlParser parser = new HtmlParser();

                var document = await parser.ParseDocumentAsync(html);

                var block = document.GetElementsByClassName("widget widget-weather widget-days")[0]
                    .GetElementsByClassName("widget-row widget-row-days-date")[0]
                    .GetElementsByClassName("date");

                var dateList = new List<string>();
                foreach(var el in block)
                    dateList.Add(el.TextContent);

                var maxList = new List<double>();
                var minList = new List<double>();
                block = document.GetElementsByClassName("widget-row-chart widget-row-chart-temperature")[0]
                    .GetElementsByClassName("unit_temperature_c");

                for(int i = 0; i < block.Length; i+=2)
                {
                    maxList.Add(Convert.ToDouble(block[i].TextContent));
                    minList.Add(Convert.ToDouble(block[i + 1].TextContent.Replace('−', '-')));
                }

                block = document.GetElementsByClassName("widget-row widget-row-wind-gust row-with-caption")[0]
                    .GetElementsByClassName("row-item");

                var windList = new List<double>();
                foreach(var el in block)
                {
                    windList.Add(Convert.ToDouble(el.TextContent.Split(" ").First()));
                }

                block = document.GetElementsByClassName("widget-row widget-row-precipitation-bars row-with-caption")[0]
                    .GetElementsByClassName("row-item");

                var precList = new List<double>();
                foreach (var el in block)
                {
                    precList.Add(Convert.ToDouble(el.TextContent));
                }

                //Наконец собираем нужные данные
                for(int i = 0; i < 10;i++)
                {
                    result.Add(new Weather()
                    {
                        DateString = dateList[i],
                        MaxTemp = maxList[i],
                        MinTemp = minList[i],
                        MaxWindSpeed = windList[i],
                        Precipitation = precList[i]
                    });
                }

                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
