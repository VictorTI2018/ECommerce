using ECommerce.Core.Application.Presenter.Category;
using ECommerce.Core.Application.Presenter.Product;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Core.Application
{
    public static class ApplicationInjectionModule
    {
        public static void AddPresenterModule(this IServiceCollection services)
        {
            services.AddScoped<ICategoryPresenter, CategoryPresenter>();
            services.AddScoped<IProductPresenter, ProductPresenter>();
        }
    }
}
