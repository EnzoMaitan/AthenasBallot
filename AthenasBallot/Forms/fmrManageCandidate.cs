using AthenasBallot.Classes.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using AthenasBallot.DAO;

namespace AthenasBallot.Forms
{
    public partial class fmrManageCandidate : Form
    {
        public fmrManageCandidate()
        {
            InitializeComponent();
            ConfigureCmbSex();
            ConfigureCmbParties();
        }

        private void ConfigureCmbParties()
        {
            cmbParty.DropDownStyle = ComboBoxStyle.DropDownList;
            var partyDAO = new PartyDAO();
            var parties =  partyDAO.Parties();
            foreach (var party in parties)
            {
                cmbParty.Items.Add(party.Name);
            }
        }

        private void ConfigureCmbSex()
        {
            cmbSex.Items.Add("M");
            cmbSex.Items.Add("F");
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var fmrMenu = new fmrMenu();
            fmrMenu.Show();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Party party = new Party();
                party = GetParty();

                var sex = Convert.ToChar(cmbSex.SelectedItem);

                var candidate = new Candidate(txtName.Text, txtStudentNumber.Text
                    , txtStudentClass.Text, sex, null, party.Id);

                var candidateDAO = new CandidateDAO();
                candidateDAO.Add(candidate);

                MessageBox.Show("Candidate Registered");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Party GetParty()
        {
            var partyDAO = new PartyDAO();
            return partyDAO.Parties().FirstOrDefault(x => x.Name == Convert.ToString(cmbParty.SelectedItem));
        }
    }
}
