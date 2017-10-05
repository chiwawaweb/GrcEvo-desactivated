using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;

namespace GrcEvo.DAL
{
    public class TiersProvider
    {
        public TiersProvider()
        {

        }

        /// <summary>
        /// Recupère la liste de toutes les entités
        /// </summary>
        /// <returns>La Liste de toutes les entités</returns>
        public List<EntityTiers> getAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Tierss.ToList<EntityTiers>();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Créer une entité de type Tiers dans la BDD
        /// </summary>
        /// <param name="Tiers"></param>
        public void Create(EntityTiers Tiers)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    context.Tierss.Add(Tiers);
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
