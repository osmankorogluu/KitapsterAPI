using KitapsterAPI.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.WiewModels.Books
{
    public class VM_Create_Book
    {

  
        public string BookName { get; set; }
        public int ProductCode { get; set; }
        public int Stock { get; set; }
        //bu class ı sen mi oluşturdun evet
        // veri tabanındaki tüm alanları eklemen lazım 
    }
}
