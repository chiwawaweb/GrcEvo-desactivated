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
        private string formTitle = "Fichier ";
        private string thirdPartyLabel;

        ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();

        public ThirdPartiesForm(string type)
        {
            InitializeComponent();

            this.Size = new Size (1080, 600);
            
            _type = type;

            switch (_type)
            {
                case "CL":
                    thirdPartyLabel = "clients";
                    break;

                case "FR":
                    thirdPartyLabel = "fournisseurs";
                    break;

                case "PP":
                    thirdPartyLabel = "prospects";
                    break;
            }
            this.Text = formTitle + thirdPartyLabel;

            
            RefreshData();
        }

        public void RefreshData()
        {
            /* Initialisation du Datagridview */
            dgvThirdParties.Rows.Clear();
            dgvThirdParties.Columns.Clear();

            /* Mise en forme Datagridview */
            dgvThirdParties.Size = new Size(1064, 478);

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.Visible = false;

            DataGridViewTextBoxColumn codeColumn = new DataGridViewTextBoxColumn();
            codeColumn.Name = "Code";
            codeColumn.HeaderText = "Code";
            codeColumn.Width = 80;
            codeColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            codeColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Nom";
            nameColumn.Width = 250;
            nameColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn adressColumn = new DataGridViewTextBoxColumn();
            adressColumn.Name = "Adress";
            adressColumn.HeaderText = "Adresse";
            adressColumn.Width = 250;
            adressColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn();
            cityColumn.Name = "City";
            cityColumn.HeaderText = "Ville";
            cityColumn.Width = 220;
            cityColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn countryColumn = new DataGridViewTextBoxColumn();
            countryColumn.Name = "Country";
            countryColumn.HeaderText = "Pays";
            countryColumn.Width = 130;
            countryColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewCheckBoxColumn blockedColumn = new DataGridViewCheckBoxColumn();
            blockedColumn.Name = "Blocked";
            blockedColumn.HeaderText = "Bloqué";
            blockedColumn.Width = 90;
            blockedColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;



            /* Création des colonnes */
            dgvThirdParties.Columns.Add(idColumn);
            dgvThirdParties.Columns.Add(codeColumn);
            dgvThirdParties.Columns.Add(nameColumn);
            dgvThirdParties.Columns.Add(adressColumn);
            dgvThirdParties.Columns.Add(cityColumn);
            dgvThirdParties.Columns.Add(countryColumn);
            dgvThirdParties.Columns.Add(blockedColumn);

            List<EntityThirdParty> list;
            list = thirdPartyProvider.getThirdPartyByType(_type);

            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvThirdParties.Rows.Add();
                
                string Code = list[i].PrefixCode + list[i].NumberCode.ToString("00000");
                string Name = list[i].Name;
                string Adress1 = list[i].Adress1;
                string Adress2 = list[i].Adress2;
                string Adress3 = list[i].Adress3;
                string PostalCode = list[i].PostalCode;
                string City = list[i].City;
                string Country = list[i].Country;
                bool Blocked = list[i].Blocked;
                int ID = list[i].ID;

                dgvThirdParties.Rows[number].Cells[0].Value = ID;
                dgvThirdParties.Rows[number].Cells[1].Value = Code;
                dgvThirdParties.Rows[number].Cells[2].Value = Name;
                dgvThirdParties.Rows[number].Cells[3].Value = (Adress1 + " " + Adress2 + " " + Adress3).Trim();
                dgvThirdParties.Rows[number].Cells[4].Value = (PostalCode + " " + City).Trim();
                dgvThirdParties.Rows[number].Cells[5].Value = Country;
                dgvThirdParties.Rows[number].Cells[6].Value = Blocked;
                

                /* Mise à jour barre de statut */
                tssNbThirdParties.Text = "Nombre de " + thirdPartyLabel + " trouvés : " + thirdPartyProvider.Count(_type).ToString();


            }

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

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            //idClient selon la ligne sélectionnée
            int ID = Int32.Parse(dgvThirdParties.CurrentRow.Cells[0].Value.ToString());

            ThirdPartyEditForm thirdPartyEditForm = new ThirdPartyEditForm(this, "", "U", ID);
            thirdPartyEditForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EntityThirdParty> list;
            list = thirdPartyProvider.SearchByName(txtSearch.Text, _type);

            dgvThirdParties.Rows.Clear();
            dgvThirdParties.Columns.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvThirdParties.Rows.Add();

                string Code = list[i].PrefixCode + list[i].NumberCode.ToString("00000");
                string Name = list[i].Name;
                string Adress1 = list[i].Adress1;
                string Adress2 = list[i].Adress2;
                string Adress3 = list[i].Adress3;
                string PostalCode = list[i].PostalCode;
                string City = list[i].City;
                string Country = list[i].Country;
                bool Blocked = list[i].Blocked;
                int ID = list[i].ID;

                dgvThirdParties.Rows[number].Cells[0].Value = ID;
                dgvThirdParties.Rows[number].Cells[1].Value = Code;
                dgvThirdParties.Rows[number].Cells[2].Value = Name;
                dgvThirdParties.Rows[number].Cells[3].Value = (Adress1 + " " + Adress2 + " " + Adress3).Trim();
                dgvThirdParties.Rows[number].Cells[4].Value = (PostalCode + " " + City).Trim();
                dgvThirdParties.Rows[number].Cells[5].Value = Country;
                dgvThirdParties.Rows[number].Cells[6].Value = Blocked;


                /* Mise à jour barre de statut */
                tssNbThirdParties.Text = "Nombre de " + thirdPartyLabel + " trouvés : " + thirdPartyProvider.Count(_type).ToString();


            }
        }
    }
}
