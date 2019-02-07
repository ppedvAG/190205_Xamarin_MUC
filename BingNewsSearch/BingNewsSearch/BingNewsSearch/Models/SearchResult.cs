using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BingNewsSearch.Models
{
    public class SearchResult
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("readLink")]
        public Uri ReadLink { get; set; }

        [JsonProperty("queryContext")]
        public QueryContext QueryContext { get; set; }

        [JsonProperty("totalEstimatedMatches")]
        public long TotalEstimatedMatches { get; set; }

        [JsonProperty("sort")]
        public Sort[] Sort { get; set; }

        [JsonProperty("value")]
        public List<Article> Articles { get; set; }
    }
}
