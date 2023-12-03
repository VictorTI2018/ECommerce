using ECommerce.Adapter.EntityFramework.SqlServer.Context;
using ECommerce.Core.Domain.Entities.Base;
using ECommerce.Core.Domain.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerce.Adapter.EntityFramework.SqlServer.Repositories.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        private readonly ECommerceContext _context;

        public BaseRepository(ECommerceContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllByExpressionAsync(Expression<Func<T, bool>> expression) 
            => await _context.Set<T>().Where(expression).ToListAsync();

        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> expression)
            => await _context.Set<T>().AnyAsync(expression); 

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                entity.Created ??= DateTime.Now;

                return (await _context.Set<T>().AddAsync(entity)).Entity;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
