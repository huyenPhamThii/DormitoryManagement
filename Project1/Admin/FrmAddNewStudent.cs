using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace Project1
{
    public partial class FrmAddNewStudent : Form
    {
        public FrmAddNewStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            string room = txtRoom.Text;
            if ((new BUSStudent()).checkRollNumberInAcc(mssv))
            {
                if (!(new BUSStudent()).checkRollNumberInStudents(mssv))
                {
                    if ((new BUSStudent()).checkCount(room))
                    {
                        if ((new BUSStudent()).checkGender(gender, room))
                        {
                            if ((new BUSStudent()).addStudent(mssv, name, db, gender, address, phone, room))
                            {
                                MessageBox.Show("Add successfully");
                                (new BUSRoom()).countAdd(room);
                            }
                            else
                            {
                                MessageBox.Show("Add fail");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Gender is incorect");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Room full!");
                    }
                }
                else
                {
                    MessageBox.Show("Student is already have a bed in domitory");
                }
            }
            else
            {
                MessageBox.Show("Student is not register");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMSSV.Text = "";
            txtName.Text = "";
            txtBirthdate.Text = "";
            cbGender.SelectedIndex = -1;
            txtAddress.Text = "";
            txtPhonenumber.Text = "";
            txtRoom.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
