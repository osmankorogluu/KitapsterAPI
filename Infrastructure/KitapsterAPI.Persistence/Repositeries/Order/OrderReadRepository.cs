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
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(KitapsterDbContext context) : base(context)
        {
        }
    }
}
