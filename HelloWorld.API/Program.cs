using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;


namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task<string> GetHelloWorld(Uri strUrl)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync("http://localhost:58168/api/HelloWorld/GetHelloWorld"); //uri
            }
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:58168/api/HelloWorld/GetHelloWorld");
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string msg = "";

                msg = await GetHelloWorld(client.BaseAddress);


                Console.WriteLine("Updating price..." + msg);
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
