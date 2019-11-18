using Newtonsoft.Json;

namespace DataStreamPro.Producer.Spotify.Application.Models
{
    public class PlaylistTrackCollection
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
