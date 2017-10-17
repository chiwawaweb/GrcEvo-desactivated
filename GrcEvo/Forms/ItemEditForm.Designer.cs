namespace GrcEvo.Forms
{
    partial class ItemEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.cbxFamily = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lblEan = new System.Windows.Forms.Label();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.lblVatRate = new System.Windows.Forms.Label();
            this.cbxVatRate = new System.Windows.Forms.ComboBox();
            this.lblLongDescription = new System.Windows.Forms.Label();
            this.txtLongDescription = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.tabItem = new System.Windows.Forms.TabControl();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.tabPagePurchases = new System.Windows.Forms.TabPage();
            this.txtPriceSaleET = new System.Windows.Forms.TextBox();
            this.lblPriceSaleET = new System.Windows.Forms.Label();
            this.txtPricePurchaseET = new System.Windows.Forms.TextBox();
            this.lblPricePurchaseET = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.tabItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(782, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // tsbSave
            // 
            this.tsbSave.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(104, 22);
            this.tsbSave.Text = "ENREGISTRER";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(76, 22);
            this.tsbClose.Text = "ANNULER";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(782, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblItemCode.Location = new System.Drawing.Point(13, 49);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(40, 17);
            this.lblItemCode.TabIndex = 2;
            this.lblItemCode.Text = "CODE";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCode.Location = new System.Drawing.Point(67, 49);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 17);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "------";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblFamily.Location = new System.Drawing.Point(364, 49);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(64, 17);
            this.lblFamily.TabIndex = 4;
            this.lblFamily.Text = "FAMILLE";
            // 
            // cbxFamily
            // 
            this.cbxFamily.Font = new System.Drawing.Font("Consolas", 10F);
            this.cbxFamily.FormattingEnabled = true;
            this.cbxFamily.Location = new System.Drawing.Point(434, 47);
            this.cbxFamily.Name = "cbxFamily";
            this.cbxFamily.Size = new System.Drawing.Size(121, 23);
            this.cbxFamily.TabIndex = 1;
            // 
            // cbxBrand
            // 
            this.cbxBrand.Font = new System.Drawing.Font("Consolas", 10F);
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(75, 87);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(121, 23);
            this.cbxBrand.TabIndex = 2;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblBrand.Location = new System.Drawing.Point(13, 89);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 17);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "MARQUE";
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("Consolas", 10F);
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(216, 47);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 23);
            this.cbxType.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblType.Location = new System.Drawing.Point(170, 49);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "TYPE";
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblShortDescription.Location = new System.Drawing.Point(217, 88);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(64, 17);
            this.lblShortDescription.TabIndex = 10;
            this.lblShortDescription.Text = "LIBELLE";
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(319, 86);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(442, 23);
            this.txtShortDescription.TabIndex = 3;
            // 
            // lblEan
            // 
            this.lblEan.AutoSize = true;
            this.lblEan.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblEan.Location = new System.Drawing.Point(13, 140);
            this.lblEan.Name = "lblEan";
            this.lblEan.Size = new System.Drawing.Size(32, 17);
            this.lblEan.TabIndex = 12;
            this.lblEan.Text = "EAN";
            // 
            // txtEan
            // 
            this.txtEan.Location = new System.Drawing.Point(59, 137);
            this.txtEan.Name = "txtEan";
            this.txtEan.Size = new System.Drawing.Size(137, 23);
            this.txtEan.TabIndex = 4;
            // 
            // lblVatRate
            // 
            this.lblVatRate.AutoSize = true;
            this.lblVatRate.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblVatRate.Location = new System.Drawing.Point(13, 172);
            this.lblVatRate.Name = "lblVatRate";
            this.lblVatRate.Size = new System.Drawing.Size(32, 17);
            this.lblVatRate.TabIndex = 14;
            this.lblVatRate.Text = "TVA";
            // 
            // cbxVatRate
            // 
            this.cbxVatRate.Font = new System.Drawing.Font("Consolas", 10F);
            this.cbxVatRate.FormattingEnabled = true;
            this.cbxVatRate.Location = new System.Drawing.Point(59, 169);
            this.cbxVatRate.Name = "cbxVatRate";
            this.cbxVatRate.Size = new System.Drawing.Size(64, 23);
            this.cbxVatRate.TabIndex = 5;
            // 
            // lblLongDescription
            // 
            this.lblLongDescription.AutoSize = true;
            this.lblLongDescription.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblLongDescription.Location = new System.Drawing.Point(217, 137);
            this.lblLongDescription.Name = "lblLongDescription";
            this.lblLongDescription.Size = new System.Drawing.Size(96, 17);
            this.lblLongDescription.TabIndex = 16;
            this.lblLongDescription.Text = "DESCRIPTION";
            // 
            // txtLongDescription
            // 
            this.txtLongDescription.Enabled = false;
            this.txtLongDescription.Location = new System.Drawing.Point(319, 131);
            this.txtLongDescription.Multiline = true;
            this.txtLongDescription.Name = "txtLongDescription";
            this.txtLongDescription.ReadOnly = true;
            this.txtLongDescription.Size = new System.Drawing.Size(442, 101);
            this.txtLongDescription.TabIndex = 17;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(70, 209);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(42, 23);
            this.txtStock.TabIndex = 18;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblStock.Location = new System.Drawing.Point(13, 212);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(48, 17);
            this.lblStock.TabIndex = 19;
            this.lblStock.Text = "STOCK";
            // 
            // chkBlocked
            // 
            this.chkBlocked.AutoSize = true;
            this.chkBlocked.Location = new System.Drawing.Point(686, 47);
            this.chkBlocked.Name = "chkBlocked";
            this.chkBlocked.Size = new System.Drawing.Size(75, 21);
            this.chkBlocked.TabIndex = 20;
            this.chkBlocked.Text = "BLOQUÉ";
            this.chkBlocked.UseVisualStyleBackColor = true;
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.tabPageSales);
            this.tabItem.Controls.Add(this.tabPagePurchases);
            this.tabItem.Location = new System.Drawing.Point(13, 244);
            this.tabItem.Name = "tabItem";
            this.tabItem.SelectedIndex = 0;
            this.tabItem.Size = new System.Drawing.Size(757, 184);
            this.tabItem.TabIndex = 21;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Location = new System.Drawing.Point(4, 24);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(749, 156);
            this.tabPageSales.TabIndex = 0;
            this.tabPageSales.Text = "VENTES";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // tabPagePurchases
            // 
            this.tabPagePurchases.Location = new System.Drawing.Point(4, 24);
            this.tabPagePurchases.Name = "tabPagePurchases";
            this.tabPagePurchases.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchases.Size = new System.Drawing.Size(749, 156);
            this.tabPagePurchases.TabIndex = 1;
            this.tabPagePurchases.Text = "ACHATS";
            this.tabPagePurchases.UseVisualStyleBackColor = true;
            // 
            // txtPriceSaleET
            // 
            this.txtPriceSaleET.Location = new System.Drawing.Point(198, 212);
            this.txtPriceSaleET.Name = "txtPriceSaleET";
            this.txtPriceSaleET.Size = new System.Drawing.Size(42, 23);
            this.txtPriceSaleET.TabIndex = 22;
            // 
            // lblPriceSaleET
            // 
            this.lblPriceSaleET.AutoSize = true;
            this.lblPriceSaleET.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblPriceSaleET.Location = new System.Drawing.Point(132, 215);
            this.lblPriceSaleET.Name = "lblPriceSaleET";
            this.lblPriceSaleET.Size = new System.Drawing.Size(64, 17);
            this.lblPriceSaleET.TabIndex = 23;
            this.lblPriceSaleET.Text = "P.V. HT";
            // 
            // txtPricePurchaseET
            // 
            this.txtPricePurchaseET.Location = new System.Drawing.Point(198, 189);
            this.txtPricePurchaseET.Name = "txtPricePurchaseET";
            this.txtPricePurchaseET.Size = new System.Drawing.Size(42, 23);
            this.txtPricePurchaseET.TabIndex = 24;
            // 
            // lblPricePurchaseET
            // 
            this.lblPricePurchaseET.AutoSize = true;
            this.lblPricePurchaseET.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblPricePurchaseET.Location = new System.Drawing.Point(132, 192);
            this.lblPricePurchaseET.Name = "lblPricePurchaseET";
            this.lblPricePurchaseET.Size = new System.Drawing.Size(64, 17);
            this.lblPricePurchaseET.TabIndex = 25;
            this.lblPricePurchaseET.Text = "P.A. HT";
            // 
            // ItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.ControlBox = false;
            this.Controls.Add(this.txtPricePurchaseET);
            this.Controls.Add(this.lblPricePurchaseET);
            this.Controls.Add(this.txtPriceSaleET);
            this.Controls.Add(this.lblPriceSaleET);
            this.Controls.Add(this.tabItem);
            this.Controls.Add(this.chkBlocked);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtLongDescription);
            this.Controls.Add(this.lblLongDescription);
            this.Controls.Add(this.cbxVatRate);
            this.Controls.Add(this.lblVatRate);
            this.Controls.Add(this.txtEan);
            this.Controls.Add(this.lblEan);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.lblShortDescription);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cbxFamily);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche article";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemEditForm_FormClosed);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.ComboBox cbxFamily;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lblEan;
        private System.Windows.Forms.TextBox txtEan;
        private System.Windows.Forms.Label lblVatRate;
        private System.Windows.Forms.ComboBox cbxVatRate;
        private System.Windows.Forms.Label lblLongDescription;
        private System.Windows.Forms.TextBox txtLongDescription;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.CheckBox chkBlocked;
        private System.Windows.Forms.TabControl tabItem;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.TabPage tabPagePurchases;
        private System.Windows.Forms.TextBox txtPriceSaleET;
        private System.Windows.Forms.Label lblPriceSaleET;
        private System.Windows.Forms.TextBox txtPricePurchaseET;
        private System.Windows.Forms.Label lblPricePurchaseET;
    }
}