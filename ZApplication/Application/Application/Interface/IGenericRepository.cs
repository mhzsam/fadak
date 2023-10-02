using Domain.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IGenericRepository<T> where T : EntityClass
    {
        Task<IEnumerable<T>> GetAllAsync(int page, int rowPerPage);
        Task<T> GetAsync(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<T> FindByAsync(Expression<Func<T, bool>> predicate);
    }
}
