using BingNewsSearch.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BingNewsSearch.Services
{
    class NewsService
    {
        const string api_key = "665464616b0e498daf4cd39acfe3a701";
        public async Task<SearchResult> GetNewsAsync(string keywords)
        {
            string json;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", api_key);
                string uri = $"https://api.cognitive.microsoft.com/bing/v7.0/news/search?q={keywords}";

                json = await client.GetStringAsync(uri);
            }
            return JsonConvert.DeserializeObject<SearchResult>(json);
        }
    }
}
