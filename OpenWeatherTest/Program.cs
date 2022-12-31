using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace OpenWeatherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // API Key: 6cfbec15314cf97fa5d556eccf500c54
            // Create an instance of the HttpClient Class called client
            var client = new HttpClient();

            // Ask for the users API Key and store that in a variable called "api_Key"
            Console.Write("Welcome to the Open Weather API!\nPlease input your API Key: ");
            var api_key = Console.ReadLine();

            // Ask the user for their city name and store that in a variable called "city_name"
            Console.Write("\nThank you.\n\nEnter the city name you wish to view the current weather forcast of: ");
            var city_name = Console.ReadLine().ToLower();

            // Create a variable to store the URL (use String Interpolation for the {city_name} and {api_Key}  HINT: Make sure to use the "imperial" measurement endpoint
            var userURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid={api_key}&units=imperial";

            // Create a variable to store the response from your GET request to that URL from above  HINT: Don't forget to call .Result 
            var weatherResponse = client.GetStringAsync(userURL).Result;

            // Create a variable to store the formattedResponse after you JObject.Parse() the response from above
            var formattedResponseMain = JObject.Parse(weatherResponse).GetValue("main").ToString();
            var formattedResponseTemp = JObject.Parse(formattedResponseMain).GetValue("temp").ToString();

            // Write out the current temperature in degrees Fahrenheit
            Console.WriteLine($"\n{formattedResponseTemp} degrees Fahrenheit.");
        }
    }
}
