using Newtonsoft.Json;

namespace BingNewsSearch.Models
{
    public class QueryContext
    {
        [JsonProperty("originalQuery")]
        public string OriginalQuery { get; set; }

        [JsonProperty("adultIntent")]
        public bool AdultIntent { get; set; }
    }
}
