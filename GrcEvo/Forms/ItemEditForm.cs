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
        private string itemAction;
        private string formTitle = "Fiche article";
        private int _id;
        private int itemNumberCode;

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

            itemAction = action;

            switch (itemAction)
            {
                /* Cas d'une création */
                case "C":
                    itemNumberCode = itemProvider.NextCode();
                    NewItem();

                    break;
                /* Cas d'une modification */
                case "U":
                    itemNumberCode = itemProvider.getItemById(_id).NumberCode;
                    LoadItem();
                    break;
            }

            /* Barre titre du formulaire */
            this.Text = formTitle;

            /* ComboBox des marques */
            List<string> Brands = new List<string>(itemProvider.GetBrands());

            foreach (var brand in Brands)
            {
                cbxBrand.Items.Add("TOTO");
            }
            

        }

        private void ItemEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {

        }

        /// <summary>
        /// Chargement de la fiche tiers en mode création
        /// </summary>
        private void NewItem()
        {
            EntityItem entityItem = new EntityItem();
            formTitle += " (Création)";
            lblCode.Text = "AR" + itemNumberCode.ToString("00000");
        }

        private void LoadItem()
        {
            formTitle += " (Modification)";
            lblCode.Text = itemProvider.getItemById(_id).PrefixCode + itemNumberCode.ToString("00000");

            txtShortDescription.Text = itemProvider.getItemById(_id).ShortDescription;
        }
    }
}
