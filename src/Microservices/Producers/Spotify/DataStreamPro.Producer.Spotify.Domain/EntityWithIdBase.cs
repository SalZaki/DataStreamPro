using System;
using System.ComponentModel.DataAnnotations;

using DataStreamPro.Common.Utils.Helpers;
using DataStreamPro.Producer.Spotify.Domain.Interfaces;

namespace DataStreamPro.Producer.Spotify.Domain
{
    public abstract class EntityWithIdBase<TId> : IEntityWithId<TId>
    {
        protected EntityWithIdBase(TId id)
        {
            Id = id;
            Created = DateTimeHelper.GenerateDateTime();
        }

        public DateTime Created { get; protected set; }

        public DateTime Updated { get; protected set; }

        [Key]
        public TId Id { get; protected set; }
    }
}