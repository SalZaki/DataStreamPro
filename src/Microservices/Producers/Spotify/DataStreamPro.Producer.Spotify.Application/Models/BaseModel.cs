using Newtonsoft.Json;

namespace DataStreamPro.Producer.Spotify.Application.Models
{
    public abstract class BaseModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

    }
}