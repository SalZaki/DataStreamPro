namespace DataStreamPro.Producer.Spotify.Domain.Interfaces
{
    public interface IIdentityWithId<TId>
    {
        TId Id { get; }
    }
}
