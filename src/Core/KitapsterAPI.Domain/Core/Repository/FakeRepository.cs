using KitapsterAPI.Domain.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Domain.Core.Repository
{
    public class FakeRepository : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            throw new NotImplementedException();
        }

        public IUnitOfWork CreateWithStack()
        {
            throw new NotImplementedException();
        }

        public TDbContext GetDbContextFromStack<TDbContext>()
        {
            throw new NotImplementedException();
        }
    }
}
