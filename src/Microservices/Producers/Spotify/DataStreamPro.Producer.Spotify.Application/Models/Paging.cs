using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataStreamPro.Producer.Spotify.Application.Models
{
    public class Paging<T> : BaseModel
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        public bool HasNextPage()
        {
            return Next != null;
        }

        public bool HasPreviousPage()
        {
            return Next != null;
        }
    }
}