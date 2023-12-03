using ECommerce.Core.Domain.Interfaces.Services;
using ECommerce.Core.Services.Category;
using ECommerce.Core.Services.Products;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Core.Services
{
    public static class ServiceInjectionModule
    {
        public static void AddServiceModule(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
