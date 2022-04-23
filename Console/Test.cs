using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GismeteoTest
{
    public static class Test
    {
        public static async Task<string> GetHtmlPageSite(string url)
        {
            try
            {
                string result = null;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                HttpWebResponse response = (HttpWebResponse)(await request.GetResponseAsync());

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        result = new StreamReader(responseStream).ReadToEnd();
                    }
                }
                else
                {
                    throw new Exception($"Не успешный статус страницы: { response.StatusCode }");
                }
                return result;
            }
            catch
            {
                throw new Exception("Возникла ошибка при получении страницы с сайта.");
            }
        }
    }
}
