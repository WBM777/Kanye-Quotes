using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.kanye.rest";

            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;

            string quote = JObject.Parse(response).GetValue("quote").ToString();
            Console.WriteLine(quote);
        }
       // static void Main()
       // {
            //string url = "https://api.chucknorris.io/jokes/random";

           // HttpClient client = new HttpClient();
           // string response = client.GetStringAsync(url).Result;

           // string joke2 = JObject.Parse(response).GetValue("value").ToString();
       // }   
    }
}
