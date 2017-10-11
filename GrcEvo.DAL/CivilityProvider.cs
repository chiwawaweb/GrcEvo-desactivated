using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;

namespace GrcEvo.DAL
{
    public class CivilityProvider
    {
        /// <summary>
        /// Recupère la liste de toutes les entités
        /// </summary>
        /// <returns>La Liste de toutes les entités</returns>
        public List<EntityCivility> getAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Civilities.ToList<EntityCivility>();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Créer une entité de type Civility dans la BDD
        /// </summary>
        /// <param name="Civility"></param>
        public void Create(EntityCivility Civility)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    context.Civilities.Add(Civility);
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
