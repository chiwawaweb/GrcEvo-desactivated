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
            this.tabPageAdresse = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCivility = new System.Windows.Forms.Label();
            this.cbxCivility = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxFamily = new System.Windows.Forms.ComboBox();
            this.lblFamily = new System.Windows.Forms.Label();
            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip.SuspendLayout();
            this.tabInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThirdPartyCode
            // 
            this.lblThirdPartyCode.AutoSize = true;
            this.lblThirdPartyCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPartyCode.Location = new System.Drawing.Point(10, 53);
            this.lblThirdPartyCode.Name = "lblThirdPartyCode";
            this.lblThirdPartyCode.Size = new System.Drawing.Size(69, 23);
            this.lblThirdPartyCode.TabIndex = 5;
            this.lblThirdPartyCode.Text = "Code :";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(929, 32);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(124, 29);
            this.tsbSave.Text = "Enregistrer";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(101, 29);
            this.tsbClose.Text = "Annuler";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tabInfos
            // 
            this.tabInfos.Controls.Add(this.tabPageAdresse);
            this.tabInfos.Controls.Add(this.tabPage2);
            this.tabInfos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInfos.Location = new System.Drawing.Point(5, 129);
            this.tabInfos.Margin = new System.Windows.Forms.Padding(2);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.SelectedIndex = 0;
            this.tabInfos.Size = new System.Drawing.Size(920, 379);
            this.tabInfos.TabIndex = 4;
            // 
            // tabPageAdresse
            // 
            this.tabPageAdresse.Location = new System.Drawing.Point(4, 32);
            this.tabPageAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdresse.Name = "tabPageAdresse";
            this.tabPageAdresse.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAdresse.Size = new System.Drawing.Size(912, 343);
            this.tabPageAdresse.TabIndex = 0;
            this.tabPageAdresse.Text = "Adresse";
            this.tabPageAdresse.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(912, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Livraison";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(259, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 23);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Nom :";
            // 
            // lblCivility
            // 
            this.lblCivility.AutoSize = true;
            this.lblCivility.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCivility.Location = new System.Drawing.Point(10, 91);
            this.lblCivility.Name = "lblCivility";
            this.lblCivility.Size = new System.Drawing.Size(78, 23);
            this.lblCivility.TabIndex = 18;
            this.lblCivility.Text = "Civilité :";
            // 
            // cbxCivility
            // 
            this.cbxCivility.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCivility.FormattingEnabled = true;
            this.cbxCivility.Location = new System.Drawing.Point(79, 87);
            this.cbxCivility.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCivility.Name = "cbxCivility";
            this.cbxCivility.Size = new System.Drawing.Size(164, 31);
            this.cbxCivility.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(316, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(604, 30);
            this.txtName.TabIndex = 3;
            // 
            // cbxFamily
            // 
            this.cbxFamily.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFamily.FormattingEnabled = true;
            this.cbxFamily.Location = new System.Drawing.Point(316, 49);
            this.cbxFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFamily.Name = "cbxFamily";
            this.cbxFamily.Size = new System.Drawing.Size(224, 31);
            this.cbxFamily.TabIndex = 1;
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.Location = new System.Drawing.Point(241, 53);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(84, 23);
            this.lblFamily.TabIndex = 20;
            this.lblFamily.Text = "Famille :";
            // 
            // chkBlocked
            // 
            this.chkBlocked.AutoSize = true;
            this.chkBlocked.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlocked.Location = new System.Drawing.Point(852, 52);
            this.chkBlocked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBlocked.Name = "chkBlocked";
            this.chkBlocked.Size = new System.Drawing.Size(96, 27);
            this.chkBlocked.TabIndex = 22;
            this.chkBlocked.Text = "Bloqué";
            this.chkBlocked.UseVisualStyleBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCode.Location = new System.Drawing.Point(79, 52);
            this.lblCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCode.Name = "lblCode";
            this.lblCode.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.lblCode.Size = new System.Drawing.Size(65, 29);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "-------";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Location = new System.Drawing.Point(0, 516);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(929, 22);
            this.statusStrip.TabIndex = 24;
            this.statusStrip.Text = "statusStrip1";
            // 
            // ThirdPartyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 538);
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
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThirdPartyEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche tiers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThirdPartyEditForm_FormClosed);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabInfos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThirdPartyCode;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TabControl tabInfos;
        private System.Windows.Forms.TabPage tabPageAdresse;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}