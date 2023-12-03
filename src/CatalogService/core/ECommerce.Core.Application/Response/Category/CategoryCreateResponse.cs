namespace ECommerce.Core.Application.Response.Category
{
    public  class CategoryCreateResponse
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public CategoryCreateResponse(int id, 
            string name, 
            string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
