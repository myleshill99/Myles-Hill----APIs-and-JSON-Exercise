namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            var api = new RonVSKanyeAPI();

            for (var i = 0; i < 5; i++)
            {
                api.GetKanyeQuote();
                api.GetRonSwansonQuote();
            }

            var weatherApi = new OpenWeatherMapAPI();
            weatherApi.ShowWeatherData("Birmingham");

            Console.ReadLine();
        }
    }
}
