using ECommerce.Core.Domain.Entities;
using FluentValidation;

namespace ECommerce.Core.Services.Validators.Product
{
    public class ProductCreateValidator : AbstractValidator<ProdutoEntity>
    {
        public ProductCreateValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage(p => $"Campo {nameof(p.Name)} é obrigatório.");

            RuleFor(p => p.Description)
                .NotEmpty()
                .WithMessage(p => $"Campo {nameof(p.Description)} é obrigatório.");
        }
    }
}
