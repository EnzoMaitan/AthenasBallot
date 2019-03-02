using AthenasBallot.Classes.Entities;
using AthenasBallot.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public partial class fmrManageVoter : Form
    {
        private List<Voter> _voters = new List<Voter>();

        public fmrManageVoter()
        {
            InitializeComponent();
            DataGridFormater dgf = new DataGridFormater(dtgVoters, this);
            dgf.FormatDatagrid();
            lblError.Visible = false;
        }

        public void RemoveVoter(string voterName)
        {
            _voters.RemoveAll(x => voterName == x.Name);
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
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
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
                dtgVoters.Rows.Clear();
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
            dtgVoters.Rows.Add(voter.Name,voter.StudentNumber,voter.StudentClass);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            _voters.Clear();
            dtgVoters.Rows.Clear();
        }
    }

    class DataGridFormater
    {
        private readonly DataGridView _dtg;
        private readonly fmrManageVoter _fmrManageVoter;
        public DataGridFormater(DataGridView dtg, fmrManageVoter fmrManageVoter)
        {
            _dtg = dtg;
            _fmrManageVoter = fmrManageVoter;
        }

        public void FormatDatagrid()
        {
            CreateRowsAndAddRows();
            _dtg.ScrollBars = ScrollBars.Vertical;
            _dtg.AllowUserToAddRows = false;
            _dtg.AllowUserToResizeRows = false;
            _dtg.AllowUserToResizeColumns = false;
            _dtg.RowHeadersVisible = false;

            _dtg.CellClick += grd_CellClick;
            _dtg.CellPainting += dtg_CellPainting;

            _dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isRemoveButton = e.ColumnIndex == 3 && e.RowIndex >= 0;
            if (isRemoveButton)
            {
                var voter = _dtg.Rows[e.RowIndex].Cells[0].Value.ToString();
                RemoveRow(e);
                _fmrManageVoter.RemoveVoter(voter);
            }
        }
        private void RemoveRow(DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you really want to Remove?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                _dtg.Rows.RemoveAt(e.RowIndex);
        }
        private void CreateRowsAndAddRows()
        {
            DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
            buttonDelete.Width = 70;
            DataGridViewTextBoxColumn dtgVoterName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dtgVoterNumber = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dtgVoterClass = new DataGridViewTextBoxColumn();
            _dtg.Columns.Add(dtgVoterName);
            _dtg.Columns.Add(dtgVoterNumber);
            _dtg.Columns.Add(dtgVoterClass);
            _dtg.Columns.Add(buttonDelete);
        }

        private void dtg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            bool isRemoveButton = e.ColumnIndex == 3 && e.RowIndex >= 0;

            if (isRemoveButton)
                DrawRemoveButton(e, "AthenasBallot.Images.remove.ico");
        }

        private void DrawRemoveButton(DataGridViewCellPaintingEventArgs e, string imagePath)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            using (Stream imageStream = GetImage(imagePath))
            {
                var ico = new Icon(imageStream, 10, 10);
                int x = (e.CellBounds.X + (e.CellBounds.Width / 2)) - 10;
                int y = (e.CellBounds.Y + (e.CellBounds.Height / 2)) - 10;
                e.Graphics.DrawIcon(ico, x, y);
                e.Handled = true;
            }
        }

        public Stream GetImage(string imagePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceStream(imagePath);
        }
    }
}
