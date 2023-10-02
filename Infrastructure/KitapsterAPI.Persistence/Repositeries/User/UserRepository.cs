using KitapsterAPI.Application.Repositories.User;
using KitapsterAPI.Domain.Entites.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Persistence.Repositeries.User
{
    public class UserRepository : GenericRepository<LoginUserViewModel>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
