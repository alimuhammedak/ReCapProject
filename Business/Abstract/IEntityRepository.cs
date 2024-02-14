using Entities.Abstract;
using Entities.Concrete;

interface IEntityRepository<T> 
{
    IEnumerable<T> GetAll();
    T GetCarById(int id);
    void AddRange(IEnumerable<T> entites);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}