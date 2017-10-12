using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using GrcEvo.DAL;
using System.Data.Entity;

namespace GrcEvo.Library
{
    public class Fixtures : DbContext
    {
        public Fixtures()
        {
            Database.SetInitializer(new GrcEvoContextInitializer());
        }

    }
}
