using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;

namespace GrcEvo.DAL
{
    public class ThirdPartyProvider
    {
        public ThirdPartyProvider()
        {

        }

        /// <summary>
        /// Recupère la liste de toutes les entités
        /// </summary>
        /// <returns>La Liste de toutes les entités</returns>
        public List<EntityThirdParty> getAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.ThirdParties.ToList<EntityThirdParty>();
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
        /// <param name="ThirdParty"></param>
        public void Create(EntityThirdParty ThirdParty)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    context.ThirdParties.Add(ThirdParty);
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
