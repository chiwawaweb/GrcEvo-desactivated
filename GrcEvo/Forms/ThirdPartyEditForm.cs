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
using System.Globalization;

namespace GrcEvo.Forms
{
    public partial class ThirdPartyEditForm : Form
    {
        private string thirdPartyAction;
        private string thirdPartyType;
        private string formTitle = "Fiche ";
        private int _id;
        private int thirdPartyNumberCode;

        ThirdPartiesForm _owner;
        
        ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();
        CivilityProvider civilityProvider = new CivilityProvider();
        ThirdPartyFamilyProvider familyProvider = new ThirdPartyFamilyProvider();
        CountryProvider countryProvider = new CountryProvider();
        Utils utils = new Utils();

        public ThirdPartyEditForm(ThirdPartiesForm owner, string type, string action, int ID = 0)
        {
            _owner = owner;
            _id = ID;
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
                    thirdPartyNumberCode = thirdPartyProvider.NextCode(thirdPartyType);
                    NewThirdParty();

                    break;
                case "U":
                    thirdPartyType = thirdPartyProvider.getThirdPartyById(_id).PrefixCode;
                    thirdPartyNumberCode = thirdPartyProvider.getThirdPartyById(_id).NumberCode;
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

            /* Combobox des pays */
            foreach (var country in countryProvider.getAll())
            {
                cbxCountry.Items.Add(country.Name);
            }
        }

        /// <summary>
        /// Chargement de la fiche tiers en mode création
        /// </summary>
        private void NewThirdParty()
        {
            EntityThirdParty entityThirdParty = new EntityThirdParty();
            formTitle += " (Création)";
            lblCode.Text = thirdPartyType + thirdPartyNumberCode.ToString("00000");
        }

        /// <summary>
        /// Chargement de la fiche en mode mise à jour
        /// </summary>
        private void UpdateThirdParty()
        {
            
            formTitle += " (Modification)";
            lblCode.Text = thirdPartyProvider.getThirdPartyById(_id).PrefixCode + thirdPartyNumberCode.ToString("00000");

            cbxCivility.Text = thirdPartyProvider.getThirdPartyById(_id).Civility;
            cbxFamily.Text = thirdPartyProvider.getThirdPartyById(_id).Family;
            txtName.Text = thirdPartyProvider.getThirdPartyById(_id).Name;
            chkBlocked.Checked = thirdPartyProvider.getThirdPartyById(_id).Blocked;
            txtAdress1.Text = thirdPartyProvider.getThirdPartyById(_id).Adress1;
            txtAdress2.Text = thirdPartyProvider.getThirdPartyById(_id).Adress2;
            txtAdress3.Text = thirdPartyProvider.getThirdPartyById(_id).Adress3;
            txtPostalCode.Text = thirdPartyProvider.getThirdPartyById(_id).PostalCode;
            txtCity.Text = thirdPartyProvider.getThirdPartyById(_id).City;
            cbxCountry.Text = thirdPartyProvider.getThirdPartyById(_id).Country;
        }

        /// <summary>
        /// Enregistre la fiche tiers dans la base de données
        /// </summary>
        private void Save()
        {
            /* Vérifie la saisie */
            string family = cbxFamily.Text.ToUpper().Trim();
            string civility = cbxCivility.Text.ToUpper().Trim();
            string name = txtName.Text.ToUpper().Trim();
            string adress1 = txtAdress1.Text.ToUpper().Trim();
            string adress2 = txtAdress2.Text.ToUpper().Trim();
            string adress3 = txtAdress3.Text.ToUpper().Trim();
            string postalCode = txtPostalCode.Text.ToUpper().Trim();
            string city = txtCity.Text.ToUpper().Trim();
            string country = cbxCountry.Text.ToUpper().Trim();
            string createdAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string updatedAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            bool errors = false;
            
            if (name.Length <= 2)
            {
                errors = true;
            }

            if (errors == false)
            {
                /* Aucune erreur trouvée, on enregistre */
                if (thirdPartyAction == "C")
                {
                    /* Création de la fiche */
                    EntityThirdParty entityThirdParty = new EntityThirdParty();
                    entityThirdParty.PrefixCode = thirdPartyType;
                    entityThirdParty.NumberCode = thirdPartyProvider.NextCode(thirdPartyType);
                    entityThirdParty.Family = utils.RemoveDiacritics(family);
                    entityThirdParty.Civility = utils.RemoveDiacritics(civility);
                    entityThirdParty.Name = utils.RemoveDiacritics(name);
                    entityThirdParty.Blocked = chkBlocked.Checked;
                    entityThirdParty.Adress1 = utils.RemoveDiacritics(adress1);
                    entityThirdParty.Adress2 = utils.RemoveDiacritics(adress2);
                    entityThirdParty.Adress3 = utils.RemoveDiacritics(adress3);
                    entityThirdParty.PostalCode = utils.RemoveDiacritics(postalCode);
                    entityThirdParty.City = utils.RemoveDiacritics(city);
                    entityThirdParty.Country = utils.RemoveDiacritics(country);
                    entityThirdParty.CreatedAt = createdAt;

                    /* Création de l'enregistrement */
                    thirdPartyProvider.Create(entityThirdParty);
                    
                }
                else if (thirdPartyAction=="U")
                {
                    /* Mise à jour de la fiche */
                    EntityThirdParty entityThirdParty = thirdPartyProvider.getThirdPartyById(_id);
                    entityThirdParty.Family = utils.RemoveDiacritics(family);
                    entityThirdParty.Civility = utils.RemoveDiacritics(civility);
                    entityThirdParty.Name = utils.RemoveDiacritics(name);
                    entityThirdParty.Blocked = chkBlocked.Checked;
                    entityThirdParty.Adress1 = utils.RemoveDiacritics(adress1);
                    entityThirdParty.Adress2 = utils.RemoveDiacritics(adress2);
                    entityThirdParty.Adress3 = utils.RemoveDiacritics(adress3);
                    entityThirdParty.PostalCode = utils.RemoveDiacritics(postalCode);
                    entityThirdParty.City = utils.RemoveDiacritics(city);
                    entityThirdParty.Country = utils.RemoveDiacritics(country);
                    entityThirdParty.UpdatedAt = updatedAt;
                    
                    /* Mise à jour de l'enregistrement */
                    thirdPartyProvider.Update(entityThirdParty);
                }
                Close();
            }
            else
            {
                /* Erreur(s) trouvée(s) */
                MessageBox.Show("Erreur(s) sans la saisie...");
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
            
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseWithConfirmation();
        }

        private void CloseWithConfirmation()
        {
            
            Close();
            
        }

        private void ThirdPartyEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }
    }
}
