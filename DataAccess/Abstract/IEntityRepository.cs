using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void AddRange(IEnumerable<T> entities);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
