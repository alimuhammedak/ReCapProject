using DataAccess.Concrete.EntityFramework;

CarManager _carManager = new CarManager(new EfCarDal());

using var context = new ReCapContext();

//_carManager.GetAll().ToList().ForEach(c => Console.WriteLine(c.Description));
var test = _carManager.GetAllAsync();
foreach (var car in test.Result.ToList())
{
    Console.WriteLine(car.Description);
}
