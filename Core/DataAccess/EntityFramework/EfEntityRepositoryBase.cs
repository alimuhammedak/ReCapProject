using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using var context = new TContext();
        var addedEntry = context.Entry(entity);
        addedEntry.State = EntityState.Added;
        context.SaveChanges();
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        using var context = new TContext();
        context.Set<TEntity>().AddRange(entities);
        context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using var context = new TContext();
        return context.Set<TEntity>().SingleOrDefault(filter) ?? new TEntity();
    }


    public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
    {
        using var context = new TContext();

        IQueryable<TEntity> query = context.Find<TEntity>();

        if (filter != null) query = query.Where(filter);

        return await query.ToListAsync();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}