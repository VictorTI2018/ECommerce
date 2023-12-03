using ECommerce.Adapter.EntityFramework.SqlServer.Context;
using ECommerce.Adapter.EntityFramework.SqlServer.Repositories.Base;
using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Interfaces.Repositories;

namespace ECommerce.Adapter.EntityFramework.SqlServer.Repositories
{
    public class ProdutoRepository : BaseRepository<ProdutoEntity>, IProdutoRepository
    {
        private readonly ECommerceContext _context;
        public ProdutoRepository(ECommerceContext context) : base(context)
        {
            _context = context;
        }


    }
}
