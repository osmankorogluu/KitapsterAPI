using KitapsterAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.WiewModels.Books
{
    public class VM_Update_Product: BaseEntity
    {
       public string Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public int Stock { get; set; }
    }
}
