using Entities.Concrete;
using System;
using System.Linq;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int carId);
        List<Car> GetByName(string carName);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        void DeleteRange(List<Car> cars);
    }
}
