using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public void GetKanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine(kanyeQuote);
        }

        public void GetRonSwansonQuote()
        {
            var client = new HttpClient();
            var ronSwansonUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronSwansonResponse = client.GetStringAsync(ronSwansonUrl).Result;
            var ronSwansonQuote = JArray.Parse(ronSwansonResponse);

            Console.WriteLine(ronSwansonQuote[0]);
        }
    }
}
