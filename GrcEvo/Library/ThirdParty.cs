
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using GrcEvo.DAL;


namespace GrcEvo.Library
{
    public class ThirdParty
    {
        public void Create()
        {
            EntityCustomer newThirdParty = new EntityCustomer();
            ThirdPartyProvider tpp = new ThirdPartyProvider();

            

            //newThirdParty.Company = txtCompany.Text;
            newThirdParty.Adress1 = "adresse1";

            EntitySupplier newSupplier = new EntitySupplier();
            newSupplier.Company = "toto";

            tpp.Create(newThirdParty);
            //tpp.Create(newSupplier);

        }

        
    }
}
