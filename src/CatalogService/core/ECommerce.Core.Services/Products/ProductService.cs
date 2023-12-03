using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Interfaces.Repositories;
using ECommerce.Core.Domain.Interfaces.Services;
using ECommerce.Core.Domain.Response;
using ECommerce.Core.Services.Validators.Product;

namespace ECommerce.Core.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProdutoRepository _productRepository;

        public ProductService(IProdutoRepository produtoRepository)
        {
            _productRepository = produtoRepository;
        }

        public async Task<IEnumerable<ProdutoEntity>> GetAllByCategory(int categoryId)
            => await _productRepository.GetAllByExpressionAsync(p => p.CategoryId.Equals(categoryId)); 

        public async Task<ServiceResponse> SaveAsync(ProdutoEntity entity)
        {
            try
            {
                ProductCreateValidator validator = new();
                var result = validator.Validate(entity);

                if (!result.IsValid)
                    return new ServiceResponse(result.Errors.Select(e => e.ErrorMessage).ToList(), result.IsValid);

                if (await _productRepository.ExistsAsync(p => p.Name.Equals(entity.Name)))
                    return new ServiceResponse($"Produto [{entity.Name}] já cadastrado.", false);

                await _productRepository.AddAsync(entity);

                return new ServiceResponse(result.IsValid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
