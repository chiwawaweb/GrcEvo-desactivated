﻿using System;
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

            List<EntityCustomer> listeCustomer = new List <EntityCustomer>();
            listeCustomer.Add(new EntityCustomer { NumberCode = 98, Civility = "Mlle", Adress1 = "RUE DES PRES" });
            listeCustomer.Add(new EntityCustomer { NumberCode = 99, Civility = "M.", Adress1 = "RUE DES MARCHANDS" });

            List<EntitySupplier> listeSupplier = new List<EntitySupplier>();
            listeSupplier.Add(new EntitySupplier { NumberCode = 498, Civility = "SARL" });
            listeSupplier.Add(new EntitySupplier { NumberCode = 792, Civility = "SA" });

            List<EntityProspect> listeProspect = new List<EntityProspect>();
            listeProspect.Add(new EntityProspect { NumberCode = 998, Civility = "Dr" });

            List<EntityCustomerFamily> listCustomerFamily = new List<EntityCustomerFamily>();
            listCustomerFamily.Add(new EntityCustomerFamily { Name = "Particulier", Abbreviation = "PA"});
            listCustomerFamily.Add(new EntityCustomerFamily { Name = "Comité d'entreprise", Abbreviation = "CE"});
            listCustomerFamily.Add(new EntityCustomerFamily { Name = "Société", Abbreviation = "SO" });

            List<EntitySupplierFamily> listSupplierFamily = new List<EntitySupplierFamily>();
            listSupplierFamily.Add(new EntitySupplierFamily { Name = "Entreprise", Abbreviation = "EN" });
            listSupplierFamily.Add(new EntitySupplierFamily { Name = "Association", Abbreviation = "AS" });

            List<EntityProspectFamily> listProspectFamily = new List<EntityProspectFamily>();
            listProspectFamily.Add(new EntityProspectFamily { Name = "Particulier", Abbreviation = "PA" });
            listProspectFamily.Add(new EntityProspectFamily { Name = "Comité d'entreprise", Abbreviation = "CE" });
            listProspectFamily.Add(new EntityProspectFamily { Name = "Société", Abbreviation = "SO" });

            listCivility.ForEach(entity => context.Civilities.Add(entity));
            listeCustomer.ForEach(entity => context.Customers.Add(entity));
            listeSupplier.ForEach(entity => context.Suppliers.Add(entity));
            listeProspect.ForEach(entity => context.Prospects.Add(entity));
            listCustomerFamily.ForEach(entity => context.CustomerFamilies.Add(entity));
            listSupplierFamily.ForEach(entity => context.SupplierFamilies.Add(entity));
            listProspectFamily.ForEach(entity => context.ProspectFamilies.Add(entity));

        }
    }
}
