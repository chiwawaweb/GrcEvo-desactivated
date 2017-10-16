using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using System.Data.Entity;

namespace GrcEvo.DAL
{
    public class ItemProvider
    {
        Utils utils = new Utils();

        public ItemProvider()
        {

        }

        /// <summary>
        /// Recupère la liste de toutes les entités
        /// </summary>
        /// <returns>La Liste de toutes les entités</returns>
        public List<EntityItem> getAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Items.ToList<EntityItem>();
                }
                catch
                {
                    throw;
                }
            }
        }


        /// <summary>
        /// Créer une entité de type Article dans la BDD
        /// </summary>
        /// <param name="Item"></param>
        public void Create(EntityItem Item)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    context.Items.Add(Item);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Compte tous les articles de la base.
        /// </summary>
        /// <returns></returns>
        public int CountAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Items.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Recherche les articles en fonction de la description.
        /// </summary>
        /// <returns>La Liste des entités .</returns>
        public List<EntityItem> SearchByDescription(string search)
        {
            string filter = utils.RemoveDiacritics(search).ToUpper();

            using (GrcEvoContext context = new GrcEvoContext())
            {
                var result = (from t in context.Items
                              where t.ShortDescription.ToUpper().Contains(filter)
                              orderby t.ShortDescription ascending
                              select t);
                return result.ToList();
            }
        }
    }
}
