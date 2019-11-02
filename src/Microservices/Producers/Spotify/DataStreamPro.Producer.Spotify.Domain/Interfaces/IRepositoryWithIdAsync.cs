using System.Threading.Tasks;

namespace DataStreamPro.Producer.Spotify.Domain.Interfaces
{
    public interface IRepositoryWithIdAsync<TEntity, TId> where TEntity : IAggregateRootWithId<TId>
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
    }
}