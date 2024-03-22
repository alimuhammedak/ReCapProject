using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess;

public interface IEntityRepository<T> where T : class, IEntity
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
    Task<T> GetAsync(Expression<Func<T, bool>>? filter = null);
    IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null);
    T Get(Expression<Func<T, bool>> filter);
    void AddRange(IEnumerable<T> entities);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}