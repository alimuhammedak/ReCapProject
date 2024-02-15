using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using var context = new ReCapContext();
            var addedEntry = context.Entry(entity);
            addedEntry.State = EntityState.Added;
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<Car> entities)
        {
            using var context = new ReCapContext();
            context.Car.AddRange(entities);
            context.SaveChanges();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using var context = new ReCapContext();
            return context.Car.SingleOrDefault(filter) ?? new Car() { Description = "zorunlu doldurulması gereken property" };
        }


        public async Task<IEnumerable<Car>> GetAllAsync(Expression<Func<Car, bool>>? filter = null)
        {
            using var context = new ReCapContext();

            IQueryable<Car> query = context.Car;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
