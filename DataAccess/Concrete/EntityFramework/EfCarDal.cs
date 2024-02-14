using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<Car> GetAll(Expression<Func<Car, bool>>? filter = null)
        {
            using var context = new ReCapContext();
            return filter is null 
                ? context.Car 
                : context.Car.Where(filter);

        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
