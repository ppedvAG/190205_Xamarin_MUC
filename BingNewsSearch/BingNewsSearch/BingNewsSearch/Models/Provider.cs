using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace BingNewsSearch.Models
{
    public class Provider
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
