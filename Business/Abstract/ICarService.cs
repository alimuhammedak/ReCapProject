using DataAccess.Abstract;
using Entities.Concrete;

interface ICarService : IEntityRepository<Car>
{
    Car GetCarByDescription(string description);
}