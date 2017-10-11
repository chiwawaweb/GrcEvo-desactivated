using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrcEvo.Forms
{
    public partial class ThirdParties : Form
    {
        private string _type;

        public ThirdParties(string type)
        {
            InitializeComponent();
            _type = type;

            /* A FAIRE : Centrer la fenêtre */
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
