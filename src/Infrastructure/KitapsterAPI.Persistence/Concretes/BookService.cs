using KitapsterAPI.Application.Abstractions;
using KitapsterAPI.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Persistence.Concretes
{
    public class BookService : IBookService
    {
        public List<Book> GetBooks()
            => new()
        {
            new(){BookName= "bir şeytanın papazı"} 
        };
    }
}
