using System.Diagnostics;
using DataAccess.Abstract;
using Entities.Concrete;

public class CarManager : ICarService
{
    private ICarDal? _carDal;

    /// <summary>
    /// Represents a manager class for handling car-related operations.
    /// </summary>

    public CarManager(ICarDal carRepository)
    {
        _carDal = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
    }

    public void Add(Car car)
    {
        if (car.ModelYear > 2005
            && car.DailyPrice < 100.000m)
        {
            try
            {
                _carDal?.Add(car);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw new Exception(exception.Message);
            }
        }
        else
        {
            Console.WriteLine("Ýþlem baþarýsýz. Lütfen tekrar deneyiniz");
        }

    }

    public void Delete(Car car) => _carDal?.Delete(car);

    public async Task<IEnumerable<Car>> GetAllAsync()
    {
        var test = await _carDal.GetAllAsync();
        return test;
    }

    public void Update(Car car) => _carDal?.Update(car);

    public Car GetCarById(int id)
    {
        return _carDal.Get(car => car.CarId == id);
    }

    public Car GetCarByDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException("Açýklama boþ olamaz.", nameof(description));
        }

        Debug.Assert(_carDal != null, nameof(_carDal) + " != null");
        Car car = _carDal.Get(car => car.Description == description);

        if (car == null)
        {
            throw new Exception($"Açýklamasý '{description}' olan araba bulunamadý.");
        }

        return car;
    }

    public void AddRange(IEnumerable<Car> entites)
    {
        _carDal.AddRange(entites);
    }
}