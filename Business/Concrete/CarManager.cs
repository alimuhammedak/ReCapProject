using DataAccess.Abstract;
using Entities.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal? _carDal;

    /// <summary>
    /// Represents a manager class for handling car-related operations.
    /// </summary>

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }


    public void Add(Car car)
    {
        _carDal?.Add(car);
    }

    public void Delete(Car car)
    {
        _carDal?.Delete(car);
    }

    public void DeleteRange(List<Car> cars)
    {
        _carDal?.DeleteRange(cars);
    }

    public List<Car> GetAll()
    {
        return _carDal?.GetAll() ?? new List<Car>();
    }

    public List<Car> GetById(int carId)
    {
        return _carDal?.GetById(carId) ?? new List<Car>();
    }

    public List<Car> GetByName(string carName)
    {
        return _carDal?.GetByName(carName) ?? new List<Car>();
    }

    public void Update(Car car)
    {
        _carDal?.Update(car);
    }
}