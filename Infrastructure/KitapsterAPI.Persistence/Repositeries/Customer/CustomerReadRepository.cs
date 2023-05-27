using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Domain.Entites.Models;
using KitapsterAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Persistence.Repositeries
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(KitapsterDbContext context) : base(context)
        {
        }
    }
}
