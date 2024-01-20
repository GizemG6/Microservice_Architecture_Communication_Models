using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient httpClient = new();
        HttpResponseMessage response = await httpClient.GetAsync("https://localhost:7130/api/values");

        if (response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
    }
}