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
    public partial class FrmDetailStudent : Form
    {
        public FrmDetailStudent()
        {
            InitializeComponent();
        }


        private string rollNumber, name, DOB, gender, addr, phone, room;


        public FrmDetailStudent(string rollNumber, string name, string DOB, string gender,
                string address, string phone, string roomId)
        {
            InitializeComponent();
            this.rollNumber = rollNumber;
            this.name = name;
            this.DOB = DOB;
            this.gender = gender;
            this.addr = address;
            this.phone = phone;
            this.room = roomId;

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
            string room = txtRoom.Text;

            if ((new BUSStudent()).updateStudent(mssv, name, db, gender, address, phone, room))
            {
                MessageBox.Show("Update successfully");
            }
            else
            {
                MessageBox.Show("Update fail");
            }


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string a = txtMSSV.Text;
            string room = txtRoom.Text;
            if ((new BUSStudent()).deleteStudent(a))
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void setData()
        {
            txtMSSV.Text = rollNumber;
            txtName.Text = name;
            txtBirthdate.Text = DOB;
            //if (gender.Equals("False")) cbGender.SelectedIndex = 1;
            //else cbGender.SelectedIndex = 0;

            if (gender.Equals("Male"))
            {
                cbGender.SelectedIndex = 0;
            }
            else
            {
                cbGender.SelectedIndex = 1;
            }
            txtAddress.Text = addr;
            txtPhonenumber.Text = phone;
            txtRoom.Text = room;
        }

        private void FrmDeatail_Load(object sender, EventArgs e)
        {
            if (rollNumber != null || name != null || DOB != null || gender != null || gender != null || phone != null || room != null)
            {
                setData();
            }
        }
    }
}
