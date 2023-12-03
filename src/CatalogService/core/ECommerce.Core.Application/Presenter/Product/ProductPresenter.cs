using ECommerce.Core.Application.Request.Product;
using ECommerce.Core.Application.Response;
using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Interfaces.Repositories;
using ECommerce.Core.Domain.Interfaces.Services;

namespace ECommerce.Core.Application.Presenter.Product
{
    public class ProductPresenter : IProductPresenter
    {
        private readonly IProductService _productService;
        private readonly IUnitOfWork _unitOfWork;

        public ProductPresenter(IProductService productService,
            IUnitOfWork unitOfWork)
        {
            _productService = productService;
            _unitOfWork = unitOfWork;
        }

        public async Task<PresenterResponse> GetAllByCategory(int categoryId) 
            => new PresenterResponse("", true, await _productService.GetAllByCategory(categoryId));

        public async Task<PresenterResponse> SaveAsync(ProductCreateRequest request)
        {
            try
            {
                ProdutoEntity entity = new(request.Name,
                    request.ImageUrl, request.Description,
                    request.Price, request.Stock,
                    request.CategoryId);

                var result = await _productService.SaveAsync(entity);

                if (!result.Status)
                    return new PresenterResponse(result.Messages, result.Status);

                await _unitOfWork.CommitAsync();

                return new PresenterResponse("Produto cadastrado com sucesso.",
                    result.Status,
                    new ProductCreateResponse(request.Name, request.Description,
                    request.Price, request.Stock, request.CategoryId));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
