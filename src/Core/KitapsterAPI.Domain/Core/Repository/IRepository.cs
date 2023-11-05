using System;
using KitapsterAPI.Domain.Core.UnitOfWork;
using System.Linq.Expressions;
using KitapsterAPI.Domain.Entites.Common;

namespace KitapsterAPI.Domain.Core.Repository
{
    public interface IRepository<TEntity, PKey> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(IUnitOfWork unitOfWork, PKey Id);

        Task<TEntity> GetAsync(IUnitOfWork unitOfWork, Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetListAsync(
          IUnitOfWork unitOfWork,
          Expression<Func<TEntity, bool>> predicate);

        Task InsertAsync(IUnitOfWork unitOfWork, TEntity entity);

        Task BulkInsertAsync(IUnitOfWork unitOfWork, IEnumerable<TEntity> entities);

        Task UpdateAsync(IUnitOfWork unitOfWork, TEntity entity);

        Task BulkUpdateAsync(IUnitOfWork unitOfWork, IEnumerable<TEntity> entities);

        Task DeleteAsync(IUnitOfWork unitOfWork, TEntity entity);

        Task BulkDeleteAsync(IUnitOfWork unitOfWork, IEnumerable<TEntity> entities);
    }
}

