
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
            EntityThirdParty newThirdParty = new EntityThirdParty();
            ThirdPartyProvider tpp = new ThirdPartyProvider();

            newThirdParty.Company = txtCompany.Text;
            tpp.Create(newThirdParty);
        }
    }
}
