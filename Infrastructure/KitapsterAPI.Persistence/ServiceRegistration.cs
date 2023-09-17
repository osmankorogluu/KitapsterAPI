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

namespace KitapsterAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
            services.AddDbContext<KitapsterDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-5SML2C9\SQLEXPRESS;Database=KitapsterAPIdb;Trusted_Connection=True; TrustServerCertificate=True;"));
           
            services.AddScoped<IProductReadRepository, BookReadRepository>();
            services.AddScoped<IProductWriteRepository, BookWriteRepository>();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

        }
    }
}
