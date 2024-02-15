using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using var context = new ReCapContext();
            var addedEntry = context.Entry(entity);
            addedEntry.State = EntityState.Added;
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<Color> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Color>> GetAllAsync(Expression<Func<Color, bool>>? filter = null)
        {
            using var context = new ReCapContext();

            IQueryable<Color> query = context.Color;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
