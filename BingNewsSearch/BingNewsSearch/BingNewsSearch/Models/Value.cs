using Newtonsoft.Json;
using System;

namespace BingNewsSearch.Models
{
    public class Article
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("provider")]
        public Provider[] Provider { get; set; }

        [JsonProperty("datePublished")]
        public DateTimeOffset DatePublished { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }
    }
}
