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
            EntityCustomer customer1 = context.Customers.Add(new EntityCustomer());

            List<EntityCustomer> listeCustomer = new List < EntityCustomer>();
            listeCustomer.Add(new EntityCustomer { NumberCode = 98, Civility = "Mlle", PrefixCode = "ZZ" });
            listeCustomer.Add(new EntityCustomer { NumberCode = 99, Civility = "Mzle", PrefixCode = "ZX" });

            listeCustomer.ForEach(entity => context.Customers.Add(entity));
            /*
            EntityGarage garage = context.Garage.Add(new EntityGarage());

            List<EntityHarley> listeHarley = new List<EntityHarley>();
            listeHarley.Add(new EntityHarley { Couleur = "Noire", Modele = "Fatbob", Reservoir = 15, Garage = garage });
            listeHarley.Add(new EntityHarley { Couleur = "Blanche", Modele = "Road King", Reservoir = 30, Garage = garage });
            listeHarley.Add(new EntityHarley { Couleur = "Noire", Modele = "883 Iron", Reservoir = 12, Garage = garage });

            List<EntityFerrari> listeFerrari = new List<EntityFerrari>();
            listeFerrari.Add(new EntityFerrari { Couleur = "Rouge", Modele = "Enzo", Garage = garage });
            listeFerrari.Add(new EntityFerrari { Couleur = "Bleue", Garage = garage });

            listeHarley.ForEach(entity => context.Harleys.Add(entity));
            listeFerrari.ForEach(entity => context.Ferraris.Add(entity));
            */
        }
    }
}
