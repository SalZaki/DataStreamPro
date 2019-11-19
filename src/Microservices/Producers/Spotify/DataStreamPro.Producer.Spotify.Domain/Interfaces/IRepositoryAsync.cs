using System;

namespace DataStreamPro.Producer.Spotify.Domain.Interfaces
{
    public interface IRepositoryAsync<TEntity> : IRepositoryWithIdAsync<TEntity, Guid> where TEntity : IAggregateRoot
    {

    }
}