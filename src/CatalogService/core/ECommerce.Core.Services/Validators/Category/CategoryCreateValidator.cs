using ECommerce.Core.Domain.Entities;
using FluentValidation;

namespace ECommerce.Core.Services.Validators.Category
{
    public class CategoryCreateValidator : AbstractValidator<CategoriaEntity>
    {
        public CategoryCreateValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage(c => $"Campo {nameof(c.Name)} é obrigatório.");

            RuleFor(c => c.Description)
                .NotEmpty()
                .WithMessage(c => $"Campo {nameof(c.Description)} é obrigatório.");
        }
    }
}
