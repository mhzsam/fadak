using Domain.Entites.Base;

namespace Application.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ET> GetRepository<ET>() where ET : EntityClass;
   

        Task BeginTransactionAsync();

        void CommitTransaction();

        void RollbackTransaction();

        Task<int> SaveChangesAsync();

        void Dispose(bool disposing);
    }
}
