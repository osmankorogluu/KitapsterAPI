using AutoMapper;
using KitapsterAPI.Domain.Entites.Models;
using KitapsterAPI.Domain.Entites.Queries;
using KitapsterAPI.Domain.Entites.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, LoginUserViewModel>()
                .ReverseMap();

            CreateMap<User, CreateUserCommand>() .ReverseMap();
        }
    }
}
