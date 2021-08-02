using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BUS;

namespace Project1
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        public bool validInput()
        {
            string name = txtAccount.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();

            if (name == "" || pass == "" || confirmPass == "") return false;

            Regex regex = new Regex("^([a-zA-Z0-9/./@_]+)$");
            if (!regex.IsMatch(name) || !regex.IsMatch(pass) || !regex.IsMatch(confirmPass)) return false;

            return true;
        }
        public void resetInfor()
        {
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
            txtAccount.Focus();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (validInput())
            {
                string account = txtAccount.Text.Trim();
                string pass = txtPassword.Text.Trim();
                string confirmPass = txtConfirmPass.Text.Trim();
                if (!(new BUSUser()).checkAccountExist(account))
                {
                    if (pass.Equals(confirmPass))
                    {
                        if((new BUSUser()).register(account,pass))
                        {
                            MessageBox.Show("Register successfully!");
                            this.Hide();
                            new FrmLogin(account, pass).ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Register fail!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The passwords and Confirm passwords must match. Please re-type them.",
                            "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        resetInfor();
                    }
                }
                else
                {
                    MessageBox.Show("Your account exist!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resetInfor();
                }

            }
            else
            {
                MessageBox.Show("Check your information!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetInfor();
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmWelcome().ShowDialog();
            this.Close();
        }
    }
}
