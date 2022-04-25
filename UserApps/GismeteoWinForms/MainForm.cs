using GismeteoTest.Shared.ResponseModel;
using GismeteoWinForms.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GismeteoWinForms
{
    public partial class MainForm : Form
    {
        static HttpClient client = new HttpClient();

        private CitiesResponse citiesResponse;

        private WeatherResponse currentWeatherData;

        public MainForm()
        {
            InitializeComponent();
        }

        private async Task GetCitiesInfo()
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    using(HttpResponseMessage response = await client.GetAsync("https://localhost:5001/WeatherForecast/GetCities"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            citiesResponse = await response.Content.ReadAsAsync<CitiesResponse>();

                            if (citiesResponse.Cities != null)
                            {
                                FillCitites(citiesResponse.Cities);

                                //Берем информацию о городе
                                UriBuilder builder = new UriBuilder("https://localhost:5001/WeatherForecast/GetWeatherCity");
                                builder.Query = $"city={ cityBox.SelectedItem }";
                                using (HttpResponseMessage response_ = await client.GetAsync(builder.Uri))
                                {
                                    if (response_.IsSuccessStatusCode)
                                    {
                                        currentWeatherData = await response_.Content.ReadAsAsync<WeatherResponse>();
                                        if (currentWeatherData.WeatherData != null)
                                        {
                                            FillWeather();
                                        }
                                        else
                                        {
                                            FillErrorWeather();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                FillErrorCities();
            }
        }

        private void FillWeather()
        {
            UpdateTime.Text = currentWeatherData.WeatherData.UpdateTime.ToString();
            int i = 1;
            foreach(var el in currentWeatherData.WeatherData.Weathers)
            {
                WeatherControl wc = (this.panel1.Controls["weatherControl" + i.ToString()] as WeatherControl);
                wc.MinTemperature = el.MinTemp;
                wc.MaxTemperature = el.MaxTemp;
                wc.WindSpeed = el.MaxWindSpeed;
                wc.Precipitation = el.Precipitation;
                wc.Day = el.DateString;
                i++;
            }
        }

        private void FillErrorWeather()
        {
            for(int i = 1; i <= 10; i++)
            {
                WeatherControl wc = (this.panel1.Controls["weatherControl" + i.ToString()] as WeatherControl);
                wc.MinTemperature = null;
                wc.MaxTemperature = null;
                wc.WindSpeed = null;
                wc.Precipitation = null;
                wc.Day = null;
            }
        }


        private void FillErrorCities()
        {
            cityBox.Items.Clear();
            cityBox.Items.Add("Нет данных");
            cityBox.Enabled = false;
            cityBox.SelectedItem = cityBox.Items[0];
            UpdateTime.Text = "Ошибка!";
        }

        private void FillCitites(List<string> cities)
        {
            cityBox.Enabled = true;
            cities.OrderBy(x => x);
            cityBox.Items.Clear();
            foreach(var el in cities)
            {
                cityBox.Items.Add(el);
            }
            cityBox.SelectedItem = cityBox.Items[0];
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            await GetCitiesInfo();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await GetCitiesInfo();
        }

        private async void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                //Берем информацию о городе
                UriBuilder builder = new UriBuilder("https://localhost:5001/WeatherForecast/GetWeatherCity");
                builder.Query = $"city={ cityBox.SelectedItem }";
                using (HttpResponseMessage response_ = await client.GetAsync(builder.Uri))
                {
                    if (response_.IsSuccessStatusCode)
                    {
                        currentWeatherData = await response_.Content.ReadAsAsync<WeatherResponse>();

                        if (currentWeatherData.WeatherData != null)
                        {
                            FillWeather();
                        }
                        else
                        {
                            FillErrorWeather();
                        }
                    }
                }
            }
        }
    }
}
