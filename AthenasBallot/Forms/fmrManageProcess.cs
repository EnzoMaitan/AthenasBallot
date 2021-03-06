﻿using System;
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
            ConfigureDateTimePickerDisplayMode(dtpEndDate);
            ConfigureDateTimePickerDisplayMode(dtpStartDate);
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

        private void ConfigureDateTimePickerDisplayMode(DateTimePicker dtp)
        {
            dtp.CustomFormat = "HH:mm - dd/MM";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnEndProcess_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnManageParticipants_Click(object sender, EventArgs e)
        {

        }

        private void lblDateFormat_Click(object sender, EventArgs e)
        {

        }
    }
}
