namespace AthenasBallot.Forms
{
    partial class fmrManageCandidate
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentClass = new System.Windows.Forms.TextBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbParty = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ofdPhoto = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtName.Location = new System.Drawing.Point(243, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 34);
            this.txtName.TabIndex = 0;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtStudentNumber.Location = new System.Drawing.Point(243, 137);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(216, 34);
            this.txtStudentNumber.TabIndex = 1;
            // 
            // txtStudentClass
            // 
            this.txtStudentClass.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtStudentClass.Location = new System.Drawing.Point(243, 202);
            this.txtStudentClass.Name = "txtStudentClass";
            this.txtStudentClass.Size = new System.Drawing.Size(216, 34);
            this.txtStudentClass.TabIndex = 2;
            // 
            // cmbSex
            // 
            this.cmbSex.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(243, 267);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(41, 32);
            this.cmbSex.TabIndex = 3;
            // 
            // cmbParty
            // 
            this.cmbParty.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.cmbParty.FormattingEnabled = true;
            this.cmbParty.Location = new System.Drawing.Point(243, 330);
            this.cmbParty.Name = "cmbParty";
            this.cmbParty.Size = new System.Drawing.Size(126, 32);
            this.cmbParty.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnRegister.Location = new System.Drawing.Point(553, 430);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 33);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImage.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnLoadImage.Location = new System.Drawing.Point(50, 248);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(132, 32);
            this.btnLoadImage.TabIndex = 6;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(26, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(182, 203);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(238, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.Location = new System.Drawing.Point(238, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.Location = new System.Drawing.Point(238, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Candidate\'s Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label4.Location = new System.Drawing.Point(238, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label5.Location = new System.Drawing.Point(238, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Party";
            // 
            // ofdPhoto
            // 
            this.ofdPhoto.FileName = "openFileDialog1";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblError.ForeColor = System.Drawing.Color.Coral;
            this.lblError.Location = new System.Drawing.Point(279, 379);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(38, 19);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "Error";
            // 
            // fmrManageCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(666, 475);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbParty);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.txtStudentClass);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrManageCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fmrManageCandidate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentClass;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbParty;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofdPhoto;
        private System.Windows.Forms.Label lblError;
    }
}