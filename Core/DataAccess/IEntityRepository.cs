using Core.Entities;
using System.Linq.Expressions;
using Core.Utilities.Result;

namespace Core.DataAccess;

public interface IEntityRepository<T> where T : class, IEntity
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
    T Get(Expression<Func<T, bool>> filter);
    Task<T> GetAsync(Expression<Func<T, bool>>? filter = null);
    void AddRange(IEnumerable<T> entities);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}