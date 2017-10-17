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

            using (GrcEvoContext context = new GrcEvoContext())
            {
                var query = (
                    from item in context.Items
                    group item by item.Brand into itemGroup
                    select new { FirstLetter = itemGroup.Key, Names = itemGroup });


                foreach (var brand in query)
                {
                    Console.WriteLine("Last names that start with the letter '{0}':", brand.FirstLetter);
                    
                }

               
            }
        }

        private void RefreshData()
        {
            ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();
            ItemProvider itemProvider = new ItemProvider();
            /* temporaire */
            tssInfos.Text = "Clients : " + thirdPartyProvider.Count("CL").ToString();
            tssInfos.Text += " | Fournisseurs : " + thirdPartyProvider.Count("FR").ToString();
            tssInfos.Text += " | Prospects : " + thirdPartyProvider.Count("PP").ToString();
            tssInfos.Text += " | Articles : " + itemProvider.CountAll().ToString();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OpenThirdPartyList(string type)
        {
            ThirdPartiesForm frm = new ThirdPartiesForm(type);
            frm.ShowDialog();
        }

        private void OpenItemList()
        {
            ItemsForm frm = new ItemsForm();
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

        private void MainForm_Activated(object sender, EventArgs e)
        {
            /* temporaire */
            RefreshData();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbItems_Click(object sender, EventArgs e)
        {
            OpenItemList();
        }
    }
}
