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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();
            tssInfos.Text = "Nombre de tiers dans la base : " + thirdPartyProvider.CountAll().ToString();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Library.Fixtures fixtures = new Library.Fixtures();
            MessageBox.Show("ok");
        }

        private void OpenThirdPartyList(string type)
        {
            ThirdParties frm = new ThirdParties(type);
            frm.ShowDialog();
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
