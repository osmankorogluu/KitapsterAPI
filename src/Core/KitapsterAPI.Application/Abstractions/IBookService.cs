using KitapsterAPI.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.Abstractions
{
    public interface IBookService
    {
        List<Book> GetBooks();
    }
}
