using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;

namespace GrcEvo.DAL
{
    public class CountryProvider
    {
        public CountryProvider()
        {

        }

        /// <summary>
        /// Recupère la liste de toutes les entités
        /// </summary>
        /// <returns>La Liste de toutes les entités</returns>
        public List<EntityCountry> getAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Countries.ToList<EntityCountry>();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Créer une entité de type Country dans la BDD
        /// </summary>
        /// <param name="Country"></param>
        public void Create(EntityCountry Country)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    context.Countries.Add(Country);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
