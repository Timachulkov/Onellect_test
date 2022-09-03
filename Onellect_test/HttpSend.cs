using System.Net.Http.Headers;
using System.Configuration;

namespace Onellect_test
{

    internal class HttpSend
    {
        DataObject obj;
        internal HttpSend(DataObject obj)
        {
            this.obj = obj;
        }
        static HttpClient client = new HttpClient();
        async Task<Uri> CreateProductAsync(DataObject dataObject)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/DataObject", dataObject);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        internal void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings.Get("RestApiServerAdress"));
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                // Create a new dataObject

                var url = await CreateProductAsync(obj);
                Console.WriteLine($"Created at {url}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
