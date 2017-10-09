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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
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
            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.tabInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 46);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(96, 20);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code client :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1056, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1212, 28);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tabInfos
            // 
            this.tabInfos.Controls.Add(this.tabPageAdresse);
            this.tabInfos.Controls.Add(this.tabPage2);
            this.tabInfos.Location = new System.Drawing.Point(6, 162);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.SelectedIndex = 0;
            this.tabInfos.Size = new System.Drawing.Size(1184, 488);
            this.tabInfos.TabIndex = 5;
            // 
            // tabPageAdresse
            // 
            this.tabPageAdresse.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdresse.Name = "tabPageAdresse";
            this.tabPageAdresse.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageAdresse.Size = new System.Drawing.Size(1176, 455);
            this.tabPageAdresse.TabIndex = 0;
            this.tabPageAdresse.Text = "Adresse";
            this.tabPageAdresse.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Livraison";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(333, 94);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(50, 20);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Civilité :";
            // 
            // cbxCivility
            // 
            this.cbxCivility.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCivility.FormattingEnabled = true;
            this.cbxCivility.Location = new System.Drawing.Point(82, 86);
            this.cbxCivility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCivility.Name = "cbxCivility";
            this.cbxCivility.Size = new System.Drawing.Size(210, 31);
            this.cbxCivility.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(394, 85);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(793, 30);
            this.txtName.TabIndex = 14;
            // 
            // txtNumberCode
            // 
            this.txtNumberCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCode.Location = new System.Drawing.Point(122, 43);
            this.txtNumberCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberCode.Name = "txtNumberCode";
            this.txtNumberCode.ReadOnly = true;
            this.txtNumberCode.Size = new System.Drawing.Size(88, 30);
            this.txtNumberCode.TabIndex = 12;
            // 
            // txtPrefixCode
            // 
            this.txtPrefixCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefixCode.Location = new System.Drawing.Point(615, 43);
            this.txtPrefixCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrefixCode.Name = "txtPrefixCode";
            this.txtPrefixCode.ReadOnly = true;
            this.txtPrefixCode.Size = new System.Drawing.Size(34, 30);
            this.txtPrefixCode.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 31);
            this.comboBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Famille :";
            // 
            // chkBlocked
            // 
            this.chkBlocked.AutoSize = true;
            this.chkBlocked.Location = new System.Drawing.Point(1095, 43);
            this.chkBlocked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBlocked.Name = "chkBlocked";
            this.chkBlocked.Size = new System.Drawing.Size(85, 24);
            this.chkBlocked.TabIndex = 22;
            this.chkBlocked.Text = "Bloqué";
            this.chkBlocked.UseVisualStyleBackColor = true;
            // 
            // ThirdPartyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 748);
            this.Controls.Add(this.chkBlocked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCivility);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumberCode);
            this.Controls.Add(this.txtPrefixCode);
            this.Controls.Add(this.tabInfos);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ToolStrip toolStrip;
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
        private System.Windows.Forms.CheckBox chkBlocked;
    }
}