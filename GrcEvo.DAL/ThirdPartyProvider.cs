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
        Utils utils = new Utils();

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
        /// /// <param name="type">Type de tiers (CL, FR, PP)</param>
        /// <returns></returns>
        public int NextCode(string type)
        {
            int lastCode = 0;
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var query = (from t in context.ThirdParties
                                   where t.PrefixCode == type
                                   orderby t.NumberCode descending
                                   select t).Take(1);
                
                foreach (var result in query)
                {
                    lastCode = result.NumberCode;
                }
            }
            return lastCode + 1;
        }

        /// <summary>
        /// Recupère les entités dont le type est passé en paramètre.
        /// </summary>
        /// <param name="type">Type de tiers (CL, FR, PP)</param>
        /// <returns>L'entité si elle existe, sinon NULL</returns>
        public List<EntityThirdParty> getThirdPartyByType(string type)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var result = (from t in context.ThirdParties
                                               where t.PrefixCode == type
                                               orderby t.ID ascending
                                               select t);
                return result.ToList();
            }
        }

        /// <summary>
        /// Compte tous les tiers de la base.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Compte le nombre de tiers en fonction du type.
        /// </summary>
        /// <param name="type">Type de tiers (CL, FR, PP)</param>
        /// <returns></returns>
        public int Count(string type)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var result = (from t in context.ThirdParties
                                         where t.PrefixCode == type
                                         orderby t.ID ascending
                                         select t);
                return result.Count();
            }
        }

        /// <summary>
        /// Recherche les tiers en fonction du nom.
        /// </summary>
        /// <returns>La Liste des entités .</returns>
        public List<EntityThirdParty> SearchByName(string search, string type)
        {
            string filter = utils.RemoveDiacritics(search).ToUpper();

            using (GrcEvoContext context = new GrcEvoContext())
            {
                var result = (from t in context.ThirdParties
                                         where t.Name.ToUpper().Contains(filter) && t.PrefixCode == type
                                         orderby t.Name ascending
                                         select t);
                return result.ToList();
            }
        }
    }
}
