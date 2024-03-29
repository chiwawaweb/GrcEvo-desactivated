﻿using System;
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
            List<EntityThirdParty> listThirdParty = new List<EntityThirdParty>();
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "CL", NumberCode = 91, Civility = "MLLE", Name="BROCHARD SYLVIE", Adress1 = "RUE DES PRES", Adress2 = "CHEZ M. PIERRET", Adress3 = "LIEU DIT LES MOUETTES", PostalCode="57650", City="FONTOY", Country="FRANCE" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "CL", NumberCode = 95, Civility = "M.", Name = "DUMONT ANTOINE", Adress1 = "RUE DES MARCHANDS", Blocked=true });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "PP", NumberCode = 107, Civility = "SA", Name = "SOCIETE GENERALE", Adress1 = "RUE DU PARC" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "PP", NumberCode = 108, Civility = "MME", Name = "ARMAND GINETTE", Adress1 = "AVENUE JOFFRE" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "FR", NumberCode = 543, Civility = "SARL", Name = "ETOILES ET CIE", Adress1 = "RUE DES MARCHANDS" });
            listThirdParty.Add(new EntityThirdParty { PrefixCode = "FR", NumberCode = 547, Civility = "", Name = "TROIS FLEURS", Adress1 = "BD RASPAIL" });

            List<EntityCountry> listCountry = new List<EntityCountry>();
            listCountry.Add(new EntityCountry { Name = "FRANCE", Abbreviation = "FR" });
            listCountry.Add(new EntityCountry { Name = "BELGIQUE", Abbreviation = "BE" });
            listCountry.Add(new EntityCountry { Name = "LUXEMBOURG", Abbreviation = "LU" });
            listCountry.Add(new EntityCountry { Name = "ALLEMAGNE", Abbreviation = "DE" });
            listCountry.Add(new EntityCountry { Name = "MONACO", Abbreviation = "DE" });

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
            listItem.Add(new EntityItem { Type = "BIEN", Brand = "SONY", PrefixCode = "AR", NumberCode = 101, Family = "CHEMISE", ShortDescription = "CHEMISE HOMME LYS T.44", Stock = 7, Ean = "1295476321025", PricePurchaseET=1.25, PriceSaleET=3.5 });
            listItem.Add(new EntityItem { Type = "BIEN", Brand = "SAMSUNG", PrefixCode = "AR", NumberCode = 102, Family = "CHEMISE", ShortDescription = "CHEMISE HOMME LYS T.42", Stock = 12 });
            listItem.Add(new EntityItem { Type = "BIEN", Brand = "SONY", PrefixCode = "AR", NumberCode = 104, Family = "CRAVATTE", ShortDescription = "CRAVATTE BLEU/NOIRS", Stock = 3, Blocked = true });
            listItem.Add(new EntityItem { Type = "BIEN", Brand = "LEXMARK", PrefixCode = "AR", NumberCode = 108, Family = "BOUTON", ShortDescription = "BOUTONS MANCHETTE OR CHEVAL", Stock = 9 });
            listItem.Add(new EntityItem { Type = "BIEN", Brand = "BEKO", PrefixCode = "AR", NumberCode = 108, Family = "BOUTON", ShortDescription = "BOUTONS MANCHETTE ARGENT BOEUF", Stock = 29 });
            listItem.Add(new EntityItem { Type = "SERVICE", Brand = "",PrefixCode = "AR", NumberCode = 109, Family = "TRANSPORT", ShortDescription = "COLISSIMO SUIVI" });
            listItem.Add(new EntityItem { Type = "SERVICE", Brand = "",PrefixCode = "AR", NumberCode = 111, Family = "MAIN D'OEUVRE", ShortDescription = "INTERVENTION 15 MIN." });

            /* Remplissage des tables */
            listThirdParty.ForEach(entity => context.ThirdParties.Add(entity));
            listCountry.ForEach(entity => context.Countries.Add(entity));
            listThirdPartyFamily.ForEach(entity => context.ThirdPartyFamilies.Add(entity));
            listItem.ForEach(entity => context.Items.Add(entity));
            
        }
    }
}
