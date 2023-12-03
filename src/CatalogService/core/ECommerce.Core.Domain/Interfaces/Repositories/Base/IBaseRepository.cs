using ECommerce.Core.Domain.Entities.Base;
using System.Linq.Expressions;

namespace ECommerce.Core.Domain.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T>
        where T : BaseEntity
    {
        Task<T> AddAsync(T entity);

        Task<bool> ExistsAsync(Expression<Func<T, bool>> expression);
    }
}
