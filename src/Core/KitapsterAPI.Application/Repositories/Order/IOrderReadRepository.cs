using KitapsterAPI.Domain.Core.Repository;
using KitapsterAPI.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.Repositories
{
    public interface IOrderReadRepository: IRepository<Order, Guid>
    {
    }
}
