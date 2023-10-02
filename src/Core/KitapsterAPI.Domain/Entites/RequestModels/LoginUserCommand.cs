using KitapsterAPI.Domain.Entites.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Domain.Entites.RequestModels
{
    public class LoginUserCommand: IRequest<LoginUserViewModel>
    {
        public string EmailAddres { get;  set; }
        public string Password { get;  set; }

        public LoginUserCommand(string emailAddres, string password)
        {
            EmailAddres = emailAddres;
            Password = password;
        }
        public LoginUserCommand()
        {
                
        }
    }
}
