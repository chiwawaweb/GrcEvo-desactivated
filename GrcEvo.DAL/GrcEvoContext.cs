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
            Database.SetInitializer<GrcEvoContext>(new GrcEvoContextInitializer());
        }

        public DbSet<EntityThirdParty> ThirdParties { get; set; }
        public DbSet<EntityCustomer> Customers { get; set; }
        public DbSet<EntitySupplier> Suppliers { get; set; }
        public DbSet<EntityProspect> Prospects { get; set; }
        public DbSet<EntityCountry> Countries { get; set; }
        public DbSet<EntityCivility> Civilities { get; set; }
        public DbSet<EntityThirdPartyFamily> ThirdPartyFamilies { get; set; }
        public DbSet<EntityCustomerFamily> CustomerFamilies { get; set; }
        public DbSet<EntitySupplierFamily> SupplierFamilies { get; set; }
        public DbSet<EntityProspectFamily> ProspectFamilies { get; set; }
    }
}
