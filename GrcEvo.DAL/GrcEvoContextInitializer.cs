using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using System.Data.Entity;

namespace GrcEvo.DAL
{
    public class GrcEvoContextInitializer : DropCreateDatabaseAlways<GrcEvoContext>
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

            List<EntityThirdParty> listThirdParty = new List <EntityThirdParty>();
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "CL", NumberCode = 91, Civility = "Mlle", Name="BROCHARD SYLVIE", Adress1 = "RUE DES PRES", Adress2 = "lig2", Adress3 = "lig3", PostalCode="57650", City="FONTOY'R", Country="FRANCE" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "CL", NumberCode = 95, Civility = "M.", Name = "DUMONT ANTOINE", Adress1 = "RUE DES MARCHANDS", Blocked=true });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "PP", NumberCode = 107, Civility = "SA", Name = "SOCIETE GENERALE", Adress1 = "RUE DU PARC" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "PP", NumberCode = 108, Civility = "Mme", Name = "ARMAND GINETTE", Adress1 = "AVENUE JOFFRE" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "FR", NumberCode = 543, Civility = "SARL", Name = "ETOILES ET CIE", Adress1 = "RUE DES MARCHANDS" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "FR", NumberCode = 547, Name = "TROIS FLEURS", Adress1 = "BD RASPAIL" });

            /*
            List<EntitySupplier> listeSupplier = new List<EntitySupplier>();
            listeSupplier.Add(new EntitySupplier { NumberCode = 498, Civility = "SARL" });
            listeSupplier.Add(new EntitySupplier { NumberCode = 792, Civility = "SA" });

            List<EntityProspect> listeProspect = new List<EntityProspect>();
            listeProspect.Add(new EntityProspect { NumberCode = 998, Civility = "Dr" });
            */
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
            listThirdParty.ForEach(entity => context.ThirdParties.Add(entity));
            /*
            listeSupplier.ForEach(entity => context.Suppliers.Add(entity));
            listeProspect.ForEach(entity => context.Prospects.Add(entity));
            */
            listCustomerFamily.ForEach(entity => context.CustomerFamilies.Add(entity));
            listSupplierFamily.ForEach(entity => context.SupplierFamilies.Add(entity));
            listProspectFamily.ForEach(entity => context.ProspectFamilies.Add(entity));

        }
    }
}
