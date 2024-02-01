using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2015, DailyPrice=150, Description="Audi A3"},
                new Car{CarId=2, BrandId=1, ColorId=2, ModelYear=2016, DailyPrice=200, Description="Audi A4"},
                new Car{CarId=3, BrandId=2, ColorId=3, ModelYear=2017, DailyPrice=250, Description="BMW 3.20"},
                new Car{CarId=4, BrandId=2, ColorId=4, ModelYear=2018, DailyPrice=300, Description="BMW 5.20"},
                new Car{CarId=5, BrandId=3, ColorId=5, ModelYear=2019, DailyPrice=350, Description="Mercedes C180"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Where(c => c.CarId == car.CarId).ToList().ForEach(c => _cars.Remove(c));

        }

        public void DeleteRange(List<Car> cars)
        {
           _cars.Where(c => cars.Any(c1 => c1.CarId == c.CarId)).ToList().ForEach(c => _cars.Remove(c));
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<Car> GetByName(string carName)
        {
            return _cars.Where(c => c.Description.ToLower().Contains(carName.ToLower())).ToList();
        }

        public void Update(Car car)
        {
            Car? carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
        }
    }
}
