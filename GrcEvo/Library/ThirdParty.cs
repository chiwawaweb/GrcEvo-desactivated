
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

            EntitySupplier newSupplier = new EntitySupplier();
            newSupplier.Company = "toto";

            tpp.Create(newThirdParty);
            tpp.Create(newSupplier);

           

            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ThirdParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Name = "ThirdParty";
            this.ResumeLayout(false);

        }
    }
}
