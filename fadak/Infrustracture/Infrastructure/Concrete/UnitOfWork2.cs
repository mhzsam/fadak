using Application.Interface;
using Domain.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Concrete
{
    public class UnitOfWork2 : IUnitOfWork
    {
        public Task BeginTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public Task BulkSaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IMovieRepository GetMovieRepository()
        {
            var test = 1;
            throw new NotImplementedException();
        }

        public IRepository<ET> GetRepository<ET>() where ET : EntityClass
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
