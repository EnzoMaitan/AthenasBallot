namespace AthenasBallot.Forms
{
    partial class fmrMenu
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageProcess = new System.Windows.Forms.Button();
            this.btnManageCandidate = new System.Windows.Forms.Button();
            this.btnManageVoters = new System.Windows.Forms.Button();
            this.btnManageSystemOperator = new System.Windows.Forms.Button();
            this.btnManageParties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(571, 370);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageProcess
            // 
            this.btnManageProcess.Location = new System.Drawing.Point(32, 92);
            this.btnManageProcess.Name = "btnManageProcess";
            this.btnManageProcess.Size = new System.Drawing.Size(137, 57);
            this.btnManageProcess.TabIndex = 1;
            this.btnManageProcess.Text = "Manage Process";
            this.btnManageProcess.UseVisualStyleBackColor = true;
            this.btnManageProcess.Click += new System.EventHandler(this.btnManageProcess_Click);
            // 
            // btnManageCandidate
            // 
            this.btnManageCandidate.Location = new System.Drawing.Point(32, 155);
            this.btnManageCandidate.Name = "btnManageCandidate";
            this.btnManageCandidate.Size = new System.Drawing.Size(137, 57);
            this.btnManageCandidate.TabIndex = 2;
            this.btnManageCandidate.Text = "Manage Candidates";
            this.btnManageCandidate.UseVisualStyleBackColor = true;
            this.btnManageCandidate.Click += new System.EventHandler(this.btnManageCandidate_Click);
            // 
            // btnManageVoters
            // 
            this.btnManageVoters.Location = new System.Drawing.Point(32, 29);
            this.btnManageVoters.Name = "btnManageVoters";
            this.btnManageVoters.Size = new System.Drawing.Size(137, 57);
            this.btnManageVoters.TabIndex = 3;
            this.btnManageVoters.Text = "Manage Voters";
            this.btnManageVoters.UseVisualStyleBackColor = true;
            this.btnManageVoters.Click += new System.EventHandler(this.btnManageVoters_Click);
            // 
            // btnManageSystemOperator
            // 
            this.btnManageSystemOperator.Location = new System.Drawing.Point(32, 218);
            this.btnManageSystemOperator.Name = "btnManageSystemOperator";
            this.btnManageSystemOperator.Size = new System.Drawing.Size(137, 57);
            this.btnManageSystemOperator.TabIndex = 4;
            this.btnManageSystemOperator.Text = "Manage System Operators";
            this.btnManageSystemOperator.UseVisualStyleBackColor = true;
            // 
            // btnManageParties
            // 
            this.btnManageParties.Location = new System.Drawing.Point(32, 281);
            this.btnManageParties.Name = "btnManageParties";
            this.btnManageParties.Size = new System.Drawing.Size(137, 57);
            this.btnManageParties.TabIndex = 5;
            this.btnManageParties.Text = "Manage Political Parties";
            this.btnManageParties.UseVisualStyleBackColor = true;
            this.btnManageParties.Click += new System.EventHandler(this.btnManageParties_Click);
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageParties);
            this.Controls.Add(this.btnManageSystemOperator);
            this.Controls.Add(this.btnManageVoters);
            this.Controls.Add(this.btnManageCandidate);
            this.Controls.Add(this.btnManageProcess);
            this.Controls.Add(this.btnLogout);
            this.Name = "fmrMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageProcess;
        private System.Windows.Forms.Button btnManageCandidate;
        private System.Windows.Forms.Button btnManageVoters;
        private System.Windows.Forms.Button btnManageSystemOperator;
        private System.Windows.Forms.Button btnManageParties;
    }
}