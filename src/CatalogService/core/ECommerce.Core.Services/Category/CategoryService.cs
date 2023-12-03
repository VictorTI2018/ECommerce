using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Interfaces.Repositories;
using ECommerce.Core.Domain.Interfaces.Services;
using ECommerce.Core.Domain.Response;
using ECommerce.Core.Services.Validators.Category;

namespace ECommerce.Core.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ServiceResponse> SaveAsync(CategoriaEntity entity)
        {
            try
            {
                CategoryCreateValidator validator = new();
                var result = validator.Validate(entity);

                if (!result.IsValid)
                    return new ServiceResponse(result.Errors.Select(e => e.ErrorMessage).ToList(), result.IsValid);

                if (await _categoryRepository.ExistsAsync(c => c.Name.Equals(entity.Name)))
                    return new ServiceResponse($"Categoria [{entity.Name}] já cadastrada.", false);

                await _categoryRepository.AddAsync(entity);

                return new ServiceResponse(result.IsValid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
