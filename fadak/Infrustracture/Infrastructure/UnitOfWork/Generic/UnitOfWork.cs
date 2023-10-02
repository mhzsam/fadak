using Application.Interface;
using Domain.Context;
using Domain.Entites.Base;
using Infrastructure.Repository.Generic;


namespace Infrastructure.UnitOfWork.Generic
{
    public class UnitOfWork<T> : GenericRepository<T> , IUnitOfWork<T> where T : EntityClass 
    {
        private readonly ApplicationDBContext _context;

        public UnitOfWork(ApplicationDBContext context):base(context) 
        {
            _context = context;
        }        

        public async Task<bool> SaveChanges()
        {          
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
