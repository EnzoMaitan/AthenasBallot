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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelActivities = new System.Windows.Forms.Panel();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnLogout.Location = new System.Drawing.Point(13, 436);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 31);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageProcess
            // 
            this.btnManageProcess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageProcess.FlatAppearance.BorderSize = 0;
            this.btnManageProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProcess.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnManageProcess.Location = new System.Drawing.Point(13, 111);
            this.btnManageProcess.Name = "btnManageProcess";
            this.btnManageProcess.Size = new System.Drawing.Size(137, 57);
            this.btnManageProcess.TabIndex = 1;
            this.btnManageProcess.Text = "Manage Process";
            this.btnManageProcess.UseVisualStyleBackColor = false;
            this.btnManageProcess.Click += new System.EventHandler(this.btnManageProcess_Click);
            // 
            // btnManageCandidate
            // 
            this.btnManageCandidate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageCandidate.FlatAppearance.BorderSize = 0;
            this.btnManageCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCandidate.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnManageCandidate.Location = new System.Drawing.Point(13, 174);
            this.btnManageCandidate.Name = "btnManageCandidate";
            this.btnManageCandidate.Size = new System.Drawing.Size(137, 57);
            this.btnManageCandidate.TabIndex = 2;
            this.btnManageCandidate.Text = "Manage Candidates";
            this.btnManageCandidate.UseVisualStyleBackColor = false;
            this.btnManageCandidate.Click += new System.EventHandler(this.btnManageCandidate_Click);
            // 
            // btnManageVoters
            // 
            this.btnManageVoters.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageVoters.FlatAppearance.BorderSize = 0;
            this.btnManageVoters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageVoters.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnManageVoters.Location = new System.Drawing.Point(13, 48);
            this.btnManageVoters.Name = "btnManageVoters";
            this.btnManageVoters.Size = new System.Drawing.Size(137, 57);
            this.btnManageVoters.TabIndex = 3;
            this.btnManageVoters.Text = "Manage Voters";
            this.btnManageVoters.UseVisualStyleBackColor = false;
            this.btnManageVoters.Click += new System.EventHandler(this.btnManageVoters_Click);
            // 
            // btnManageSystemOperator
            // 
            this.btnManageSystemOperator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageSystemOperator.FlatAppearance.BorderSize = 0;
            this.btnManageSystemOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSystemOperator.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnManageSystemOperator.Location = new System.Drawing.Point(13, 237);
            this.btnManageSystemOperator.Name = "btnManageSystemOperator";
            this.btnManageSystemOperator.Size = new System.Drawing.Size(137, 57);
            this.btnManageSystemOperator.TabIndex = 4;
            this.btnManageSystemOperator.Text = "Manage System Operators";
            this.btnManageSystemOperator.UseVisualStyleBackColor = false;
            // 
            // btnManageParties
            // 
            this.btnManageParties.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageParties.FlatAppearance.BorderSize = 0;
            this.btnManageParties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageParties.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnManageParties.Location = new System.Drawing.Point(13, 300);
            this.btnManageParties.Name = "btnManageParties";
            this.btnManageParties.Size = new System.Drawing.Size(137, 57);
            this.btnManageParties.TabIndex = 5;
            this.btnManageParties.Text = "Manage Political Parties";
            this.btnManageParties.UseVisualStyleBackColor = false;
            this.btnManageParties.Click += new System.EventHandler(this.btnManageParties_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.panelMenu.Controls.Add(this.labelLoggedIn);
            this.panelMenu.Controls.Add(this.btnManageVoters);
            this.panelMenu.Controls.Add(this.btnManageParties);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnManageProcess);
            this.panelMenu.Controls.Add(this.btnManageSystemOperator);
            this.panelMenu.Controls.Add(this.btnManageCandidate);
            this.panelMenu.Location = new System.Drawing.Point(-1, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(162, 486);
            this.panelMenu.TabIndex = 6;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelActivities
            // 
            this.panelActivities.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelActivities.Location = new System.Drawing.Point(158, 4);
            this.panelActivities.Name = "panelActivities";
            this.panelActivities.Size = new System.Drawing.Size(666, 475);
            this.panelActivities.TabIndex = 7;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelLoggedIn.Location = new System.Drawing.Point(10, 5);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(86, 17);
            this.labelLoggedIn.TabIndex = 6;
            this.labelLoggedIn.Text = "Logged in as:";
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(828, 483);
            this.Controls.Add(this.panelActivities);
            this.Controls.Add(this.panelMenu);
            this.Name = "fmrMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageProcess;
        private System.Windows.Forms.Button btnManageCandidate;
        private System.Windows.Forms.Button btnManageVoters;
        private System.Windows.Forms.Button btnManageSystemOperator;
        private System.Windows.Forms.Button btnManageParties;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelActivities;
        private System.Windows.Forms.Label labelLoggedIn;
    }
}