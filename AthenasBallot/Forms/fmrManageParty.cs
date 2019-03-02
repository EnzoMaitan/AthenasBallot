using AthenasBallot.Classes.Entities;
using AthenasBallot.DAO;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using AthenasBallot.Classes;

namespace AthenasBallot.Forms
{
    public partial class fmrManageParty : Form
    {
        public fmrManageParty()
        {
            InitializeComponent();

            ConfigureCmbParties();
        }

        private void ConfigureCmbParties()
        {
            cmbParties.DropDownStyle = ComboBoxStyle.DropDownList;
            var partyDAO = new PartyDAO();
            var parties = partyDAO.Parties();
            foreach (var party in parties)
            {
                cmbParties.Items.Add(party.Name);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var number = Convert.ToInt32(txtNumber.Text);
                PictureBoxImageLoader p = new PictureBoxImageLoader();

                var party = new Party(txtName.Text, number,p.ConvertPictureBoxImageToByteArray(pictureBox));

                var partyDAO = new PartyDAO();
                partyDAO.Add(party);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you really want to remove {listBox.SelectedItem} from {cmbParties.SelectedItem} ",
                    "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DissasociatePartyFromCandidate();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }

        private void DissasociatePartyFromCandidate()
        {
            var candidateDAO = new CandidateDAO();
            var candidate = candidateDAO.Candidates().FirstOrDefault(x => x.Name == listBox.SelectedItem.ToString());
            candidate.DisassociateParty();
            candidateDAO.Update(candidate);
        }

        private void cmbParties_Click(object sender, EventArgs e)
        {
            LoadPartiesIntoCmb();
        }

        private void LoadPartiesIntoCmb()
        {
            cmbParties.Items.Clear();
            var partyDAO = new PartyDAO();
            var parties = partyDAO.Parties();

            foreach (var party in parties)
            {
                cmbParties.Items.Add(party.Name);
            }
        }

        private void cmbParties_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            LoadCandidatesIntoListbox();
        }

        private void LoadCandidatesIntoListbox()
        {
            var candidateDAO = new CandidateDAO();
            var partyDAO = new PartyDAO();
            var party = partyDAO.Parties().First(x => x.Name == cmbParties.SelectedItem.ToString());

            var candidates = candidateDAO.Candidates().Where(x => x.PartyID == party.Id);
            foreach (var candidate in candidates)
            {
                listBox.Items.Add(candidate.Name);
            }
        }

        private void btnImportLogo_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBoxImageLoader p = new PictureBoxImageLoader();
                ofdPhoto.Reset();
                p.ConfigureOpenFileDialog(ofdPhoto);
                if (ofdPhoto.ShowDialog() == DialogResult.OK)
                {
                    ofdPhoto.OpenFile();
                    p.LoadImageIntoPictureBox(pictureBox,ofdPhoto);
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterInputToOnlyAllowNumbers(e);
        }
       
        private static void FilterInputToOnlyAllowNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
