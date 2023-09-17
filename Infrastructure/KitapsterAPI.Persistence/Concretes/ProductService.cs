using KitapsterAPI.Application.Abstractions;
using KitapsterAPI.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetBooks()
            => new()
        {
                new(){ ProductName = "bir şeytanın papazı"}
        };
    }
}
