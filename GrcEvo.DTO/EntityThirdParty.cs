using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrcEvo.DTO
{
    public class EntityThirdParty
    {
        public int ID { get; set; }
        public string PrefixCode { get; set; }
        public int NumberCode { get; set; }
        public string Company { get; set; }
        public string Civility { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string Adress3 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string GsmNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        /*
        public override string ToString()
        {
            return String.Concat("Je suis un tiers ", PrefixCode, " Genre ", Civility, " de code ", NumberCode, " et ID ", ID);
        }
        */
    }


}
