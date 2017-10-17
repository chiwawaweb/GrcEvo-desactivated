using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrcEvo.DTO;
using GrcEvo.DAL;
using System.Windows.Forms;

namespace GrcEvo.Forms
{
    public partial class ItemEditForm : Form
    {
        private int _id;

        ItemsForm _owner;

        ItemProvider itemProvider = new ItemProvider();
        ItemFamilyProvider itemFamilyProvider = new ItemFamilyProvider();
        Utils utils = new Utils();

        public ItemEditForm(ItemsForm owner, string action, int ID = 0)
        {
            _owner = owner;
            _id = ID;
            FormClosed += new FormClosedEventHandler(ItemEditForm_FormClosed);

            InitializeComponent();
        }

        private void ItemEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

        }
    }
}
