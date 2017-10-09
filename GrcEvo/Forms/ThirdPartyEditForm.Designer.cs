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
            this.lblCode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabInfos = new System.Windows.Forms.TabControl();
            this.tabPageAdresse = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCivility = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumberCode = new System.Windows.Forms.TextBox();
            this.txtPrefixCode = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBloqued = new System.Windows.Forms.CheckBox();
            this.tabInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(9, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(66, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code client :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(704, 439);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabInfos
            // 
            this.tabInfos.Controls.Add(this.tabPageAdresse);
            this.tabInfos.Controls.Add(this.tabPage2);
            this.tabInfos.Location = new System.Drawing.Point(4, 105);
            this.tabInfos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.SelectedIndex = 0;
            this.tabInfos.Size = new System.Drawing.Size(789, 317);
            this.tabInfos.TabIndex = 5;
            // 
            // tabPageAdresse
            // 
            this.tabPageAdresse.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAdresse.Name = "tabPageAdresse";
            this.tabPageAdresse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAdresse.Size = new System.Drawing.Size(781, 291);
            this.tabPageAdresse.TabIndex = 0;
            this.tabPageAdresse.Text = "Adresse";
            this.tabPageAdresse.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(781, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Livraison";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(222, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 13);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Civilité :";
            // 
            // cbxCivility
            // 
            this.cbxCivility.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCivility.FormattingEnabled = true;
            this.cbxCivility.Location = new System.Drawing.Point(55, 56);
            this.cbxCivility.Name = "cbxCivility";
            this.cbxCivility.Size = new System.Drawing.Size(141, 24);
            this.cbxCivility.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(263, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(530, 22);
            this.txtName.TabIndex = 14;
            // 
            // txtNumberCode
            // 
            this.txtNumberCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCode.Location = new System.Drawing.Point(81, 28);
            this.txtNumberCode.Name = "txtNumberCode";
            this.txtNumberCode.ReadOnly = true;
            this.txtNumberCode.Size = new System.Drawing.Size(60, 22);
            this.txtNumberCode.TabIndex = 12;
            // 
            // txtPrefixCode
            // 
            this.txtPrefixCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefixCode.Location = new System.Drawing.Point(410, 28);
            this.txtPrefixCode.Name = "txtPrefixCode";
            this.txtPrefixCode.ReadOnly = true;
            this.txtPrefixCode.Size = new System.Drawing.Size(24, 22);
            this.txtPrefixCode.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Famille :";
            // 
            // chkBloqued
            // 
            this.chkBloqued.AutoSize = true;
            this.chkBloqued.Location = new System.Drawing.Point(730, 28);
            this.chkBloqued.Name = "chkBloqued";
            this.chkBloqued.Size = new System.Drawing.Size(59, 17);
            this.chkBloqued.TabIndex = 22;
            this.chkBloqued.Text = "Bloqué";
            this.chkBloqued.UseVisualStyleBackColor = true;
            // 
            // ThirdPartyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 486);
            this.Controls.Add(this.chkBloqued);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCivility);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumberCode);
            this.Controls.Add(this.txtPrefixCode);
            this.Controls.Add(this.tabInfos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ThirdPartyEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche tiers";
            this.tabInfos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabInfos;
        private System.Windows.Forms.TabPage tabPageAdresse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCivility;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumberCode;
        private System.Windows.Forms.TextBox txtPrefixCode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBloqued;
    }
}