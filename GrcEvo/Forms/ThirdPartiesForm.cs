﻿using System;
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

        /// <summary>
        /// Crée le Datagridview
        /// </summary>
        public void CreateTable(List<EntityThirdParty> list)
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
            codeColumn.HeaderText = "CODE";
            codeColumn.Width = 80;
            codeColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            codeColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "NOM";
            nameColumn.Width = 250;
            nameColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn adressColumn = new DataGridViewTextBoxColumn();
            adressColumn.Name = "Adress";
            adressColumn.HeaderText = "ADRESSE";
            adressColumn.Width = 250;
            adressColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn cityColumn = new DataGridViewTextBoxColumn();
            cityColumn.Name = "City";
            cityColumn.HeaderText = "VILLE";
            cityColumn.Width = 220;
            cityColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn countryColumn = new DataGridViewTextBoxColumn();
            countryColumn.Name = "Country";
            countryColumn.HeaderText = "PAYS";
            countryColumn.Width = 130;
            countryColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewCheckBoxColumn blockedColumn = new DataGridViewCheckBoxColumn();
            blockedColumn.Name = "Blocked";
            blockedColumn.HeaderText = "BLOQUÉ";
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

            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvThirdParties.Rows.Add();

                int id = list[i].ID;
                string code = list[i].PrefixCode + list[i].NumberCode.ToString("00000");
                string name = list[i].Name;
                string adress1 = list[i].Adress1;
                string adress2 = list[i].Adress2;
                string adress3 = list[i].Adress3;
                string postalCode = list[i].PostalCode;
                string city = list[i].City;
                string country = list[i].Country;
                bool blocked = list[i].Blocked;

                dgvThirdParties.Rows[number].Cells[0].Value = id;
                dgvThirdParties.Rows[number].Cells[1].Value = code;
                dgvThirdParties.Rows[number].Cells[2].Value = name;
                dgvThirdParties.Rows[number].Cells[3].Value = (adress1 + " " + adress2 + " " + adress3).Trim();
                dgvThirdParties.Rows[number].Cells[4].Value = (postalCode + " " + city).Trim();
                dgvThirdParties.Rows[number].Cells[5].Value = country;
                dgvThirdParties.Rows[number].Cells[6].Value = blocked;
            }
        }

        public void RefreshData()
        {
            List<EntityThirdParty> list;
            list = thirdPartyProvider.getThirdPartyByType(_type);

            CreateTable(list);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            CreateThirdParty();
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
            UpdateThirdParty();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EntityThirdParty> list;
            list = thirdPartyProvider.SearchByName(txtSearch.Text, _type);

            CreateTable(list);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        /// <summary>
        /// Remise à zéro de la recherche. Effacement du champ de recherche et attribution du focus.
        /// </summary>
        private void ResetSearch()
        {
            RefreshData();
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void CreateThirdParty()
        {
            ThirdPartyEditForm frm = new ThirdPartyEditForm(this, _type, "C");
            frm.ShowDialog();
        }

        private void UpdateThirdParty()
        {
            /* Vérifie si la Datagridview comporte au moins une ligne */
            if (dgvThirdParties.RowCount > 0)
            {
                int ID = Int32.Parse(dgvThirdParties.CurrentRow.Cells[0].Value.ToString());
                ThirdPartyEditForm thirdPartyEditForm = new ThirdPartyEditForm(this, "", "U", ID);
                thirdPartyEditForm.ShowDialog();
            }
        }
    }
}
