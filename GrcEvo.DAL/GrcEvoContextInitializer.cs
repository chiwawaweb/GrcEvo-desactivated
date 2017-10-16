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
            listCivility.Add(new EntityCivility { Name = "M." });
            listCivility.Add(new EntityCivility { Name = "MME" });
            listCivility.Add(new EntityCivility { Name = "MLLE" });
            listCivility.Add(new EntityCivility { Name = "DR" });
            listCivility.Add(new EntityCivility { Name = "ME" });
            listCivility.Add(new EntityCivility { Name = "SA" });
            listCivility.Add(new EntityCivility { Name = "SARL" });
            listCivility.Add(new EntityCivility { Name = "SCI" });

            List<EntityThirdParty> listThirdParty = new List<EntityThirdParty>();
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "CL", NumberCode = 91, Civility = "MLLE", Name="BROCHARD SYLVIE", Adress1 = "RUE DES PRES", Adress2 = "CHEZ M. PIERRET", Adress3 = "LIEU DIT LES MOUETTES", PostalCode="57650", City="FONTOY", Country="FRANCE" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "CL", NumberCode = 95, Civility = "M.", Name = "DUMONT ANTOINE", Adress1 = "RUE DES MARCHANDS", Blocked=true });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "PP", NumberCode = 107, Civility = "SA", Name = "SOCIETE GENERALE", Adress1 = "RUE DU PARC" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "PP", NumberCode = 108, Civility = "MME", Name = "ARMAND GINETTE", Adress1 = "AVENUE JOFFRE" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "FR", NumberCode = 543, Civility = "SARL", Name = "ETOILES ET CIE", Adress1 = "RUE DES MARCHANDS" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "FR", NumberCode = 547, Name = "TROIS FLEURS", Adress1 = "BD RASPAIL" });

            List<EntityCountry> listCountry = new List<EntityCountry>();
            listCountry.Add(new EntityCountry { Name = "FRANCE", Abbreviation = "FR" });
            listCountry.Add(new EntityCountry { Name = "BELGIQUE", Abbreviation = "BE" });
            listCountry.Add(new EntityCountry { Name = "LUXEMBOURG", Abbreviation = "LU" });
            listCountry.Add(new EntityCountry { Name = "ALLEMAGNE", Abbreviation = "DE" });

            List<EntityThirdPartyFamily> listThirdPartyFamily = new List<EntityThirdPartyFamily>();
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "PARTICULIER", Abbreviation = "PA", Type = "CL" });
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "COMITE D'ENTREPRISE", Abbreviation = "CE", Type = "CL" });
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "SOCIETE", Abbreviation = "SO", Type = "CL" });
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "ENTREPRISE", Abbreviation = "EN", Type = "FR" });
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "ASSOCIATION", Abbreviation = "AS", Type = "FR" });
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "PARTICULIER", Abbreviation = "PA", Type = "PP" });
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "COMITE D'ENTREPRISE", Abbreviation = "CE", Type = "PP" });
            listThirdPartyFamily.Add(new EntityThirdPartyFamily { Name = "SOCIETE", Abbreviation = "SO", Type = "PP" });

            List<EntityItem> listItem = new List<EntityItem>();
            listItem.Add(new EntityItem { PrefixCode = "AR", NumberCode = 101, Family = "CHEMISE", ShortDescription = "CHEMISE HOMME LYS T.44", Stock = 7 });
            listItem.Add(new EntityItem { PrefixCode = "AR", NumberCode = 101, Family = "CHEMISE", ShortDescription = "CHEMISE HOMME LYS T.42", Stock = 12 });
            listItem.Add(new EntityItem { PrefixCode = "AR", NumberCode = 101, Family = "CRAVATTE", ShortDescription = "CRAVATTE BLEU/NOIRS", Stock = 3 });
            listItem.Add(new EntityItem { PrefixCode = "AR", NumberCode = 101, Family = "BOUTON", ShortDescription = "BOUTONS MANCHETTE OR CHEVAL", Stock = 9 });


            listCivility.ForEach(entity => context.Civilities.Add(entity));
            listThirdParty.ForEach(entity => context.ThirdParties.Add(entity));
            listCountry.ForEach(entity => context.Countries.Add(entity));
            listThirdPartyFamily.ForEach(entity => context.ThirdPartyFamilies.Add(entity));
            listItem.ForEach(entity => context.Items.Add(entity));
            
        }
    }
}
