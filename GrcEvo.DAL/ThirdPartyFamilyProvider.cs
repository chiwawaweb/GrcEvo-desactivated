using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using System.Data.Entity;

namespace GrcEvo.DAL
{
    public class ThirdPartyFamilyProvider
    {
        /// <summary>
        /// Recupère les entités dont le type est passé en paramètre
        /// </summary>
        /// <param name="type"></param>
        /// <returns>L'entité si elle existe, sinon NULL</returns>
        public List<EntityThirdPartyFamily> getThirdPartyFamilyByType(string type)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var thirdPartyFamiliesQuery = (from EntityThirdPartyFamily in context.ThirdPartyFamilies
                                     where EntityThirdPartyFamily.Type == type
                                     orderby EntityThirdPartyFamily.ID ascending
                                     select EntityThirdPartyFamily);

                return thirdPartyFamiliesQuery.ToList();
            }
        }
    }
}
