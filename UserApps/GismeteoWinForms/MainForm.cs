using GismeteoTest.Shared.ResponseModel;
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

        public MainForm()
        {
            InitializeComponent();
        }

        private async Task GetCitiesInfo()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:5001/WeatherForecast/GetCities");
                if (response.IsSuccessStatusCode)
                {
                    citiesResponse = await response.Content.ReadAsAsync<CitiesResponse>();

                    if (citiesResponse.Cities != null)
                    {
                        FillCitites(citiesResponse.Cities);

                        //Берем информацию о городе
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
            catch (Exception)
            {
                FillErrorCities();
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
    }
}
