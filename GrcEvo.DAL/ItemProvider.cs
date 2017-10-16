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
