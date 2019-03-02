namespace AthenasBallot.Forms
{
    partial class fmrManageParty
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabControlCreate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnImportLogo = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblParties = new System.Windows.Forms.Label();
            this.cmbParties = new System.Windows.Forms.ComboBox();
            this.ofdPhoto = new System.Windows.Forms.OpenFileDialog();
            this.tabControlCreate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCreate.Location = new System.Drawing.Point(536, 350);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 34);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tabControlCreate
            // 
            this.tabControlCreate.Controls.Add(this.tabPage1);
            this.tabControlCreate.Controls.Add(this.tabPage2);
            this.tabControlCreate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.tabControlCreate.Location = new System.Drawing.Point(12, 12);
            this.tabControlCreate.Name = "tabControlCreate";
            this.tabControlCreate.SelectedIndex = 0;
            this.tabControlCreate.Size = new System.Drawing.Size(637, 425);
            this.tabControlCreate.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Controls.Add(this.btnImportLogo);
            this.tabPage1.Controls.Add(this.lblLogo);
            this.tabPage1.Controls.Add(this.lblNumber);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.txtNumber);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblError.ForeColor = System.Drawing.Color.Coral;
            this.lblError.Location = new System.Drawing.Point(278, 325);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(62, 21);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "label1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(25, 52);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(246, 227);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // btnImportLogo
            // 
            this.btnImportLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportLogo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnImportLogo.Location = new System.Drawing.Point(25, 285);
            this.btnImportLogo.Name = "btnImportLogo";
            this.btnImportLogo.Size = new System.Drawing.Size(81, 36);
            this.btnImportLogo.TabIndex = 7;
            this.btnImportLogo.Text = "Import";
            this.btnImportLogo.UseVisualStyleBackColor = true;
            this.btnImportLogo.Click += new System.EventHandler(this.btnImportLogo_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblLogo.Location = new System.Drawing.Point(21, 27);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(61, 22);
            this.lblLogo.TabIndex = 6;
            this.lblLogo.Text = "Logo:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblNumber.Location = new System.Drawing.Point(287, 122);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(128, 33);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblName.Location = new System.Drawing.Point(287, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 33);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.txtNumber.Location = new System.Drawing.Point(291, 158);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(84, 40);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.txtName.Location = new System.Drawing.Point(291, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 40);
            this.txtName.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.listBox);
            this.tabPage2.Controls.Add(this.lblParties);
            this.tabPage2.Controls.Add(this.cmbParties);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Members";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemove.Location = new System.Drawing.Point(316, 298);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 30);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(22, 67);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(373, 225);
            this.listBox.TabIndex = 2;
            // 
            // lblParties
            // 
            this.lblParties.AutoSize = true;
            this.lblParties.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblParties.Location = new System.Drawing.Point(19, 27);
            this.lblParties.Name = "lblParties";
            this.lblParties.Size = new System.Drawing.Size(108, 33);
            this.lblParties.TabIndex = 1;
            this.lblParties.Text = "Parties:";
            // 
            // cmbParties
            // 
            this.cmbParties.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbParties.FormattingEnabled = true;
            this.cmbParties.Location = new System.Drawing.Point(133, 36);
            this.cmbParties.Name = "cmbParties";
            this.cmbParties.Size = new System.Drawing.Size(121, 25);
            this.cmbParties.TabIndex = 0;
            this.cmbParties.SelectedIndexChanged += new System.EventHandler(this.cmbParties_SelectedIndexChanged);
            this.cmbParties.Click += new System.EventHandler(this.cmbParties_Click);
            // 
            // ofdPhoto
            // 
            this.ofdPhoto.FileName = "openFileDialog1";
            // 
            // fmrManageParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(650, 436);
            this.Controls.Add(this.tabControlCreate);
            this.Name = "fmrManageParty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrManageParty";
            this.tabControlCreate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabControl tabControlCreate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnImportLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblParties;
        private System.Windows.Forms.ComboBox cmbParties;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.OpenFileDialog ofdPhoto;
    }
}