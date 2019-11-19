using System;

namespace DataStreamPro.Producer.Spotify.Domain.Interfaces
{
    public interface IEvent
    {
        Guid Id { get; }

        int EventVersion { get; }

        DateTime OccurredOn { get; }
    }
}