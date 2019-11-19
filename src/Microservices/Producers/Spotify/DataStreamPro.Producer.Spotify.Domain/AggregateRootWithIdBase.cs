using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

using DataStreamPro.Common.Utils.Helpers;
using DataStreamPro.Producer.Spotify.Domain.Interfaces;

namespace DataStreamPro.Producer.Spotify.Domain
{
    public abstract class AggregateRootWithIdBase<TId> : EntityWithIdBase<TId>, IAggregateRootWithId<TId>
    {
        private readonly IDictionary<Type, Action<object>> _handlers = new ConcurrentDictionary<Type, Action<object>>();
        private readonly List<IEvent> _events = new List<IEvent>();

        protected AggregateRootWithIdBase() : this(default)
        {
        }

        protected AggregateRootWithIdBase(TId id) : base(id)
        {
            Created = DateTimeHelper.GenerateDateTime();
        }

        public int Version { get; protected set; }

        public IAggregateRootWithId<TId> AddEvent(IEvent uncommittedEvent)
        {
            _events.Add(uncommittedEvent);
            ApplyEvent(uncommittedEvent);
            return this;
        }

        public IAggregateRootWithId<TId> ApplyEvent(IEvent payload)
        {
            if (!_handlers.ContainsKey(payload.GetType()))
                return this;
            _handlers[payload.GetType()]?.Invoke(payload);
            Version++;
            return this;
        }

        public void ClearUncommittedEvents()
        {
            _events.Clear();
        }

        public List<IEvent> GetUncommittedEvents()
        {
            return _events;
        }

        public IAggregateRootWithId<TId> RegisterHandler<T>(Action<T> handler)
        {
            _handlers.Add(typeof(T), e => handler((T)e));
            return this;
        }

        public IAggregateRootWithId<TId> RemoveEvent(IEvent @event)
        {
            if (_events.Find(e => e == @event) != null)
                _events.Remove(@event);
            return this;
        }
    }
}