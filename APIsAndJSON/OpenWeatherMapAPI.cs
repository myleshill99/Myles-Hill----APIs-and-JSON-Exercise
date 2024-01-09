using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public void ShowWeatherData (string city)
        {
            var apiKey = "d05911806e1ddeb6c83871d300160534";
            var client = new HttpClient();
            var weatherApiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=imperial"; 

            var weatherResponse = client.GetStringAsync(weatherApiUrl).Result;
            var jsonObject = JObject.Parse(weatherResponse);


            Console.WriteLine(JObject.Parse(weatherResponse));
            var temp = jsonObject["main"]["temp"];
            
            Console.WriteLine("");
            Console.WriteLine($"and the temp for your area is {temp} degrees F");
        }
    }
}
