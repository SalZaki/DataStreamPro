namespace DataStreamPro.Producer.Spotify.Domain.Interfaces
{
    public interface IIdentity<TId>
    {
        TId Id { get; }
    }
}