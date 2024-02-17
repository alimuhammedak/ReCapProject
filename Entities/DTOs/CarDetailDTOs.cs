using Core.Entities;
namespace Entities.DTOs
{
    public class CarDetailDTOs : IDtos
    {
        public int CarId { get; set; }
        public string CarName { get; set; } = string.Empty;
        public string BrandName { get; set; }
        public string ColorName { get; set; }
    }
}
