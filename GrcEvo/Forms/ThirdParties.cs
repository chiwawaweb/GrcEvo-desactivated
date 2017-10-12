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

            dgvThirdParties.DataSource = thirdPartyProvider.getThirdPartyByType(type);
            dgvThirdParties.Columns["ID"].Visible = false;
            dgvThirdParties.Columns["CreatedAt"].Visible = false;
            dgvThirdParties.Columns["Civility"].HeaderText = "Civilité";
            dgvThirdParties.Columns["Name"].HeaderText = "Nom";
            dgvThirdParties.Columns["Blocked"].HeaderText = "Bloqué";



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
