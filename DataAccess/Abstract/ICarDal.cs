using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface ICarDal : IEntityRepository<Car>
{
    Task<IEnumerable<CarDetailDTOs>> GetCarDitails();
}