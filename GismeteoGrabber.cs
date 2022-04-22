using System;
using System.Collections.Generic;
using System.Text;

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
        public IEnumerable<string> CitiesGrab()
        {
            return null;
        }

    }
}
