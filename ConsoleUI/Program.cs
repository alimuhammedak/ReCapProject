using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager _carManager = new CarManager(new InMemoryCarDal());

List<Car> cars =  new List<Car>
{
    new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2015, DailyPrice=150, Description="Audi A3"},
    new Car{CarId=2, BrandId=1, ColorId=2, ModelYear=2016, DailyPrice=200, Description="Audi A4"},
    new Car{CarId=3, BrandId=2, ColorId=3, ModelYear=2017, DailyPrice=250, Description="BMW 3.20"},
    new Car{CarId=4, BrandId=2, ColorId=4, ModelYear=2018, DailyPrice=300, Description="BMW 5.20"},
    new Car{CarId=5, BrandId=3, ColorId=5, ModelYear=2019, DailyPrice=350, Description="Mercedes C180"}
};

_carManager.GetAll().ForEach(c => Console.WriteLine(c.Description));

var car1 = new Car{CarId=3, BrandId=3, ColorId=5, ModelYear=2019, DailyPrice=350, Description="Mercedes C180"};
_carManager.Delete(car1);
_carManager.GetAll().ForEach(c => Console.WriteLine(c.Description));