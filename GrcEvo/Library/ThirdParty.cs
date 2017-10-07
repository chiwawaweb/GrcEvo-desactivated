
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using GrcEvo.DAL;

namespace GrcEvo.Library
{
    public class ThirdParty : Forms.CustomerEditForm
    {
        public void Create()
        {
            EntityCustomer newThirdParty = new EntityCustomer();
            ThirdPartyProvider tpp = new ThirdPartyProvider();

            newThirdParty.Company = txtCompany.Text.ToString();
            newThirdParty.Adress1 = "adresse1";
            tpp.Create(newThirdParty);
        }
    }
}
