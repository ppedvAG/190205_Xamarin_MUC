using Newtonsoft.Json;
using System;

namespace BingNewsSearch.Models
{
    public class Sort
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
