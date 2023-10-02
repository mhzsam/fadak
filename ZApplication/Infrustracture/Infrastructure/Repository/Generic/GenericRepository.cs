using Application.Interface;
using Domain.Context;
using Domain.Entites.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityClass
    {
        private readonly ApplicationDBContext _context;
        private readonly DbSet<T> _entities;
        string _errorMessage = string.Empty;

        public GenericRepository(ApplicationDBContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Remove(entity);
        }

        public async Task<T>  GetAsync(long id)
        {
            return await _entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<T>> GetAllAsync(int page, int rowPerPage)
        {
            if (page > 0)
            {
                page = page - 1;
            }
            return await _entities.Skip(page).Take(rowPerPage).ToListAsync();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entities.Update(entity);
        }

        public async Task<T> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _entities.Where(predicate).FirstOrDefaultAsync();
        }
    }
}
