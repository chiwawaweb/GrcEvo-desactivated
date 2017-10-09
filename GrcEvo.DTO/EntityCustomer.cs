using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrcEvo.DTO
{
    public class EntityCustomer : EntityThirdParty
    {
        public string VatNumbber { get; set; }
        public bool Blocked { get; set; }

        /*
        public override string ToString()
        {
            return String.Concat("Je suis un ", PrefixCode, " Genre ", Civility, " de code ", NumberCode, " et ID ", ID);
        }
        */

        public EntityCustomer()
        {
            PrefixCode = "CL";
        }
    }
}
