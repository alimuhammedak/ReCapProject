using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
{
    public async Task<IEnumerable<CarDetailDTOs>> GetCarDitails()
    {
        using var context = new ReCapContext();
        var result = context.Car.Select(car => new CarDetailDTOs
        {
            CarId = car.CarId,
            CarName = car.Description,
            BrandName = context.Brand.SingleOrDefault(brand => brand.BrandId == car.BrandId).Name,
            ColorName = context.Color.SingleOrDefault(color => color.ColorId == car.ColorId).Name
        });
        return await result.ToListAsync();
    }
}