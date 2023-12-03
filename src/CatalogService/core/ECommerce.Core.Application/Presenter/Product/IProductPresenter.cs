using ECommerce.Core.Application.Request.Product;
using ECommerce.Core.Application.Response;

namespace ECommerce.Core.Application.Presenter.Product
{
    public interface IProductPresenter
    {
        Task<PresenterResponse> SaveAsync(ProductCreateRequest request);

        Task<PresenterResponse> GetAllByCategory(int categoryId);
    }
}
