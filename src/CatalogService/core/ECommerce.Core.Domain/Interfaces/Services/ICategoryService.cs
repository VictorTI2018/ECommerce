using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Response;

namespace ECommerce.Core.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<ServiceResponse> SaveAsync(CategoriaEntity entity);
    }
}
