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
        
        public ThirdPartiesForm(string type)
        {
            InitializeComponent();
            _type = type;
            RefreshData();
        }

        public void RefreshData()
        {
            ThirdPartyProvider thirdPartyProvider = new ThirdPartyProvider();

            /* Initialisation du Datagridview */
            dgvThirdParties.Rows.Clear();
            dgvThirdParties.Columns.Clear();

            /* Mise en forme Datagridview */
            /* Ajout des colonnes */
            dgvThirdParties.Columns.Add("Code","Code");
            dgvThirdParties.Columns.Add("Name", "Nom");
            dgvThirdParties.Columns.Add("Adress", "Adresse");
            dgvThirdParties.Columns.Add("City", "Ville");
            dgvThirdParties.Columns.Add("Country", "Pays");
            DataGridViewCheckBoxColumn blockedColumn = new DataGridViewCheckBoxColumn();
            blockedColumn.Name = "Blocked";
            blockedColumn.HeaderText = "Bloqué";
            blockedColumn.Width = 100;
            dgvThirdParties.Columns.Add(blockedColumn);

            /* Largeur des colonnes */
            


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

                dgvThirdParties.Rows[number].Cells[0].Value = Code;
                dgvThirdParties.Rows[number].Cells[1].Value = Name;
                dgvThirdParties.Rows[number].Cells[2].Value = (Adress1 + " " + Adress2 + " " + Adress3).Trim();
                dgvThirdParties.Rows[number].Cells[3].Value = (PostalCode + " " + City).Trim();
                dgvThirdParties.Rows[number].Cells[4].Value = Country;
                dgvThirdParties.Rows[number].Cells[5].Value = Blocked;

                // pointe sur l'enregistrement courant
                

                
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
    }
}
