using System;
using KitapsterAPI.Domain.Core.UnitOfWork;
using System.Linq;
using System.Linq.Expressions;
using KitapsterAPI.Domain.Entites.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace KitapsterAPI.Domain.Core.Repository
{
    public class Repository<TEntity, PKey> : IRepository<TEntity, PKey> where TEntity : BaseEntity
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;

        public Repository(IUnitOfWorkFactory unitOfWorkFactory) => this.unitOfWorkFactory = unitOfWorkFactory;

        public async Task<TEntity> GetAsync(
          IUnitOfWork unitOfWork,
          Expression<Func<TEntity, bool>> predicate)
        {
            return await unitOfWork.GetCurrentDbContext<DbContext>().Set<TEntity>().Where<TEntity>(predicate).FirstOrDefaultAsync<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(IUnitOfWork unitOfWork, PKey Id) => await unitOfWork.GetCurrentDbContext<DbContext>().Set<TEntity>().Where<TEntity>((Expression<Func<TEntity, bool>>)(x => x.Id.Equals((object)Id))).FirstOrDefaultAsync<TEntity>();

        public async Task<IEnumerable<TEntity>> GetListAsync(
          IUnitOfWork unitOfWork,
          Expression<Func<TEntity, bool>> predicate)
        {
            return (IEnumerable<TEntity>)await unitOfWork.GetCurrentDbContext<DbContext>().Set<TEntity>().Where<TEntity>(predicate).ToListAsync<TEntity>();
        }

        public async Task InsertAsync(IUnitOfWork unitOfWork, TEntity entity)
        {
            DbContext context = unitOfWork.GetCurrentDbContext<DbContext>();
            EntityEntry<TEntity> entityEntry = await context.Set<TEntity>().AddAsync(entity);
            int num = await context.SaveChangesAsync();
            context = (DbContext)null;
        }

        public async Task BulkInsertAsync(IUnitOfWork unitOfWork, IEnumerable<TEntity> entities)
        {
            DbContext context = unitOfWork.GetCurrentDbContext<DbContext>();
            await context.Set<TEntity>().AddRangeAsync(entities);
            int num = await context.SaveChangesAsync();
            context = (DbContext)null;
        }

        public async Task UpdateAsync(IUnitOfWork unitOfWork, TEntity entity)
        {
            DbContext currentDbContext = unitOfWork.GetCurrentDbContext<DbContext>();
            currentDbContext.Entry<TEntity>(entity).State = EntityState.Modified;
            int num = await currentDbContext.SaveChangesAsync();
        }

        public async Task BulkUpdateAsync(IUnitOfWork unitOfWork, IEnumerable<TEntity> entities)
        {
            DbContext currentDbContext = unitOfWork.GetCurrentDbContext<DbContext>();
            currentDbContext.UpdateRange((IEnumerable<object>)entities);
            int num = await currentDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(IUnitOfWork unitOfWork, TEntity entity)
        {
            DbContext currentDbContext = unitOfWork.GetCurrentDbContext<DbContext>();
            currentDbContext.Entry<TEntity>(entity).State = EntityState.Deleted;
            int num = await currentDbContext.SaveChangesAsync();
        }

        public async Task BulkDeleteAsync(IUnitOfWork unitOfWork, IEnumerable<TEntity> entities)
        {
            DbContext currentDbContext = unitOfWork.GetCurrentDbContext<DbContext>();
            currentDbContext.RemoveRange((IEnumerable<object>)entities);
            int num = await currentDbContext.SaveChangesAsync();
        }
    }
}

