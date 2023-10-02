using KitapsterAPI.Domain.Entites.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.Repositories.User
{
    public interface IUserRepository : IGenericRepository<LoginUserViewModel>
    {
    }
}
