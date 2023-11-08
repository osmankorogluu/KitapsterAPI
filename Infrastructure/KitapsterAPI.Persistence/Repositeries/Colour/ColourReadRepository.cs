using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Domain.Entites.Models;
using KitapsterAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Persistence.Repositeries
{
    public class ColourReadRepository : ReadRepository<Domain.Entites.Models.Colour>, IColourReadRepository
    {
        public ColourReadRepository(KitapsterDbContext context) : base(context)
        {

        }

    }
}
