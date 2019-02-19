using AthenasBallot.Classes.Entities;
using AthenasBallot.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public partial class fmrManageVoter : Form
    {
        private List<Voter> _voters = new List<Voter>();

        public fmrManageVoter()
        {
            lblError.Visible = false;
            InitializeComponent();
        }


        private void btnImportCSV_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddVoter();
                CleanFields();
            }
            catch (ArgumentNullException ex)
            {
                lblError.Visible = true;
                if (ex.Message.Contains("studentNumber"))
                {
                    lblError.Text = "Error: Student Number must have a value";
                }
                else if (ex.Message.Contains("name"))
                {
                    lblError.Text = "Error: Name must have a value";
                }
                else if (ex.Message.Contains("studentClass"))
                {
                    lblError.Text = "Error: Class must have a value";
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var voterDAO = new VoterDAO();
            foreach (var voter in _voters)
            {
                voterDAO.Add(voter);
            }
        }

        private void AddVoter()
        {
            var voter = new Voter(txtName.Text, txtStudentNumber.Text, txtClass.Text);
            _voters.Add(voter);
            InsertVoterIntoListBox(voter);
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtStudentNumber.Text = "";
            txtClass.Text = "";
        }

        private void InsertVoterIntoListBox(Voter voter)
        {
            lstVoters.Items.Add(voter.Name);
        }

    }
}
