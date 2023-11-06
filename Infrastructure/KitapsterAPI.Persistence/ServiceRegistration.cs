using KitapsterAPI.Application.Abstractions;
using KitapsterAPI.Persistence.Concretes;
using KitapsterAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitapsterAPI.Application.Repositories;
using KitapsterAPI.Persistence.Repositeries;
using KitapsterAPI.Application.Repositories.User;
using KitapsterAPI.Persistence.Repositeries.User;
using KitapsterAPI.Domain.Core.UnitOfWork;
using KitapsterAPI.Domain.Core.Repository;

namespace KitapsterAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
            services.AddDbContext<KitapsterDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-5SML2C9\SQLEXPRESS;Database=KitapsterAPIdb;Trusted_Connection=True;TrustServerCertificate=True;"));
           
            services.AddTransient<IProductReadRepository, BookReadRepository>();
            services.AddTransient<IProductWriteRepository, BookWriteRepository>();

            services.AddTransient<ICustomerReadRepository, CustomerReadRepository>();
            services.AddTransient<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddTransient<IOrderReadRepository, OrderReadRepository>();
            services.AddTransient<IOrderWriteRepository, OrderWriteRepository>();

            services.AddTransient<IUnitOfWorkFactory, FakeRepository>();

            


           

           

            


        }
    }
}
