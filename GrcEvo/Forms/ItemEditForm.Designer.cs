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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.cbxFamily = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
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
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 373);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(782, 22);
            this.statusStrip.TabIndex = 1;
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
            this.cbxFamily.TabIndex = 5;
            // 
            // cbxBrand
            // 
            this.cbxBrand.Font = new System.Drawing.Font("Consolas", 10F);
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(75, 87);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(121, 23);
            this.cbxBrand.TabIndex = 7;
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
            // lblType
            // 
            this.lblType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblType.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblType.FormattingEnabled = true;
            this.lblType.Location = new System.Drawing.Point(216, 47);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(121, 23);
            this.lblType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.Location = new System.Drawing.Point(170, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "TYPE";
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
            this.txtShortDescription.Location = new System.Drawing.Point(298, 86);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(463, 23);
            this.txtShortDescription.TabIndex = 11;
            // 
            // ItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 395);
            this.ControlBox = false;
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.lblShortDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche article";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemEditForm_FormClosed);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.ComboBox lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
    }
}