using ECommerce.Core.Application.Request.Category;
using ECommerce.Core.Application.Response;
using ECommerce.Core.Application.Response.Category;
using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Domain.Interfaces.Repositories;
using ECommerce.Core.Domain.Interfaces.Services;

namespace ECommerce.Core.Application.Presenter.Category
{
    public class CategoryPresenter : ICategoryPresenter
    {
        private readonly ICategoryService _categoryService;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryPresenter(ICategoryService categoryService,
            IUnitOfWork unitOfWork)
        {
            _categoryService = categoryService;
            _unitOfWork = unitOfWork;
        }

        public async Task<PresenterResponse> SaveAsync(CategoryCreateRequest request)
        {
            try
            {
                CategoriaEntity entity = new(request.Name, request.Description);

                var reult = await _categoryService.SaveAsync(entity);
                if (!reult.Status)
                    return new PresenterResponse(reult.Messages, reult.Status);

                await _unitOfWork.CommitAsync();

                return new PresenterResponse("Categoria cadastrada com sucesso.",
                    reult.Status,
                    new CategoryCreateResponse(entity.Id, entity.Name, entity.Description));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
