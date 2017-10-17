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
                    itemNumberCode = itemProvider.GetItemById(_id).NumberCode;
                    LoadItem();
                    break;
            }

            /* Barre titre du formulaire */
            this.Text = formTitle;

            /* ComboBox des Type */
            cbxType.Items.Add("BIEN");
            cbxType.Items.Add("SERVICE");

            /* ComboBox des marques */
            List<string> Brands = new List<string>(itemProvider.GetBrands());
            foreach (var brand in Brands)
            {
                cbxBrand.Items.Add(brand);
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
        /// Chargement de la fiche article en mode création.
        /// </summary>
        private void NewItem()
        {
            EntityItem entityItem = new EntityItem();
            formTitle += " (Création)";
            lblCode.Text = "AR" + itemNumberCode.ToString("00000");
        }

        /// <summary>
        /// Chargement de la fiche article en mode modification.
        /// </summary>
        private void LoadItem()
        {
            formTitle += " (Modification)";
            lblCode.Text = itemProvider.GetItemById(_id).PrefixCode + itemNumberCode.ToString("00000");
            cbxType.Text = itemProvider.GetItemById(_id).Type;
            
            txtShortDescription.Text = itemProvider.GetItemById(_id).ShortDescription;
            cbxBrand.Text = itemProvider.GetItemById(_id).Brand;
        }
    }
}
