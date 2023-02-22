using System.Linq.Expressions;
using Unwired.Models.Types;

namespace Unwired.Domain.Abstractions.Interfaces;

public interface IURepository<TEntity> : IDisposable where TEntity : class
{
    Task<TEntity> GetById(Guid id, bool tracking = false);
    IQueryable<TEntity> GetAll(ICollection<USort> sort = null, string filter = "");
    IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate, ICollection<USort> sort = null);
    Task Add(TEntity obj);        
    Task Add(ICollection<TEntity> entities);
    void Update(TEntity obj);
    void Remove(Guid id, bool destroy = false);
    void Remove(TEntity entity, bool destroy = false);
    void Remove(ICollection<TEntity> trackedEntities, bool destroy = false);
    void Remove(ICollection<Guid> ids, bool destroy = false);
    Task<bool> Exists(Expression<Func<TEntity, bool>> predicate);
    Task<bool> Exists(Guid id);
    Task<int> Commit();        
}
