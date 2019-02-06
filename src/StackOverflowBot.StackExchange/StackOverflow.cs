using Newtonsoft.Json;
using StackOverflowBot.StackExchange.Converters;
using StackOverflowBot.StackExchange.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace StackOverflowBot.StackExchange
{
    public class StackOverflow
    {
        private readonly static HttpClientHandler _httpClientHandler =
            new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip };

        private readonly static HttpClient _httpClient =
            new HttpClient(_httpClientHandler) { BaseAddress = new Uri("https://api.stackexchange.com/2.2/") };

        public async Task<SearchResponse> SearchAsync(SearchOptions searchOptions)
        {
            var content = HttpContentConverter.GetHttpContent(searchOptions);
            string urlParameters = await content.ReadAsStringAsync();

            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"search?{urlParameters}"))
            {
                var response = await _httpClient.SendAsync(requestMessage);
                string responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<SearchResponse>(responseString);
            }
        }
    }
}