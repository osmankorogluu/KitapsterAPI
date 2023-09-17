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
    public class BookReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public BookReadRepository(KitapsterDbContext context) : base(context)
        {
        }
    }
}
