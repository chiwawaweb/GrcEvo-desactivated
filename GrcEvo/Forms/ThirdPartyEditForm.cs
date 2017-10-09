using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrcEvo.DTO;
using GrcEvo.DAL;
using GrcEvo.Library;

namespace GrcEvo.Forms
{
    public partial class ThirdPartyEditForm : Form
    {
        private string thirdPartyAction;
        private string thirdPartyType;
        private string formTitle;
        
        public ThirdPartyEditForm(string type, string action)
        {
            InitializeComponent();
            thirdPartyAction = action;
            thirdPartyType = type;

            formTitle = "Fiche ";
            switch (thirdPartyType)
            {
                case "CL":
                    formTitle += "Client";
                    break;

                case "FR":
                    formTitle += "Fournisseur";
                    break;

                case "PP":
                    formTitle += "Prospect";
                    break;
            }

            switch (thirdPartyAction)
            {
                case "C":
                    formTitle += " (Création)";
                    break;
                case "U":
                    formTitle += " (Modification)";
                    break;
            }

            this.Text = formTitle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            lblAction.Text = thirdPartyType;
        }

        private void Save()
        {
            /* Vérifie la saisie */

            EntityCustomer ec = new EntityCustomer();
            ThirdPartyProvider tpp = new ThirdPartyProvider();

            
            ec.Civility = cbxCivility.Text;
            ec.Name = txtName.Text;
            

            tpp.Create(ec);
        }

    }
}
