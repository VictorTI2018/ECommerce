using ECommerce.Adapter.EntityFramework.SqlServer.Context;
using ECommerce.Adapter.EntityFramework.SqlServer.Repositories.Base;
using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Interfaces.Repositories;

namespace ECommerce.Adapter.EntityFramework.SqlServer.Repositories
{
    public class CategoryRepository : BaseRepository<CategoriaEntity>, ICategoryRepository
    {
        public CategoryRepository(ECommerceContext context) : base(context)
        {
            
        }
    }
}
