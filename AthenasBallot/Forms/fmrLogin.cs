﻿using AthenasBallot.Classes.Entities;
using System;
using System.Windows.Forms;

namespace AthenasBallot.Forms
{
    public partial class FmrLogin : Form
    {
        public static SystemOperator LoggedOperator;
        public FmrLogin()
        {
            InitializeComponent();
            ConfigureTextboxPlaceholders();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
               var systemOperator = new SystemOperator();           
               if (systemOperator.Authenticate(txtLogin.Text, txtPassword.Text))
               {
                    systemOperator.SetCredentialsFromDataBase(txtLogin.Text, txtPassword.Text);
                    LoggedOperator = systemOperator;

                    var fmrMenu = new fmrMenu();
                    fmrMenu.Show();
                    this.Hide();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigureTextboxPlaceholders()
        {
            var t1 = new TextboxPlaceHolderConfigurator(txtLogin, "User login");
            t1.ConfigureTextBox();
            var t2 = new TextboxPlaceHolderConfigurator(txtPassword, "User password");
            t2.ConfigureTextBox();
        }
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
