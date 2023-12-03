using ECommerce.Adapter.EntityFramework.SqlServer.Context;
using ECommerce.Core.Domain.Interfaces.Repositories;

namespace ECommerce.Adapter.EntityFramework.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceContext _context;

        public UnitOfWork(ECommerceContext context)
        {
            _context = context;
        }

        private bool _disposed = false;


        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
