using KitapsterAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Domain.Entites.Models
{
    public class Book : BaseEntity
    {
        //public Guid BookId { get; set; }
        //public int SubCategoryId { get; set; }
        public string BookName { get; set; }
        public int ProductCode { get; set; }
        public int Stock { get; set; }
        //public string Translator { get; set; }
        //public string Preparer { get; set; }
        //public string Publisher { get; set; }
        //public string PublicationPlace { get; set; }
        //public string Language { get; set; }
        //public string Skin { get; set; }
        //public int ISBN { get; set; }
        //public string Situation { get; set; }
        //public string Condition { get; set; }
        //public string Cargo { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
