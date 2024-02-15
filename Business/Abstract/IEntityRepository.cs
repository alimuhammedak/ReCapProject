public interface IEntityRepository<T>
{
    Task<IEnumerable<T>> GetAllAsync();
    T GetCarById(int id);
    void AddRange(IEnumerable<T> entites);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}