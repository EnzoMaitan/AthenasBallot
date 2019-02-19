using System;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
            labelLoggedIn.Text += " " +FmrLogin.LoggedOperator.Name;
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
            ClearPanel();
            var fmrManageVoter = new fmrManageVoter()
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelActivities.Controls.Add(fmrManageVoter);
            fmrManageVoter.Show();
        }

        private void btnManageCandidate_Click(object sender, EventArgs e)
        {
            ClearPanel();
            var fmrManageCandidate = new fmrManageCandidate()
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelActivities.Controls.Add(fmrManageCandidate);
            fmrManageCandidate.Show();
        }

        private void btnManageProcess_Click(object sender, EventArgs e)
        {
            ClearPanel();
            var fmrManageProcess = new fmrManageProcess()
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelActivities.Controls.Add(fmrManageProcess);
            fmrManageProcess.Show();
        }

        private void btnManageParties_Click(object sender, EventArgs e)
        {
            ClearPanel();
            var fmrManageParty = new fmrManageParty()
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None
            };
            panelActivities.Controls.Add(fmrManageParty);
            fmrManageParty.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FmrLogin.LoggedOperator = null;
            var fmrlogin = new FmrLogin();
            fmrlogin.Show();
            this.Dispose();
        }

        private void ClearPanel()
        {
            if (panelActivities != null)
            {
                while (panelActivities.Controls.Count > 0)
                {
                    panelActivities.Controls[0].Dispose();
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
