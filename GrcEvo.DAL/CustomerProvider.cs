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

        public List<EntityCustomer> getAll()
        {
            using (GrcEvoContext context = new GrcEvoContext())
            {
                return context.Customers.ToList();
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
