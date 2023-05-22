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

namespace KitapsterAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IBookService, BookService>();
            services.AddDbContext<KitapsterDbContext>(options => options.UseSqlServer("Server=SEMIH//SQLEXPRESS;Database=KitapsterAPIdb;Trusted_Connection=True;"));
         
        }
    }
}
