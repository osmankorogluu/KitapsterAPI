using System;
using System.Data;

namespace KitapsterAPI.Domain.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        TDbContext GetCurrentDbContext<TDbContext>();

        void Begin(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);

        void Commit();
    }
}

