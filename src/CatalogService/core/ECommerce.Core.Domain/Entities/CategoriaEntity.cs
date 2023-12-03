using ECommerce.Core.Domain.Entities.Base;

namespace ECommerce.Core.Domain.Entities
{
    public class CategoriaEntity : BaseEntity
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public virtual IEnumerable<ProdutoEntity> Produtos { get; set; }

        public CategoriaEntity(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
