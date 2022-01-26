using ContaCorrente.Business.Core.Models;
using System;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Core.Data
{
    public interface ITransactionalRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(Guid id);
        Task<int> SaveChanges();
    }
}
