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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        public bool validInput()
        {
            string name = txtAccount.Text.Trim();
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirmPass = txtConfirmNewPass.Text.Trim();

            if (name == "" || oldPass == "" || newPass == "" || confirmPass == "") return false;

            Regex regex = new Regex("^([a-zA-Z0-9/./@_]+)$");
            if (!regex.IsMatch(name) || !regex.IsMatch(oldPass) || !regex.IsMatch(newPass) || !regex.IsMatch(confirmPass)) return false;

            return true;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (validInput())
            {
                string name = txtAccount.Text.Trim();
                string pass = txtOldPass.Text.Trim();
                string newPass = txtNewPass.Text.Trim();
                string confirmNewPass = txtConfirmNewPass.Text.Trim();

                if ((new BUSUser()).checkUser(name, pass))
                {
                    if (newPass.Equals(confirmNewPass))
                    {
                        if ((new BUSUser()).changePassword(name, newPass))
                        {
                            MessageBox.Show("Change password successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Change password fail!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The New and Confirm passwords must match. Please re-type them.",
                            "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        resetInfor();
                    }


                }
                else
                {
                    MessageBox.Show("You entered the wrong account or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetInfor();
                }
            }
            else
            {
                MessageBox.Show("Check your information!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetInfor();
            }
        }
        public void resetInfor()
        {
            txtAccount.Text = "";
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmNewPass.Text = "";
            txtAccount.Focus();
        }
    }
}
