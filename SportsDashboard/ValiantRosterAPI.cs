using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace SportsDashboard
{
    public class ValiantRosterAPI
    {
        //Create HttpClient
        private static readonly HttpClient client = new HttpClient();

        static async Task<ValiantRosterAPIProperties> RunAsync()
        {
            ValiantRosterAPIProperties valiant = null;

            //Initialize HttpClient
            client.BaseAddress = new Uri("https://api.overwatchleague.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Sending a GET request
            HttpResponseMessage response = await client.GetAsync("team/4405");

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();

                valiant = JsonConvert.DeserializeObject<ValiantRosterAPIProperties>(data);
            }
            else
            {
                Console.WriteLine("Internal Server Error");
            }
            return valiant;
        }
    }
}
