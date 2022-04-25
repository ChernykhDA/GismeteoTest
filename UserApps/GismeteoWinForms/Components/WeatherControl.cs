using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GismeteoWinForms.Components
{
    public partial class WeatherControl : UserControl
    {
        private string _day { get; set; }

        private double? _maxTemp;

        private double? _minTemp;
        private double? _windSpeed { get; set; }
        private double? _precipitation { get; set; }

        public string Day 
        { 
            get => _day;
            
            set
            {
                if(value != default)
                    _day = value;
                SetDate();
            }
        }
        
        private void SetDate()
        {
            if(_day == null)
                DataLabel.Text = "Не определено";
            else
            {
                DataLabel.Text = (_day == null) ? "Не опр." : _day.ToString();
            }
        }

        public double? MaxTemperature 
        { 
            get => _maxTemp;
            set
            {
                _maxTemp = value;
                MaxTemp.Text = (value.ToString() == "") ? "-" : value.ToString() + " ℃";
            }
        }

        public double? MinTemperature 
        {
            get => _minTemp;
            set
            {
                _minTemp = value;
                MinTemp.Text = (value.ToString() == "") ? "-" : value.ToString() + " ℃";
            }
        }

        public double? WindSpeed 
        {
            get => _windSpeed;
            set
            {
                _windSpeed = value;
                WindSpeedLabel.Text = (value.ToString() == "") ? "- м/с" : value.ToString() + " м/c";
            }
        }

        public double? Precipitation 
        {
            get => _precipitation;
            set
            {
                _precipitation = value;
                PrecipitationLabel.Text = (value.ToString() == "") ? "- мм" : value.ToString() + " мм";
            }
        }

        public WeatherControl()
        {
            InitializeComponent();

            DataLabel.Text = "Не опр.";

        }
    }
}
