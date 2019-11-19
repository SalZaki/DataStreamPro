using System;
using System.Collections.Generic;

namespace DataStreamPro.Producer.Spotify.Domain.Interfaces
{
    public interface IAggregateRoot<TId> : IEntity<TId>
    {
        IAggregateRoot<TId> ApplyEvent(IEvent @event);

        List<IEvent> GetUncommittedEvents();

        void ClearUncommittedEvents();

        IAggregateRoot<TId> RemoveEvent(IEvent @event);

        IAggregateRoot<TId> AddEvent(IEvent @event);

        IAggregateRoot<TId> RegisterHandler<T>(Action<T> handler);
    }

    public interface IAggregateRoot : IAggregateRootWithId<Guid>
    {

    }
}