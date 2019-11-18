using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Schema
{
    [ExcludeFromCodeCoverage]
    public sealed class AuthError
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}