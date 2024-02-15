using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager _carManager = new CarManager(new EfCarDal());

//using var context = new ReCapContext();
_carManager.Add(new Car
{
    BrandId = 1,
    ColorId = 1,
    DailyPrice = 1,
    Description = "222",
    ModelYear = 11
});
//_carManager.GetAll().ToList().ForEach(c => Console.WriteLine(c.Description));
var test = _carManager.GetAllAsync();
foreach (var car in test.Result.ToList())
{
    Console.WriteLine(car.Description);
}
