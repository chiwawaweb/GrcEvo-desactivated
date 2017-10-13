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
using System.Data.Entity;
namespace GrcEvo.Forms
{
    public partial class ThirdPartyEditForm : Form
    {
        private string thirdPartyAction;
        private string thirdPartyType;
        private string formTitle = "Fiche ";
        ThirdPartiesForm _owner;

        ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();
        CivilityProvider civilityProvider = new CivilityProvider();
        ThirdPartyFamilyProvider familyProvider = new ThirdPartyFamilyProvider();

        public ThirdPartyEditForm(ThirdPartiesForm owner, string type, string action)
        {
            _owner = owner;
            FormClosed += new FormClosedEventHandler(ThirdPartyEditForm_FormClosed);

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

        /// <summary>
        /// Enregistre la fiche tiers dans la base de données
        /// </summary>
        private void Save()
        {
            /* Vérifie la saisie */


            /* Prépare les données avant enregistrement */
            EntityThirdParty entityThirdParty = new EntityThirdParty();
            ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();
            entityThirdParty.PrefixCode = thirdPartyType;
            entityThirdParty.NumberCode = thirdPartyProvider.NextCode(thirdPartyType);
            entityThirdParty.Civility = cbxCivility.Text;
            entityThirdParty.Name = txtName.Text;
            entityThirdParty.Blocked = chkBlocked.Checked;
            

            thirdPartyProvider.Create(entityThirdParty);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseWithConfirmation();
        }

        private void CloseWithConfirmation()
        {
            DialogResult result = MessageBox.Show("Êtes-vous certains de vouloir fermer la fiche ? Toute modification non enregistrée sera perdue.", 
                "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ThirdPartyEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }
    }
}
