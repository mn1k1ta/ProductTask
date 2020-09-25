using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class HttpService
    {
        public static HttpClient CreateHttpClient()
        {
            return new HttpClient();
        }

        public static async Task<T> HttpGetAsync<T>(string path)
        {
            using var httpClient = CreateHttpClient();
            var response = await httpClient.GetAsync(path);
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseContent);
        }
    }
}
