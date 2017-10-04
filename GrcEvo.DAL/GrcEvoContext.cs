using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GrcEvo.DTO;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace GrcEvo.DAL
{
    class GrcEvoContext : DbContext
    {
        public GrcEvoContext() : base("GrcEvo")
        {
            // Change la stratégie d'initialisation avec celle que nous avons défini dans GarageContextInitializer
            Database.SetInitializer<GrcEvoContext>(new GrcEvoContextInitializer());
        }

        public DbSet<EntityCustomer> Customers { get; set; }
    }
}
