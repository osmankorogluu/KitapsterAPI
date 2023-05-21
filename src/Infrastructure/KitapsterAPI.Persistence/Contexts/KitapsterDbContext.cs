using KitapsterAPI.Domain.Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Persistence.Contexts
{
    public class KitapsterDbContext: DbContext
    {
        public KitapsterDbContext(DbContextOptions options): base (options)
        {}

        public DbSet<Book> Books{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
    }
}
