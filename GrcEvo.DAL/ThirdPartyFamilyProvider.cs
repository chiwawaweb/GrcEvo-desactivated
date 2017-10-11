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
        /// <param name="type">type des entités à retrouver.</param>
        /// <returns>L'entité si elle existe, sinon NULL</returns>
        public EntityThirdPartyFamily getThirdPartyFamilyByTypee(string type)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.ThirdPartyFamilies.Find(type);
                }
                catch
                {
                    throw;
                }
            }
        }

        public string[] getThirdPartyFamilyByType(string type)
        {
            string[] thirdPartyFamilies;
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var thirdPartyFamiliesQuery = (from EntityThirdPartyFamily in context.ThirdPartyFamilies
                                     where EntityThirdPartyFamily.Type == type
                                     orderby EntityThirdPartyFamily.ID ascending
                                     select EntityThirdPartyFamily);

                foreach (var result in thirdPartyFamiliesQuery)
                {
                    thirdPartyFamilies[] += result.Name;
                }
            }
            return thirdPartyFamilies;
        }
    }
}
