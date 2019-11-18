namespace DataStreamPro.Producer.Spotify.Application.Models
{
    public sealed class GetPlaylistsResponse
    {
        public Paging<PlayList> Result { get; set; }
    }
}