//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStreamPro.Producer.Spotify.Infrastructure.Schema
//{
//    public class SimplePlaylist
//    {
//        [JsonProperty("collaborative")]
//        public bool Collaborative { get; set; }

//        [JsonProperty("external_urls")]
//        public Dictionary<string, string> ExternalUrls { get; set; }

//        [JsonProperty("href")]
//        public string Href { get; set; }

//        [JsonProperty("id")]
//        public string Id { get; set; }

//        [JsonProperty("images")]
//        public List<Image> Images { get; set; }

//        [JsonProperty("name")]
//        public string Name { get; set; }

//        [JsonProperty("owner")]
//        public PublicProfile Owner { get; set; }

//        [JsonProperty("public")]
//        public bool Public { get; set; }

//        [JsonProperty("snapshot_id")]
//        public string SnapshotId { get; set; }

//        [JsonProperty("tracks")]
//        public PlaylistTrackCollection Tracks { get; set; }

//        [JsonProperty("type")]
//        public string Type { get; set; }

//        [JsonProperty("uri")]
//        public string Uri { get; set; }
//    }
//}