using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

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

        /// <summary>
        /// Mettre à jour dans la BDD l'entité passée en paramètre
        /// </summary>
        /// <param name="ThirdParty">L'entité à mettre à jour dans la BDD</param>
        public void Update(EntityThirdParty ThirdParty)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    context.ThirdParties.Attach(ThirdParty);
                    // Très important, signifier le fait que l'entité a été modifiée.
                    context.Entry<EntityThirdParty>(ThirdParty).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Recupère l'entité dont l'ID est passé en paramètre
        /// </summary>
        /// <param name="ID">ID(clé primaire) de l'entité à retrouver.</param>
        /// <returns>L'entité si elle existe, sinon NULL</returns>
        public EntityThirdParty getThirdPartyById(int ID)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.ThirdParties.Find(ID);
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Renvoie le prochain code du tiers selon son préfixe
        /// </summary>
        /// /// <param name="prefixCode">Préfixe du tiers (CL, FR, PP,...)</param>
        /// <returns></returns>
        public int NextCode(string prefixCode)
        {
            int nextCode = 0;
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var nextCodeQuery = (from EntityThirdParty in context.ThirdParties
                                   where EntityThirdParty.PrefixCode == prefixCode
                                   orderby EntityThirdParty.NumberCode descending
                                   select EntityThirdParty).Take(1);
                
                foreach (var result in nextCodeQuery)
                {
                    nextCode = result.NumberCode;
                }
            }
            return nextCode + 1;
        }

        /// <summary>
        /// Recupère les entités dont le type est passé en paramètre
        /// </summary>
        /// <param name="type"></param>
        /// <returns>L'entité si elle existe, sinon NULL</returns>
        public List<EntityThirdParty> getThirdPartyByType(string type)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var thirdPartiesQuery = (from EntityThirdParty in context.ThirdParties
                                               where EntityThirdParty.PrefixCode == type
                                               orderby EntityThirdParty.ID ascending
                                               select EntityThirdParty);

                return thirdPartiesQuery.ToList();
            }
        }

        public int CountAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.ThirdParties.Count();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
