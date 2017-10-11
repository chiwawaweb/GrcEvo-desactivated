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
        private string formTitle = "Fiche ";

        ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();
        CivilityProvider civilityProvider = new CivilityProvider();
        ThirdPartyFamilyProvider familyProvider = new ThirdPartyFamilyProvider();

        public ThirdPartyEditForm(string type, string action)
        {
            InitializeComponent();
            thirdPartyAction = action;
            thirdPartyType = type;

            switch (thirdPartyType)
            {
                case "CL":
                    formTitle += "Client";
                    chkBlocked.Visible = true;
                    break;

                case "FR":
                    formTitle += "Fournisseur";
                    chkBlocked.Visible = false;
                    break;

                case "PP":
                    formTitle += "Prospect";
                    chkBlocked.Visible = false;
                    break;
            }

            switch (thirdPartyAction)
            {
                /* Cas d'une création */
                case "C":
                    NewThirdParty();

                    break;
                case "U":
                    UpdateThirdParty();
                    break;
            }

            /* Barre titre du formulaire */
            this.Text = formTitle;

            /* ComboBox des civilités */
            foreach (var civility in civilityProvider.getAll())
            {
                cbxCivility.Items.Add(civility.Name);
            }

            /* Combobox des familles */
            foreach (var family in familyProvider.getThirdPartyFamilyByType(thirdPartyType))
            {
                cbxFamily.Items.Add(family.Name);
            }

            
        }

        /// <summary>
        /// Chargement de la fiche tiers en mode création
        /// </summary>
        private void NewThirdParty()
        {
            formTitle += " (Création)";
            lblCode.Text = thirdPartyType + thirdPartyProvider.NextCode(thirdPartyType).ToString("00000");
        }

        /// <summary>
        /// Chargement de la fiche en mode mise à jour
        /// </summary>
        private void UpdateThirdParty()
        {
            formTitle += " (Modification)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Enregistre la fiche tiers dans la base de données
        /// </summary>
        private void Save()
        {
            /* Vérifie la saisie */

            EntityCustomer ec = new EntityCustomer();
            ThirdPartyProvider tpp = new ThirdPartyProvider();

            
            ec.Civility = cbxCivility.Text;
            ec.Name = txtName.Text;
            ec.Blocked = chkBlocked.Checked;
            

            tpp.Create(ec);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
