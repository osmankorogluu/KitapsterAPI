using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.Extensions
{
    public static class Registration
    {
        public static IServiceCollection AddApplicationRegistration(this IServiceCollection services)
        {
            var assn = Assembly.GetExecutingAssembly();

            
            services.AddAutoMapper(assn);
            services.AddValidatorsFromAssembly(assn);

            return services;

        }
    }
}
