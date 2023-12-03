namespace ECommerce.Core.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        private DateTime? _created;

        public DateTime? Created { 
            get { return _created; }
            set { _created = (value is null ? DateTime.Now : value); }
        }

        public DateTime? Updated { get; set; }
    }
}
