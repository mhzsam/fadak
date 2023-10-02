using Domain.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUnitOfWork<T> :IGenericRepository<T> where T : EntityClass
    {
        public Task<bool> SaveChanges();
    }
}
