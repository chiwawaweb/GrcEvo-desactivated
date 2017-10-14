namespace GrcEvo.Forms
{
    partial class ThirdPartyEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdPartyEditForm));
            this.lblThirdPartyCode = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tabInfos = new System.Windows.Forms.TabControl();
            this.tpgAdress = new System.Windows.Forms.TabPage();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAdress3 = new System.Windows.Forms.TextBox();
            this.txtAdress2 = new System.Windows.Forms.TextBox();
            this.txtAdress1 = new System.Windows.Forms.TextBox();
            this.tpgDelivery = new System.Windows.Forms.TabPage();
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCivility = new System.Windows.Forms.Label();
            this.cbxCivility = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxFamily = new System.Windows.Forms.ComboBox();
            this.lblFamily = new System.Windows.Forms.Label();
            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssCreatedAt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUpdatedAt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageHistoric = new System.Windows.Forms.TabPage();
            this.lblCity = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.tabInfos.SuspendLayout();
            this.tpgAdress.SuspendLayout();
            this.tpgDelivery.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThirdPartyCode
            // 
            this.lblThirdPartyCode.AutoSize = true;
            this.lblThirdPartyCode.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPartyCode.Location = new System.Drawing.Point(10, 53);
            this.lblThirdPartyCode.Name = "lblThirdPartyCode";
            this.lblThirdPartyCode.Size = new System.Drawing.Size(54, 23);
            this.lblThirdPartyCode.TabIndex = 5;
            this.lblThirdPartyCode.Text = "CODE";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(930, 31);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(148, 28);
            this.tsbSave.Text = "ENREGISTRER";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(108, 28);
            this.tsbClose.Text = "ANNULER";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tabInfos
            // 
            this.tabInfos.Controls.Add(this.tpgAdress);
            this.tabInfos.Controls.Add(this.tpgDelivery);
            this.tabInfos.Controls.Add(this.tabPageHistoric);
            this.tabInfos.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInfos.Location = new System.Drawing.Point(6, 129);
            this.tabInfos.Margin = new System.Windows.Forms.Padding(2);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.SelectedIndex = 0;
            this.tabInfos.Size = new System.Drawing.Size(920, 379);
            this.tabInfos.TabIndex = 4;
            // 
            // tpgAdress
            // 
            this.tpgAdress.BackColor = System.Drawing.SystemColors.Control;
            this.tpgAdress.Controls.Add(this.lblCity);
            this.tpgAdress.Controls.Add(this.lblCountry);
            this.tpgAdress.Controls.Add(this.lblPostalCode);
            this.tpgAdress.Controls.Add(this.cbxCountry);
            this.tpgAdress.Controls.Add(this.txtCity);
            this.tpgAdress.Controls.Add(this.txtPostalCode);
            this.tpgAdress.Controls.Add(this.lblAdress);
            this.tpgAdress.Controls.Add(this.txtAdress3);
            this.tpgAdress.Controls.Add(this.txtAdress2);
            this.tpgAdress.Controls.Add(this.txtAdress1);
            this.tpgAdress.Location = new System.Drawing.Point(4, 32);
            this.tpgAdress.Margin = new System.Windows.Forms.Padding(2);
            this.tpgAdress.Name = "tpgAdress";
            this.tpgAdress.Padding = new System.Windows.Forms.Padding(2);
            this.tpgAdress.Size = new System.Drawing.Size(912, 343);
            this.tpgAdress.TabIndex = 0;
            this.tpgAdress.Text = "ADRESSE";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(17, 167);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(54, 23);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "PAYS";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(17, 139);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(32, 23);
            this.lblPostalCode.TabIndex = 9;
            this.lblPostalCode.Text = "CP";
            // 
            // cbxCountry
            // 
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(125, 164);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(355, 31);
            this.cbxCountry.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(255, 136);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 31);
            this.txtCity.TabIndex = 4;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(125, 136);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(65, 31);
            this.txtPostalCode.TabIndex = 3;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(17, 39);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(87, 23);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "ADRESSE";
            // 
            // txtAdress3
            // 
            this.txtAdress3.Location = new System.Drawing.Point(125, 108);
            this.txtAdress3.Name = "txtAdress3";
            this.txtAdress3.Size = new System.Drawing.Size(355, 31);
            this.txtAdress3.TabIndex = 2;
            // 
            // txtAdress2
            // 
            this.txtAdress2.Location = new System.Drawing.Point(125, 72);
            this.txtAdress2.Name = "txtAdress2";
            this.txtAdress2.Size = new System.Drawing.Size(355, 31);
            this.txtAdress2.TabIndex = 1;
            // 
            // txtAdress1
            // 
            this.txtAdress1.Location = new System.Drawing.Point(125, 36);
            this.txtAdress1.Name = "txtAdress1";
            this.txtAdress1.Size = new System.Drawing.Size(355, 31);
            this.txtAdress1.TabIndex = 0;
            // 
            // tpgDelivery
            // 
            this.tpgDelivery.Controls.Add(this.lblComingSoon);
            this.tpgDelivery.Location = new System.Drawing.Point(4, 32);
            this.tpgDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.tpgDelivery.Name = "tpgDelivery";
            this.tpgDelivery.Padding = new System.Windows.Forms.Padding(2);
            this.tpgDelivery.Size = new System.Drawing.Size(912, 343);
            this.tpgDelivery.TabIndex = 1;
            this.tpgDelivery.Text = "LIVRAISON";
            this.tpgDelivery.UseVisualStyleBackColor = true;
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.AutoSize = true;
            this.lblComingSoon.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoon.ForeColor = System.Drawing.Color.Gray;
            this.lblComingSoon.Location = new System.Drawing.Point(261, 166);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(351, 37);
            this.lblComingSoon.TabIndex = 0;
            this.lblComingSoon.Text = "Fonctionnalité à venir";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(242, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 23);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "NOM";
            // 
            // lblCivility
            // 
            this.lblCivility.AutoSize = true;
            this.lblCivility.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCivility.Location = new System.Drawing.Point(10, 91);
            this.lblCivility.Name = "lblCivility";
            this.lblCivility.Size = new System.Drawing.Size(98, 23);
            this.lblCivility.TabIndex = 18;
            this.lblCivility.Text = "CIVILITE";
            // 
            // cbxCivility
            // 
            this.cbxCivility.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCivility.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCivility.FormattingEnabled = true;
            this.cbxCivility.Location = new System.Drawing.Point(112, 87);
            this.cbxCivility.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCivility.Name = "cbxCivility";
            this.cbxCivility.Size = new System.Drawing.Size(91, 31);
            this.cbxCivility.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(318, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(604, 31);
            this.txtName.TabIndex = 2;
            // 
            // cbxFamily
            // 
            this.cbxFamily.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFamily.FormattingEnabled = true;
            this.cbxFamily.Location = new System.Drawing.Point(318, 49);
            this.cbxFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFamily.Name = "cbxFamily";
            this.cbxFamily.Size = new System.Drawing.Size(224, 31);
            this.cbxFamily.Sorted = true;
            this.cbxFamily.TabIndex = 0;
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.Location = new System.Drawing.Point(227, 53);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(87, 23);
            this.lblFamily.TabIndex = 20;
            this.lblFamily.Text = "FAMILLE";
            // 
            // chkBlocked
            // 
            this.chkBlocked.AutoSize = true;
            this.chkBlocked.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlocked.Location = new System.Drawing.Point(824, 52);
            this.chkBlocked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBlocked.Name = "chkBlocked";
            this.chkBlocked.Size = new System.Drawing.Size(102, 27);
            this.chkBlocked.TabIndex = 22;
            this.chkBlocked.TabStop = false;
            this.chkBlocked.Text = "BLOQUÉ";
            this.chkBlocked.UseVisualStyleBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblCode.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCode.Location = new System.Drawing.Point(112, 52);
            this.lblCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCode.Name = "lblCode";
            this.lblCode.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.lblCode.Size = new System.Drawing.Size(91, 26);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "-------";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCreatedAt,
            this.tssUpdatedAt});
            this.statusStrip.Location = new System.Drawing.Point(0, 508);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip.Size = new System.Drawing.Size(930, 30);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 24;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssCreatedAt
            // 
            this.tssCreatedAt.Enabled = false;
            this.tssCreatedAt.Name = "tssCreatedAt";
            this.tssCreatedAt.Size = new System.Drawing.Size(87, 25);
            this.tssCreatedAt.Text = "Création :";
            // 
            // tssUpdatedAt
            // 
            this.tssUpdatedAt.Enabled = false;
            this.tssUpdatedAt.Name = "tssUpdatedAt";
            this.tssUpdatedAt.Size = new System.Drawing.Size(108, 25);
            this.tssUpdatedAt.Text = "Mise à jour :";
            // 
            // tabPageHistoric
            // 
            this.tabPageHistoric.Location = new System.Drawing.Point(4, 32);
            this.tabPageHistoric.Name = "tabPageHistoric";
            this.tabPageHistoric.Size = new System.Drawing.Size(912, 343);
            this.tabPageHistoric.TabIndex = 2;
            this.tabPageHistoric.Text = "HISTORIQUE";
            this.tabPageHistoric.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(196, 138);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(65, 23);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "VILLE";
            // 
            // ThirdPartyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 538);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.chkBlocked);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.cbxFamily);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCivility);
            this.Controls.Add(this.cbxCivility);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.tabInfos);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lblThirdPartyCode);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThirdPartyEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche tiers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThirdPartyEditForm_FormClosed);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabInfos.ResumeLayout(false);
            this.tpgAdress.ResumeLayout(false);
            this.tpgAdress.PerformLayout();
            this.tpgDelivery.ResumeLayout(false);
            this.tpgDelivery.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThirdPartyCode;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TabControl tabInfos;
        private System.Windows.Forms.TabPage tpgAdress;
        private System.Windows.Forms.TabPage tpgDelivery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCivility;
        private System.Windows.Forms.ComboBox cbxCivility;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxFamily;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.CheckBox chkBlocked;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripStatusLabel tssCreatedAt;
        private System.Windows.Forms.ToolStripStatusLabel tssUpdatedAt;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAdress3;
        private System.Windows.Forms.TextBox txtAdress2;
        private System.Windows.Forms.TextBox txtAdress1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblComingSoon;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TabPage tabPageHistoric;
    }
}