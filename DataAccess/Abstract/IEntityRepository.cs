using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll(Expression<Func<T,bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void AddRange(IEnumerable<T> entities);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
