using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using System.Data.Entity;

namespace GrcEvo.DAL
{
    class GrcEvoContextInitializer : DropCreateDatabaseAlways<GrcEvoContext>
    {
        /// <summary>
        /// Permet d'alimenter la base de données avec un jeu de données lors de sa construction
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(GrcEvoContext context)
        {
            List<EntityCivility> listCivility = new List<EntityCivility>();
            listCivility.Add(new EntityCivility { Name = "Monsieur", Abbreviation = "M." });
            listCivility.Add(new EntityCivility { Name = "Madame", Abbreviation = "Mme" });
            listCivility.Add(new EntityCivility { Name = "Mademoiselle", Abbreviation = "Mlle" });
            listCivility.Add(new EntityCivility { Name = "Docteur", Abbreviation = "Dr" });
            listCivility.Add(new EntityCivility { Name = "Maître", Abbreviation = "Me" });
            listCivility.Add(new EntityCivility { Name = "SA", Abbreviation = "SA" });
            listCivility.Add(new EntityCivility { Name = "SARL", Abbreviation = "SARL" });
            listCivility.Add(new EntityCivility { Name = "SCI", Abbreviation = "SCI" });


            List<EntityCustomer> listeCustomer = new List < EntityCustomer>();
            listeCustomer.Add(new EntityCustomer { NumberCode = 98, Civility = "Mlle" });
            listeCustomer.Add(new EntityCustomer { NumberCode = 99, Civility = "M." });

            List<EntitySupplier> listeSupplier = new List<EntitySupplier>();
            listeSupplier.Add(new EntitySupplier { NumberCode = 498, Civility = "SARL" });
            listeSupplier.Add(new EntitySupplier { NumberCode = 792, Civility = "SA" });

            List<EntityProspect> listeProspect = new List<EntityProspect>();
            listeProspect.Add(new EntityProspect { NumberCode = 998, Civility = "Pp1" });

            List<EntityCustomerFamily> listeCustomerFamily = new List<EntityCustomerFamily>();
            listeCustomerFamily.Add(new EntityCustomerFamily { Name = "Fam1CL", Abbreviation = "FA1"});
            listeCustomerFamily.Add(new EntityCustomerFamily { Name = "Fam2CL", Abbreviation = "FA2"});

            listeCustomer.ForEach(entity => context.Customers.Add(entity));
            listeSupplier.ForEach(entity => context.Suppliers.Add(entity));
            listeProspect.ForEach(entity => context.Prospects.Add(entity));
            listeCustomerFamily.ForEach(entity => context.CustomerFamilies.Add(entity));
            
        }
    }
}
