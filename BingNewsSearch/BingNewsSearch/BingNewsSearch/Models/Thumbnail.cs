using Newtonsoft.Json;
using System;

namespace BingNewsSearch.Models
{
    public class Thumbnail
    {
        [JsonProperty("contentUrl")]
        public Uri ContentUrl { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }
}
