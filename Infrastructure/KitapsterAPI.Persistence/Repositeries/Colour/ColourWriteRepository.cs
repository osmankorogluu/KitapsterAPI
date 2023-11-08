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
    public class ColourWriteRepository : WriteRepository<Domain.Entites.Models.Colour>, IColourWriteRepository
    {
        public ColourWriteRepository(KitapsterDbContext context) : base(context)
        {
        }
    }
}
