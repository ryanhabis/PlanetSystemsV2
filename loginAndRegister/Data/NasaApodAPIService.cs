using Microsoft.CodeAnalysis.CSharp.Syntax;
using starSystemV2.Models;

namespace starSystemV2.Data
{
    public class NasaApodAPIService
    {
        public readonly HttpClient _HttpClient;
        private readonly string _apiKey = "Ax5bhqGAapzLl7HPIXuUfQlCSNUQHe7FNoUa5uhR";

        public NasaApodAPIService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task<NasaApod> GetApodAsync()
        {
            string url = $"https://api.nasa.gov/planetary/apod?api_key={_apiKey}";
            var response = await _HttpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<NasaApod>(content);
            }
            return null;

        }
    }
}