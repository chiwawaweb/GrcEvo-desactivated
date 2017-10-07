namespace GrcEvo.Forms
{
    partial class CustomerEditForm
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
            this.grpDenomination = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCivility = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtNumberCode = new System.Windows.Forms.TextBox();
            this.txtPrefixCode = new System.Windows.Forms.TextBox();
            this.grpCommunication = new System.Windows.Forms.GroupBox();
            this.grpDivers = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpDenomination.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDenomination
            // 
            this.grpDenomination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDenomination.Controls.Add(this.label2);
            this.grpDenomination.Controls.Add(this.cbxCivility);
            this.grpDenomination.Controls.Add(this.lblFirstName);
            this.grpDenomination.Controls.Add(this.lblLastName);
            this.grpDenomination.Controls.Add(this.label1);
            this.grpDenomination.Controls.Add(this.lblCode);
            this.grpDenomination.Controls.Add(this.textBox2);
            this.grpDenomination.Controls.Add(this.textBox1);
            this.grpDenomination.Controls.Add(this.txtCompany);
            this.grpDenomination.Controls.Add(this.txtNumberCode);
            this.grpDenomination.Controls.Add(this.txtPrefixCode);
            this.grpDenomination.Location = new System.Drawing.Point(20, 71);
            this.grpDenomination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDenomination.Name = "grpDenomination";
            this.grpDenomination.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDenomination.Size = new System.Drawing.Size(902, 180);
            this.grpDenomination.TabIndex = 0;
            this.grpDenomination.TabStop = false;
            this.grpDenomination.Text = "Dénomination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Civilité :";
            // 
            // cbxCivility
            // 
            this.cbxCivility.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCivility.FormattingEnabled = true;
            this.cbxCivility.Location = new System.Drawing.Point(10, 125);
            this.cbxCivility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCivility.Name = "cbxCivility";
            this.cbxCivility.Size = new System.Drawing.Size(102, 31);
            this.cbxCivility.TabIndex = 9;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(448, 100);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 20);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "Prénom :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(118, 100);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(50, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Société :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 32);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(96, 20);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code client :";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(453, 125);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(123, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 30);
            this.textBox1.TabIndex = 3;
            // 
            // txtCompany
            // 
            this.txtCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompany.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(123, 57);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(768, 30);
            this.txtCompany.TabIndex = 2;
            // 
            // txtNumberCode
            // 
            this.txtNumberCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCode.Location = new System.Drawing.Point(51, 57);
            this.txtNumberCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberCode.Name = "txtNumberCode";
            this.txtNumberCode.ReadOnly = true;
            this.txtNumberCode.Size = new System.Drawing.Size(61, 30);
            this.txtNumberCode.TabIndex = 1;
            // 
            // txtPrefixCode
            // 
            this.txtPrefixCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefixCode.Location = new System.Drawing.Point(10, 57);
            this.txtPrefixCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrefixCode.Name = "txtPrefixCode";
            this.txtPrefixCode.ReadOnly = true;
            this.txtPrefixCode.Size = new System.Drawing.Size(34, 30);
            this.txtPrefixCode.TabIndex = 0;
            // 
            // grpCommunication
            // 
            this.grpCommunication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCommunication.Location = new System.Drawing.Point(18, 272);
            this.grpCommunication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCommunication.Name = "grpCommunication";
            this.grpCommunication.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCommunication.Size = new System.Drawing.Size(903, 105);
            this.grpCommunication.TabIndex = 1;
            this.grpCommunication.TabStop = false;
            this.grpCommunication.Text = "Communication";
            // 
            // grpDivers
            // 
            this.grpDivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDivers.Location = new System.Drawing.Point(20, 386);
            this.grpDivers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDivers.Name = "grpDivers";
            this.grpDivers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDivers.Size = new System.Drawing.Size(902, 154);
            this.grpDivers.TabIndex = 2;
            this.grpDivers.TabStop = false;
            this.grpDivers.Text = "Informations diverses";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(655, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpDivers);
            this.Controls.Add(this.grpCommunication);
            this.Controls.Add(this.grpDenomination);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerEditForm";
            this.Text = "CustomerEdit";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            this.grpDenomination.ResumeLayout(false);
            this.grpDenomination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDenomination;
        private System.Windows.Forms.GroupBox grpCommunication;
        private System.Windows.Forms.GroupBox grpDivers;
        private System.Windows.Forms.TextBox txtNumberCode;
        private System.Windows.Forms.TextBox txtPrefixCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCivility;
        protected System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnSave;
    }
}