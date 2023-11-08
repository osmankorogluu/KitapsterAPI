using KitapsterAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Domain.Entites.Models
{
    public class Colour: BaseEntity
    {
        public string ColourName { get; set; }
    }
}
