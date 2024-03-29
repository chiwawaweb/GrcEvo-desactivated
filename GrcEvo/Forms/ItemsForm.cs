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
    public partial class ItemsForm : Form
    {
        ItemProvider itemProvider = new ItemProvider();

        public ItemsForm()
        {
            InitializeComponent();

            this.Size = new Size(1080, 600);

            RefreshData();
        }

        public void CreateTable(List<EntityItem> list)
        {
            /* Initialisation du Datagridview */
            dgvItems.Rows.Clear();
            dgvItems.Columns.Clear();

            /* Mise en forme Datagridview */
            dgvItems.Size = new Size(1064, 478);

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.Visible = false;

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "TYPE";
            typeColumn.Width = 80;
            typeColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn codeColumn = new DataGridViewTextBoxColumn();
            codeColumn.Name = "Code";
            codeColumn.HeaderText = "CODE";
            codeColumn.Width = 80;
            codeColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            codeColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn familyColumn = new DataGridViewTextBoxColumn();
            familyColumn.Name = "Family";
            familyColumn.HeaderText = "FAMILLE";
            familyColumn.Width = 150;
            familyColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn brandColumn = new DataGridViewTextBoxColumn();
            brandColumn.Name = "Brand";
            brandColumn.HeaderText = "MARQUE";
            brandColumn.Width = 150;
            brandColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn shortDescriptionColumn = new DataGridViewTextBoxColumn();
            shortDescriptionColumn.Name = "ShortDescription";
            shortDescriptionColumn.HeaderText = "DESCRIPTION";
            shortDescriptionColumn.Width = 300;
            shortDescriptionColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn stockColumn = new DataGridViewTextBoxColumn();
            stockColumn.Name = "Stock";
            stockColumn.HeaderText = "STOCK";
            stockColumn.Width = 70;
            stockColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            stockColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewCheckBoxColumn blockedColumn = new DataGridViewCheckBoxColumn();
            blockedColumn.Name = "Blocked";
            blockedColumn.HeaderText = "BLOQUÉ";
            blockedColumn.Width = 90;
            blockedColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            dgvItems.Columns.Add(idColumn);
            
            dgvItems.Columns.Add(codeColumn);
            dgvItems.Columns.Add(typeColumn);
            dgvItems.Columns.Add(familyColumn);
            dgvItems.Columns.Add(brandColumn);
            dgvItems.Columns.Add(shortDescriptionColumn);
            dgvItems.Columns.Add(stockColumn);
            dgvItems.Columns.Add(blockedColumn);

            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvItems.Rows.Add();

                int id = list[i].ID;
                string type = list[i].Type;
                string code = list[i].PrefixCode + list[i].NumberCode.ToString("00000");
                string family = list[i].Family;
                string brand = list[i].Brand;
                string shortDescription = list[i].ShortDescription;
                double stock = list[i].Stock;
                bool blocked = list[i].Blocked;

                dgvItems.Rows[number].Cells[0].Value = id;
                dgvItems.Rows[number].Cells[1].Value = code;
                dgvItems.Rows[number].Cells[2].Value = type;
                dgvItems.Rows[number].Cells[3].Value = family;
                dgvItems.Rows[number].Cells[4].Value = brand;
                dgvItems.Rows[number].Cells[5].Value = shortDescription;
                dgvItems.Rows[number].Cells[6].Value = stock;
                dgvItems.Rows[number].Cells[7].Value = blocked;
            }
        }

        public void RefreshData()
        {
            List<EntityItem> list;
            list = itemProvider.GetAll();

            CreateTable(list);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EntityItem> list;
            list = itemProvider.SearchByCriteria(txtSearch.Text);

            CreateTable(list);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        /// <summary>
        /// Remise à zéro de la recherche.
        /// </summary>
        private void ResetSearch()
        {
            RefreshData();
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void UpdateItem()
        {
            /* Vérifie si la Datagridview comporte au moins une ligne */
            if (dgvItems.RowCount > 0)
            {
                int ID = Int32.Parse(dgvItems.CurrentRow.Cells[0].Value.ToString());
                ItemEditForm itemEditForm = new ItemEditForm(this, "U", ID);
                itemEditForm.ShowDialog();
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            CreateItem();
        }

        private void CreateItem()
        {
            ItemEditForm frm = new ItemEditForm(this, "C");
            frm.ShowDialog();
        }
    }
}
