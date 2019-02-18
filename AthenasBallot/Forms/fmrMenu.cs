using System;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();

            if (FmrLogin.LoggedOperator.Role == Classes.Entities.Role.ElectionJudge)
            {
                btnManageCandidate.Enabled = false;
                btnManageProcess.Enabled = false;
                btnManageSystemOperator.Enabled = false;
                btnManageVoters.Enabled = false;
            }
        }

        private void btnManageVoters_Click(object sender, EventArgs e)
        {
            var fmrManageVoter = new fmrManageVoter();
            fmrManageVoter.Show();
            this.Hide();
        }

        private void btnManageCandidate_Click(object sender, EventArgs e)
        {
            var fmrManageCandidate = new fmrManageCandidate();
            fmrManageCandidate.Show();
            this.Hide();
        }

        private void btnManageProcess_Click(object sender, EventArgs e)
        {
            var fmrManageProcess = new fmrManageProcess();
            fmrManageProcess.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FmrLogin.LoggedOperator = null;
            var fmrlogin = new FmrLogin();
            fmrlogin.Show();
            this.Dispose();
        }

        private void btnManageParties_Click(object sender, EventArgs e)
        {
            var fmrManageParty = new fmrManageParty();
            fmrManageParty.Show();
            this.Hide();
        }
    }
}
