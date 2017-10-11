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
    }
}
