using Newtonsoft.Json;

namespace DataStreamPro.Producer.Spotify.Application.Models
{
    public class Followers
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
