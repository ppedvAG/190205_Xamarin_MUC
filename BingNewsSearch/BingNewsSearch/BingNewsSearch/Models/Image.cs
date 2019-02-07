using Newtonsoft.Json;

namespace BingNewsSearch.Models
{
    public class Image
    {
        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }
}
