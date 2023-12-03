using ECommerce.Core.Domain.Entities.Base;

namespace ECommerce.Core.Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public string Name { get; private set; }

        public string ImageUrl { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int Stock { get; private set; }

        public int CategoryId { get; private set; }

        public virtual CategoriaEntity Categoria { get; set; }

        public ProdutoEntity(string name,
            string imageUrl,
            string description,
            decimal price,
            int stock,
            int categoryId)
        {
            Name = name;
            ImageUrl = imageUrl;
            Description = description;
            Price = price;
            Stock = stock;
            CategoryId = categoryId;
        }
    }
}
