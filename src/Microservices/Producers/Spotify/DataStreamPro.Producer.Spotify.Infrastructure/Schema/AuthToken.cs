using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Schema
{
    [ExcludeFromCodeCoverage]
    public sealed class AuthToken
    {
        public AuthToken()
        {
            CreatedOn = DateTime.Now;
        }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public double ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsExpired()
        {
            return CreatedOn.Add(TimeSpan.FromSeconds(ExpiresIn)) <= DateTime.Now;
        }

        public bool HasError()
        {
            return Error != null;
        }
    }
}