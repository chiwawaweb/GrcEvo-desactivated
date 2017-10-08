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
        public ThirdPartyEditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        public string Company()
        {
            return txtCompany.Text;
        }

        private void Save()
        {
            /* Vérifie la saisie */

            EntityCustomer ec = new EntityCustomer();
            ThirdPartyProvider tpp = new ThirdPartyProvider();

            ec.Company = txtCompany.Text;
            ec.Civility = cbxCivility.Text;
            ec.LastName = txtLastName.Text;
            ec.FirstName = txtFirstName.Text;

            tpp.Create(ec);
        }

    }
}
