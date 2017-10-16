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
    public partial class ItemsForm : Form
    {
        ItemProvider itemProvider = new ItemProvider();

        public ItemsForm()
        {
            InitializeComponent();
        }

        public void CreateTable(List<EntityThirdParty> list)
        {
            /* Initialisation du Datagridview */
            dgvItems.Rows.Clear();
            dgvItems.Columns.Clear();

            /* Mise en forme Datagridview */
            dgvItems.Size = new Size(1064, 478);

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.Visible = false;
        }


        public void RefreshData()
        {
            List<EntityItem> list;
            list = EntityItem.getAll();

            CreateTable(list);
        }




        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
