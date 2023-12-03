using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Response;

namespace ECommerce.Core.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<ServiceResponse> SaveAsync(ProdutoEntity entity);

        Task<IEnumerable<ProdutoEntity>> GetAllByCategory(int categoryId);
    }
}
