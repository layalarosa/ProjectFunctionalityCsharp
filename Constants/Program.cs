using System;

namespace Constants
{
    public class Program
    {
        public static string OpenWeatherMapEndpoint = "https://api.openweathermap.org/data/2.5/weather";
        public static string OpenWeatherMapAPIKey = "6cfbec15314cf97fa5d556eccf500c54";


        RestService _restService;
        public Program()
        {
            //InitializeComponent();
            _restService = new RestService();
        }

        async void OnGetWeatherButtonClicked(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(_cityEntry.Text))
            //{
                WeatherData weatherData = await
                    _restService.
                    GetWeatherData(GenerateRequestURL(OpenWeatherMapEndpoint));

                //BindingContext = weatherData;
            //}
        }

        string GenerateRequestURL(string endPoint)
        {
            string requestUri = endPoint;
            
            requestUri += $"&APPID={OpenWeatherMapAPIKey}";
            return requestUri;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
