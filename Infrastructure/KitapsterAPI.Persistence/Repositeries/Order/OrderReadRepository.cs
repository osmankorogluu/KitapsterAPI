using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Domain.Core.Repository;
using KitapsterAPI.Domain.Core.UnitOfWork;
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
    public class OrderReadRepository : Repository<Order, Guid>, IOrderReadRepository
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public OrderReadRepository(
            IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }


    }
}
