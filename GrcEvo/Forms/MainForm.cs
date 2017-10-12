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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenThirdPartyList(string type)
        {
            ThirdParties frm = new ThirdParties(type);
            frm.MdiParent = this;
            frm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenThirdPartyList("CL");
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenThirdPartyList("FR");
        }

        private void prospectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenThirdPartyList("PP");
        }

        private void tsbCustomers_Click(object sender, EventArgs e)
        {
            OpenThirdPartyList("CL");
        }
    }
}
