using Newtonsoft.Json;
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

namespace WeatherApp
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        // Declaring variables
        Settings settings = new Settings();
        WeatherApiResponse weather = new WeatherApiResponse();
        string apiKey = "9ccbc1d53d964754a0c110925212510";

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        // async is needed in order to work properly
        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("Error please enter country");
                return;
            }

            string apiURL = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={searchTextBox.Text}&aqi=no";

            weather = await GetWeatherData(apiURL);

            showResult();
        }

        // Sending request to get result from API
        public static async Task<WeatherApiResponse> GetWeatherData(string URL)
        {
            using (var httpClient = new HttpClient())
            {
                var url = URL;
                var response = await httpClient.GetAsync(url);
                var contentString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<WeatherApiResponse>(contentString);
            }
        }

        void showResult()
        {
            locationLabel.Text = $"{ weather.location.name} ({weather.location.region}), {weather.location.country}";
            localTimeLabel.Text = weather.location.localtime;
            temperatureLabel.Text = $"{weather.current.temp_c} C ({weather.current.condition.text})";
            iconPictureBox.ImageLocation = $"http:{weather.current.condition.icon}";

            locationLabel.Visible = true;
            localTimeLabel.Visible = true;
            temperatureLabel.Visible = true;
        }
        /*
       public static async Task<Weather> GetWeatherData()
       {
           using (var httpClient = new HttpClient())
           {
               var url = "https://api.weatherapi.com/vX/current.json?key=9ccbc1d53d964754a0c110925212510&q=Nicosia&aqi=no";
               var response = await httpClient.GetAsync(url);
               var contentString = await response.Content.ReadAsStringAsync();

               if (false == response.IsSuccessStatusCode)
                   MessageBox.Show($"Error: StatusCode: { response.StatusCode}");
               else
               {
                   var contentString = await response.Content.ReadAsStringAsync();

                   MessageBox.Show($"Success: {contentString}");
               }
               return JsonConvert.DeserializeObject<Weather>(contentString);
           }
       }*/
    }
}
