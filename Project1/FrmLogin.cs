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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        string account, pass;

        public FrmLogin(string accountLogin, string passLogin)
        {
            InitializeComponent();
            account = accountLogin;
            pass = passLogin;
        }

        public void resetInfor()
        {
            txtName.Text = "";
            txtPass.Text = "";
            lblCheckName.ForeColor = Color.Red;
            lblCheckPassword.ForeColor = Color.Red;
            txtName.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetInfor();
        }

        public bool validInput()
        {
            string name = txtName.Text.Trim();
            string pass = txtPass.Text.Trim();
            if (name == "" || pass == "") return false;

            Regex regex = new Regex("^([a-zA-Z0-9/./@_]+)$");
            if (!regex.IsMatch(name) || !regex.IsMatch(pass)) return false;

            return true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validInput())
            {
                string name = txtName.Text.Trim();
                string pass = txtPass.Text.Trim();
                if ((new BUSUser()).checkUser(name, pass))
                {
                    if(isAdmin(name, pass))
                    {
                        this.Hide();
                        new FrmMainAdmin().ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        new FrmMainStudent(name).ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetInfor();
                }
            }
            else
            {
                MessageBox.Show("Check your information!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetInfor();
            }
        }

        private bool isAdmin(string userName, string password)
        {
            if (new BUSUser().isAdmin(userName))
            {
                return true;
            }
            else return false;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length != 0)
            {
                lblCheckName.ForeColor = Color.Blue;
            }
            else
            {
                lblCheckName.ForeColor = Color.Red;
            }
            if (txtPass.Text.Length != 0)
            {
                lblCheckPassword.ForeColor = Color.Blue;
            }
            else
            {
                lblCheckPassword.ForeColor = Color.Red;
            }
        }

        private void Input_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.Pink;
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtName.Text = account;
            txtPass.Text = pass;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmWelcome().ShowDialog();
            this.Close();
        }
    }
}
