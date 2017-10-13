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
    public partial class ThirdPartiesForm : Form
    {
        private string _type;

        
        
        public ThirdPartiesForm(string type)
        {
            InitializeComponent();
            _type = type;
            RefreshData();
        }

        public void RefreshData()
        {
            ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();

            dgvThirdParties.DataSource = thirdPartyProvider.getThirdPartyByType(_type);
            dgvThirdParties.Columns["ID"].Visible = false;
            dgvThirdParties.Columns["CreatedAt"].Visible = false;
            dgvThirdParties.Columns["Civility"].HeaderText = "Civilité";
            dgvThirdParties.Columns["Name"].HeaderText = "Nom";
            dgvThirdParties.Columns["Blocked"].HeaderText = "Bloqué";
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ThirdPartyEditForm frm = new ThirdPartyEditForm(this, _type, "C");
            frm.ShowDialog();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThirdPartiesForm_Enter(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
