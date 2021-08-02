using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1.Student
{
    public partial class FrmCancel : Form
    {
        public FrmCancel()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string rollNumer = txtAccount.Text.Trim();
            string pass = txtPassword.Text.Trim();

            string sql = "SELECT * FROM Students WHERE rollNumber = '" + rollNumer + "'";
            DataTable dt = new DataTable();
            dt = (new BUSStudent()).searchStudent(sql);
            //check existed in student table(existed in dorm)
            if (dt.Rows.Count > 0)
            {
                string room = dt.Rows[0][6].ToString();
                if ((new BUSUser()).checkUser(rollNumer, pass))
                {
                    if ((new BUSStudent()).deleteStudent(rollNumer))
                    {
                        (new BUSRoom()).countMinus(room);
                        MessageBox.Show("Delete successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Delete fail");
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
                MessageBox.Show("You have not register a room in dorm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetInfor();
            }
            
        }

        public void resetInfor()
        {
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtAccount.Focus();
        }
    }
}
