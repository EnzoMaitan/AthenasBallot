using AthenasBallot.Classes.Entities;
using System;
using System.Drawing;
using System.IO;
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
            lblError.Visible = false;      
            ConfigureCmbSex();
            ConfigureCmbParties();
        }
    
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Party party = new Party();
                party = GetParty();

                var sex = Convert.ToChar(cmbSex.SelectedItem);

                var candidate = new Candidate(txtName.Text, txtStudentNumber.Text
                    , txtStudentClass.Text, sex, ConvertPictureBoxImageToByteArray(), party.Id);

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

        private byte[] ConvertPictureBoxImageToByteArray()
        {
            MemoryStream ms = new MemoryStream();

            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.GetBuffer();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                ofdPhoto.Reset();
                ConfigureOpenFileDialog();
                if (ofdPhoto.ShowDialog() == DialogResult.OK)
                {
                    ofdPhoto.OpenFile();
                    LoadImageIntoPictureBox();
                }          
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        private void LoadImageIntoPictureBox()
        {
            pictureBox.Image = Image.FromFile(ofdPhoto.FileName);
        }
        private void ConfigureOpenFileDialog()
        {
            ofdPhoto.Filter = "Image(*.JPG;*PNG;*.IMG,*.JPEG)|*.JPG;*PNG;*.IMG,*.JPEG";
            ofdPhoto.RestoreDirectory = true;
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

    }
}
