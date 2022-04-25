using AngleSharp.Html.Parser;
using GismeteoTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismeteoTest
{
    public class City
    {
        public string Name { get; set; }
        
        public string Path { get; set; }
    }

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
                string html = await HTMLGetter.GetHtmlPageSite(GismeteoUrl);

                HtmlParser parser = new HtmlParser();

                var document = await parser.ParseDocumentAsync("https://www.gismeteo.ru" + html + "10-days/");

                var block = document.QuerySelectorAll(".widget-weather").FirstOrDefault();

                var date = block.GetElementsByClassName("widget-row");


                return null;
                
            }
            catch
            {
                return null;
            }
        }
    }
}
