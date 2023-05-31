using KitapsterAPI.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Domain.Entites.Models
{
    public class Category : BaseEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [NotMapped]
        public int BookId { get; set; }
        [NotMapped]
        public int SubCategoryId { get; set; }
    }
}
