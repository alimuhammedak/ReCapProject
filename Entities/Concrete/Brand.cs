using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public required string Name { get; set; }

    }
}
