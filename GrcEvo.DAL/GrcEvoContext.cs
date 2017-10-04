using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GrcEvo.DTO;

namespace GrcEvo.DAL
{
    class GrcEvoContext : DbContext
    {
        public DbSet<EntityCustomer> Customers { get; set; }
    }
}
