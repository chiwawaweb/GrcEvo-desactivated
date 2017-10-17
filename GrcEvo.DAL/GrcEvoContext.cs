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
    public class GrcEvoContext : DbContext
    {
        public GrcEvoContext() : base("GrcEvo")
        {
            Database.SetInitializer<GrcEvoContext>(new GrcEvoContextInitializer());
        }
        public DbSet<EntityThirdParty> ThirdParties { get; set; }
        public DbSet<EntityCountry> Countries { get; set; }
        public DbSet<EntityThirdPartyFamily> ThirdPartyFamilies { get; set; }
        public DbSet<EntityItem> Items { get; set; }
        public DbSet<EntityItemFamily> ItemFamilies { get; set; }
        public DbSet<EntityInvoice> Invoices { get; set; }
        public DbSet<EntityOrder> Orders { get; set; }
        public DbSet<EntityQuote> Quotes { get; set; }
        public DbSet<EntityReceipt> Receipts { get; set; }
    }
}
