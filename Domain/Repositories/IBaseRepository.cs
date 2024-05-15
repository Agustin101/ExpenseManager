using Domain.Common;

namespace Domain.Repositories;

public interface IBaseRepository<T> where T : BaseEntity
{
    Task<int> Create(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<T> Get(Guid id, CancellationToken cancellationToken);
    Task<IQueryable<T>> GetAll(CancellationToken cancellationToken);
}