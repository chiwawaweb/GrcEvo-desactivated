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
    }
}
