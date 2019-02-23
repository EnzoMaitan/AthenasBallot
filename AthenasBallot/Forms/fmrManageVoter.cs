using AthenasBallot.Classes.Entities;
using AthenasBallot.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public partial class fmrManageVoter : Form
    {
        private List<Voter> _voters = new List<Voter>();

        public fmrManageVoter()
        {
            InitializeComponent();
            lblError.Visible = false;
        }


        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                ofdReadCsv.Reset();
                ConfigureOpenFileDialog();
                if (ofdReadCsv.ShowDialog() == DialogResult.OK)
                {
                    ofdReadCsv.OpenFile();
                    ReadFromCsvAndSaveIntoList();

                }
            }
            catch (NullReferenceException ex)
            {
                lblError.Visible = true;
                lblError.Text = "CSV could not be read properly, check if there are any mistakes";
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
            
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
            try
            {
                var voterDAO = new VoterDAO();
                foreach (var voter in _voters)
                {
                    voterDAO.Add(voter);
                }
                MessageBox.Show("Voters Registered!");
                lstVoters.Items.Clear();
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        private void ReadFromCsvAndSaveIntoList()
        {

            using (var reader = new StreamReader(ofdReadCsv.FileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var voter = new Voter(values[0], values[1], values[2]);
                    _voters.Add(voter);
                    InsertVoterIntoListBox(voter);
                }
            }
        }

        private void ConfigureOpenFileDialog()
        {
            ofdReadCsv.Filter = "CSV(*.csv;)|*.csv";
            ofdReadCsv.Multiselect = true;
            ofdReadCsv.RestoreDirectory = true;
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
            lstVoters.Items.Add(voter.Name+" | "+ voter.StudentNumber +" | "+ voter.StudentClass);
        }
    }
}
