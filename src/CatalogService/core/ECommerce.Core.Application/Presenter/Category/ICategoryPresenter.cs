using ECommerce.Core.Application.Request.Category;
using ECommerce.Core.Application.Response;
using ECommerce.Core.Domain.Entities;

namespace ECommerce.Core.Application.Presenter.Category
{
    public interface ICategoryPresenter
    {
        Task<PresenterResponse> SaveAsync(CategoryCreateRequest request);
    }
}
