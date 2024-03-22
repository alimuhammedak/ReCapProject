using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract;

public interface ICarDal : IEntityRepository<Car>
{
    Task<IEnumerable<CarDetailDTOs>> GetCarDitailsAsync(Expression<Func<CarDetailDTOs, bool>>? filter = null);
}