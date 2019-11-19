namespace DataStreamPro.Producer.Spotify.Infrastructure.Settings
{
    public interface ISpotifyWebApiSettings
    {
        string AuthUrl { get; set; }

        string BaseUrl { get; set; }

        string ClientId { get; set; }

        string ClientSecret { get; set; }

        string ApiDocumentationUrl { get; set; }
    }
}