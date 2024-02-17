using Entities.Concrete;

internal interface ICarService
{
    Car GetCarByDescription(string description);
}