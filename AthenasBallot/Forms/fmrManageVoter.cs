using AthenasBallot.Classes.Entities;
using AthenasBallot.DAO;
using System;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public partial class fmrManageVoter : Form
    {
        public fmrManageVoter()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SaveNewVoter();
                MessageBox.Show("Voter Saved on the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveNewVoter()
        {
            var voterDAO = new VoterDAO();
            voterDAO.Add(new Voter(txtName.Text, txtStudentNumber.Text, txtClass.Text));
        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {

        }
    }
}
