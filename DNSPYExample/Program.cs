using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DNSPYExample
{
    class Program
    {
        private const string PAGE_URL = "https://programowanienaostro.pl";

        private const string MESSAGE = "Press any key to download page content";

        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            Console.WriteLine(MESSAGE);

            Console.ReadKey();

            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(PAGE_URL);

            string content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(content);

            Console.ReadKey();
        }
    }
}
