using KitapsterAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.WiewModels.Books
{
    public class VM_Update_Book: BaseEntity
    {
       public string Id { get; set; }
        public string BookName { get; set; }
        public int ProductCode { get; set; }
        public int Stock { get; set; }
    }
}
