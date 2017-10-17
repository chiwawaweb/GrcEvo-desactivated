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
        public List<EntityItem> GetAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Items.ToList();
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

        /// <summary>
        /// Renvoie le prochain code de l'article
        /// </summary>
        public int NextCode()
        {
            int lastCode = 0;
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var query = (from t in context.Items
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
        /// Recupère l'entité dont l'ID est passé en paramètre
        /// </summary>
        /// <param name="ID">ID(clé primaire) de l'entité à retrouver.</param>
        /// <returns>L'entité si elle existe, sinon NULL</returns>
        public EntityItem GetItemById(int ID)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Items.Find(ID);
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Recupère les marques des différents articles de la base
        /// </summary>
        public List<string> GetBrands()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                var result = (from item in context.Items
                               group item by item.Brand into ItemGroup
                               orderby ItemGroup.Key
                               select ItemGroup.Key).ToList();
                return result;
            }
        }
    }
}
