using Entities.Concrete;
using Entities.DTOs;

internal interface ICarService
{
    Car GetCarByDescription(string description);

    Task<IEnumerable<CarDetailDTOs>> GetCarDetails();
    IEnumerable<CarDetailDTOs> GetCarDetailsByDescription(string description);
}