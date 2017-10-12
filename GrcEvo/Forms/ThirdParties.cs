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

namespace GrcEvo.Forms
{
    public partial class ThirdParties : Form
    {
        private string _type;

        ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();

        public ThirdParties(string type)
        {
            InitializeComponent();
            _type = type;

            /* A FAIRE : Centrer la fenêtre */
            dgvThirdParties.DataSource = thirdPartyProvider.getThirdPartyByType(type);

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ThirdPartyEditForm frm = new ThirdPartyEditForm(_type,"C");
            frm.ShowDialog();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
