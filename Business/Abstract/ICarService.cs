using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

internal interface ICarService
{
    IResult Add(Car entity);
    IResult Update(Car entity);
    IResult Delete(Car entity);
    IDataResult<Car> GetCarById(int id);
    IDataResult<Car> GetCarByDescription(string description);
    Task<IDataResult<IEnumerable<Car>>> GetAllAsync();
    Task<IDataResult<IEnumerable<CarDetailDTOs>>> GetCarDetailsAsync();
    Task<IDataResult<IEnumerable<CarDetailDTOs>>> GetCarDetailsByDescription(string description);
}