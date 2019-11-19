using System;
using System.Threading;
using System.Threading.Tasks;

namespace DataStreamPro.Producer.Spotify.Domain.Interfaces
{
    public interface IUnitOfWorkAsync : IRepositoryFactoryAsync, IDisposable
    {
        int SaveChanges();
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}