namespace AthenasBallot.Forms
{
    partial class fmrManageProcess
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tabControlProcess = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProcesses = new System.Windows.Forms.ComboBox();
            this.btnManageParticipants = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.tabControlProcess.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(138, 62);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(156, 27);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(441, 62);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(156, 27);
            this.dtpEndDate.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtName.Location = new System.Drawing.Point(97, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 34);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblName.Location = new System.Drawing.Point(6, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblStart.Location = new System.Drawing.Point(6, 62);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(126, 25);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.Location = new System.Drawing.Point(318, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnRegister.Location = new System.Drawing.Point(549, 391);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(102, 36);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tabControlProcess
            // 
            this.tabControlProcess.Controls.Add(this.tabPage1);
            this.tabControlProcess.Controls.Add(this.tabPage2);
            this.tabControlProcess.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.tabControlProcess.Location = new System.Drawing.Point(0, 0);
            this.tabControlProcess.Name = "tabControlProcess";
            this.tabControlProcess.SelectedIndex = 0;
            this.tabControlProcess.Size = new System.Drawing.Size(666, 475);
            this.tabControlProcess.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDateFormat);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Controls.Add(this.dtpStartDate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpEndDate);
            this.tabPage1.Controls.Add(this.lblStart);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbProcesses);
            this.tabPage2.Controls.Add(this.btnManageParticipants);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnEndProcess);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Process:";
            // 
            // cmbProcesses
            // 
            this.cmbProcesses.FormattingEnabled = true;
            this.cmbProcesses.Location = new System.Drawing.Point(169, 38);
            this.cmbProcesses.Name = "cmbProcesses";
            this.cmbProcesses.Size = new System.Drawing.Size(121, 38);
            this.cmbProcesses.TabIndex = 4;
            this.cmbProcesses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbProcesses_MouseClick);
            // 
            // btnManageParticipants
            // 
            this.btnManageParticipants.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnManageParticipants.Location = new System.Drawing.Point(53, 148);
            this.btnManageParticipants.Name = "btnManageParticipants";
            this.btnManageParticipants.Size = new System.Drawing.Size(308, 45);
            this.btnManageParticipants.TabIndex = 3;
            this.btnManageParticipants.Text = "Manage Participants";
            this.btnManageParticipants.UseVisualStyleBackColor = true;
            this.btnManageParticipants.Click += new System.EventHandler(this.btnManageParticipants_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnDelete.Location = new System.Drawing.Point(245, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnEndProcess.Location = new System.Drawing.Point(149, 99);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(90, 43);
            this.btnEndProcess.TabIndex = 1;
            this.btnEndProcess.Text = "End";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnStart.Location = new System.Drawing.Point(53, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 202);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblDateFormat.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDateFormat.Location = new System.Drawing.Point(187, 37);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(239, 21);
            this.lblDateFormat.TabIndex = 9;
            this.lblDateFormat.Text = "Hour:Minute  - Day/Month";
            this.lblDateFormat.Click += new System.EventHandler(this.lblDateFormat_Click);
            // 
            // fmrManageProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(666, 475);
            this.Controls.Add(this.tabControlProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrManageProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrManageProcess";
            this.tabControlProcess.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TabControl tabControlProcess;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProcesses;
        private System.Windows.Forms.Button btnManageParticipants;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDateFormat;
    }
}