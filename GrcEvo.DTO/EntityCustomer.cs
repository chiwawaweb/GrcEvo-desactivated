using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrcEvo.DTO
{
    public class EntityCustomer : EntityTiers
    {
        public string VatNumbber { get; set; }

        public override string ToString()
        {
            return String.Concat("Je suis un client ", Civility, " de code ", NumberCode, " et ID ", ID);
        }

        public EntityCustomer()
        {
            PrefixCode = "CL";
        }
    }
}
