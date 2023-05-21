﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Domain.Entites.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
