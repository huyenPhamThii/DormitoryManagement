using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class FrmStudentProfile : Form
    {
        public FrmStudentProfile()
        {
            InitializeComponent();
        }

        string rollNumber;

        public FrmStudentProfile(string account)
        {
            InitializeComponent();
            rollNumber = account;
        }

        private void FrmStudentInfor_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Students WHERE rollNumber = '" + rollNumber + "'";
            DataTable dt = new DataTable();
            dt = (new BUSStudent()).searchStudent(sql);
            if (dt.Rows.Count > 0)
            {
                txtMSSV.Text = dt.Rows[0][0].ToString();
                txtName.Text = dt.Rows[0][1].ToString();
                txtBirthdate.Text = dt.Rows[0][2].ToString();
                if (dt.Rows[0][3].ToString().Equals("True"))
                {
                    cbGender.SelectedIndex = 0;
                }
                else
                {
                    cbGender.SelectedIndex = 1;
                }
                txtAddress.Text = dt.Rows[0][4].ToString();
                txtPhonenumber.Text = dt.Rows[0][5].ToString();
                if (dt.Rows[0][6].ToString().Equals("A0"))
                {
                    txtRoom.Text = "";
                }
                else
                {
                    txtRoom.Text = dt.Rows[0][6].ToString();

                }
            }
            else
            {
                lblMess.Text = "You have not registered for the dormitory";
                txtMSSV.Text = rollNumber;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string name = txtName.Text;
            string db = txtBirthdate.Text;
            int gender = 1;
            if (cbGender.SelectedIndex == 0)
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }
            string address = txtAddress.Text;
            string phone = txtPhonenumber.Text;

            //check if have information in student table -> update
            //else -> reject
            string sql = "SELECT * FROM Students WHERE rollNumber = '" + rollNumber + "'";
            DataTable dt = new DataTable();
            dt = (new BUSStudent()).searchStudent(sql);
            if (isValidInput(name, db, address, phone))
            {
                if (dt.Rows.Count > 0)
                {
                    string room = dt.Rows[0][6].ToString();

                    if ((new BUSStudent()).updateStudent(mssv, name, db, gender, address, phone, room))
                    {
                        MessageBox.Show("Update successfully");

                    }
                    else
                    {
                        MessageBox.Show("Update fail");
                    }
                }
                else
                {
                    string room = "A0";

                    if ((new BUSStudent()).addStudent(mssv, name, db, gender, address, phone, room))
                    {
                        MessageBox.Show("Update successfully");

                    }
                    else
                    {
                        MessageBox.Show("Update fail");
                    }
                }
            }
            else
            {
                MessageBox.Show("Check your information!!!", "Alert");
            }
        }


        public bool isValidInput(string name, string dob, string addr, string phone)
        {
            if (rollNumber == "" || name == "" || dob == "" || addr == "" || phone == "") return false;

            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtBirthdate.Text = "";
            cbGender.SelectedIndex = 0;
            txtAddress.Text = "";
            txtPhonenumber.Text = "";
        }
    }
}
