namespace DataStreamPro.Producer.Spotify.Application.Interfaces
{
    public interface ISpotifyService
    {
        ISpotifyWebApiClient SpotifyWebApiClient { get; }
    }
}