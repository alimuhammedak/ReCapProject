using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

var _carManager = new CarManager(new EfCarDal());

//using var context = new ReCapContext();
//_carManager.Add(new Car
//{
//    BrandId = 1,
//    ColorId = 1,
//    DailyPrice = 1,
//    Description = "222",
//    ModelYear = 11
//});

//_carManager.GetAllAsync().Result.ToList().ForEach(c => Console.WriteLine(c.Description));
_carManager.GetCarDetails().Result.ToList().ForEach(c => Console.WriteLine($"CarID: {c.CarId,-10} \tCarName: {c.CarName,-32} \tBrandName: {c.BrandName,-15} \tColorName: {c.ColorName}"));