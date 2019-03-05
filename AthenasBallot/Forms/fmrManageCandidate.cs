using AthenasBallot.Classes.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AthenasBallot.Classes;
using AthenasBallot.DAO;

namespace AthenasBallot.Forms
{
    public partial class fmrManageCandidate : Form
    {
        public fmrManageCandidate()
        {
            InitializeComponent();
            lblError.Visible = false;      
            ConfigureCmbSex();
            ConfigureCmbParties();
            ConfigureTextboxPlaceholders();
        }
    
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Party party = new Party();
                party = GetParty();

                var sex = Convert.ToChar(cmbSex.SelectedItem);
                PictureBoxImageLoader p = new PictureBoxImageLoader();

                var candidate = new Candidate(txtName.Text, txtStudentNumber.Text
                    , txtStudentClass.Text, sex, p.ConvertPictureBoxImageToByteArray(pictureBox), party.Id);

                var candidateDAO = new CandidateDAO();
                candidateDAO.Add(candidate);

                MessageBox.Show("Candidate Registered");
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

       
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBoxImageLoader p = new PictureBoxImageLoader();
                ofdPhoto.Reset();
                p.ConfigureOpenFileDialog(ofdPhoto);
                if (ofdPhoto.ShowDialog() == DialogResult.OK)
                {
                    ofdPhoto.OpenFile();
                    p.LoadImageIntoPictureBox(pictureBox, ofdPhoto);
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        private void ConfigureCmbParties()
        {
            cmbParty.DropDownStyle = ComboBoxStyle.DropDownList;
            var partyDAO = new PartyDAO();
            var parties = partyDAO.Parties();
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
        private Party GetParty()
        {
            var partyDAO = new PartyDAO();
            return partyDAO.Parties().FirstOrDefault(x => x.Name == Convert.ToString(cmbParty.SelectedItem));
        }
        private void ConfigureTextboxPlaceholders()
        {
            var t1 = new TextboxPlaceHolderConfigurator(txtStudentClass, "Candidate's Class");
            t1.ConfigureTextBox();
            var t2 = new TextboxPlaceHolderConfigurator(txtName, "Candidate's name");
            t2.ConfigureTextBox();
            var t3 = new TextboxPlaceHolderConfigurator(txtStudentNumber, "Student Number");
            t3.ConfigureTextBox();
        }
    }
}
