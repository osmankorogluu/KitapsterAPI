using System;
namespace KitapsterAPI.Domain.Core.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        TDbContext GetDbContextFromStack<TDbContext>();

        IUnitOfWork Create();

        IUnitOfWork CreateWithStack();
    }
}

