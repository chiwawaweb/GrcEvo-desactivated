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
    }
}
