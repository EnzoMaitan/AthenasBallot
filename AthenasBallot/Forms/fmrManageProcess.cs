using System;
using System.Windows.Forms;
using AthenasBallot.Classes.Entities;
using AthenasBallot.DAO;

namespace AthenasBallot.Forms
{
    public partial class fmrManageProcess : Form
    {
        public fmrManageProcess()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var process = new Process(txtName.Text, dtpStartDate.Value, dtpEndDate.Value);

                var processDAO = new ProcessDAO();
                processDAO.Add(process);
                MessageBox.Show("Process saved");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }         
        }

        private void cmbProcesses_MouseClick(object sender, MouseEventArgs e)
        {
            LoadProcessesIntoCmb();
        }

        private void LoadProcessesIntoCmb()
        {
            var processDAO = new ProcessDAO();
            var processes = processDAO.Processes();
            foreach (var process in processes)
            {
                cmbProcesses.Items.Add(process.Name);
            }
        }
    }
}
