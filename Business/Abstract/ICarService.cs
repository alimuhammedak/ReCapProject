using DataAccess.Abstract;
using Entities.Concrete;

interface ICarService
{
    List<Car> GetById(int carId);
    List<Car> GetByName(string carName);
    List<Car> GetAll();
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);
    void DeleteRange(List<Car> cars);
}