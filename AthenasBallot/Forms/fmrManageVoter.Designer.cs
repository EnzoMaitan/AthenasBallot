namespace AthenasBallot.Forms
{
    partial class fmrManageVoter
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ofdReadCsv = new System.Windows.Forms.OpenFileDialog();
            this.dtgVoters = new System.Windows.Forms.DataGridView();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVoters)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(535, 391);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 33);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(297, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Voters to be registered:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(627, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 31;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblError.ForeColor = System.Drawing.Color.Coral;
            this.lblError.Location = new System.Drawing.Point(297, 361);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(38, 19);
            this.lblError.TabIndex = 30;
            this.lblError.Text = "Error";
            // 
            // btnImportCSV
            // 
            this.btnImportCSV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportCSV.Location = new System.Drawing.Point(553, 271);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(68, 28);
            this.btnImportCSV.TabIndex = 28;
            this.btnImportCSV.Text = "Import File";
            this.btnImportCSV.UseVisualStyleBackColor = false;
            this.btnImportCSV.Click += new System.EventHandler(this.btnImportCSV_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblRegister.Location = new System.Drawing.Point(15, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(203, 22);
            this.lblRegister.TabIndex = 27;
            this.lblRegister.Text = "Add Individual Voter";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.Location = new System.Drawing.Point(170, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 29);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblClass.Location = new System.Drawing.Point(28, 158);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(66, 23);
            this.lblClass.TabIndex = 25;
            this.lblClass.Text = "Class:";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblStudentNumber.Location = new System.Drawing.Point(28, 245);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(175, 23);
            this.lblStudentNumber.TabIndex = 24;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblName.Location = new System.Drawing.Point(28, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 23);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtStudentNumber.Location = new System.Drawing.Point(32, 271);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(198, 32);
            this.txtStudentNumber.TabIndex = 22;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtClass.Location = new System.Drawing.Point(32, 184);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(198, 32);
            this.txtClass.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(32, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 32);
            this.txtName.TabIndex = 20;
            // 
            // ofdReadCsv
            // 
            this.ofdReadCsv.FileName = "openFileDialog1";
            // 
            // dtgVoters
            // 
            this.dtgVoters.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgVoters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVoters.Location = new System.Drawing.Point(301, 56);
            this.dtgVoters.Name = "dtgVoters";
            this.dtgVoters.Size = new System.Drawing.Size(346, 209);
            this.dtgVoters.TabIndex = 34;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.Coral;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Location = new System.Drawing.Point(324, 271);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(72, 28);
            this.btnRemoveAll.TabIndex = 35;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // fmrManageVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(650, 436);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.dtgVoters);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnImportCSV);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Name = "fmrManageVoter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgVoters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnImportCSV;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.OpenFileDialog ofdReadCsv;
        private System.Windows.Forms.DataGridView dtgVoters;
        private System.Windows.Forms.Button btnRemoveAll;
    }
}