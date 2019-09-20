using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebAPIClient
{
     // First version makes a web request to read the list of all repositories return wt a string
    class Program
    {
        // First need object to retrieve data using http client for request/ responses
        private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            // Use the Wait method to block and wait for the task to finish
            ProcessRepositories().Wait();
        }

        // Use of method to process to  list all repositories under the dotnet org
        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            // Easy return wt a string
            var msg = await stringTask;
            Console.Write(msg);
        }
    }
}
