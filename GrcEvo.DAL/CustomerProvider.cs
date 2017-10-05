using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using GrcEvo.DTO; 

namespace GrcEvo.DAL
{
    public class CustomerProvider
    {
        public CustomerProvider()
        {

        }

        /// <summary>
        /// Recupère la liste de toutes les entités
        /// </summary>
        /// <returns>La Liste de toutes les entités</returns>
        public List<EntityCustomer> getAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    return context.Customers.ToList<EntityCustomer>();
                }
                catch
                {
                    throw;
                }
            }
        }
        

        /// <summary>
        /// Créer une entité de type Customer dans la BDD
        /// </summary>
        /// <param name="Customer"></param>
        public void Create(EntityCustomer Customer)
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                try
                {
                    context.Customers.Add(Customer);
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
