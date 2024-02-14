using Entities.Concrete;
using System;
using System.Linq;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
    }
}
