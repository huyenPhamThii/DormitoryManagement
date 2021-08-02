using BUS;
using Project1.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project1
{
    public partial class FrmBooking : Form
    {
        public FrmBooking()
        {
            InitializeComponent();

        }

        string rollNumber, rooms;

        public FrmBooking(string account, string room)
        {
            InitializeComponent();
            rollNumber = account;
            cbGender.SelectedIndex = 0;
            rooms = room;
        }

        public FrmBooking(string account)
        {
            InitializeComponent();
            rollNumber = account;
            cbGender.SelectedIndex = 0;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string rollNumber = txtRollNumber.Text.Trim();
            string name = txtName.Text.Trim();
            string dob = txtBirthdate.Text.Trim();
            int gender = cbGender.SelectedIndex == 0 ? 1 : 0;
            string addr = txtAddress.Text.Trim();
            string phone = txtPhonenumber.Text.Trim();
            string room = txtRoom.Text.Trim();
            int status = 2;
            string note = rtxtNote.Text.Trim();

            if (!isValidInput(rollNumber, name, dob, addr, phone, room))
            {
                MessageBox.Show("Check your information again.", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                if (!isFreeRoom(room))
                {
                    MessageBox.Show("This room is full slot. Select another room.", "Notification", MessageBoxButtons.OK);
                }
                else
                {
                    if (!isRightGender(gender, room))
                    {
                        MessageBox.Show("You select wrong type of room! Check your gender.", "Notification", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (isRequestValid(rollNumber))
                        {
                            try
                            {
                                string sql = "INSERT INTO Booking VALUES('" + rollNumber + "', '" + name + "', '" + dob + "', " + gender + ", '" + addr + "', '" + phone + "', '" + room + "'," + status + ", '" + note + "');";

                                new BUSBooking().bookingBed(sql);
                                MessageBox.Show("Book successfully!", "Notification", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Book Faild: " + ex + "", "Notification", MessageBoxButtons.OK);
                            }

                        }
                        else
                        {
                            MessageBox.Show("You already have a pending request.", "Notification", MessageBoxButtons.OK);
                        }
                    }
                }

            }
        }

        public bool isValidInput(string rollNumber, string name, string dob, string addr, string phone, string room)
        {
            if (rollNumber == "" || name == "" || dob == "" || addr == "" || phone == "" || room == "") return false;

            return true;
        }

        private bool isRightGender(int gender, string room)
        {
            string sql = "  SELECT TOP(1) roomRole FROM ROOMS WHERE roomid = '" + room + "'";
            int roomGender = new BUSRoom().getStudentByGender(sql).Rows[0][0].ToString().Equals("True") ? 1 : 0;
            return gender == roomGender ? true : false;
        }

        private bool isFreeRoom(string room)
        {
            string sql = "SELECT quantity, [count] FROM Rooms WHERE roomID = '" + room + "'";
            int quantity = Int32.Parse(new BUSRoom().getTypeOfRoom(sql).Rows[0][0].ToString());
            int count = Int32.Parse(new BUSRoom().getStudentQuantityInRoom(sql).Rows[0][1].ToString());
            if (quantity > count) return true;
            return false;
        }

        private bool isPending(string rollNumber)
        {
            string sql = " SELECT [status] FROM Booking WHERE rollNumber = '" + rollNumber + "'";

            int status = Int32.Parse(new BUSBooking().getStatusOfBooking(sql).Rows[0][0].ToString());
            if (status == 2) return true;
            return false;
        }

        private bool isRequestValid(string rollNumber)
        {
            if (new BUSBooking().isRequested(rollNumber).Rows.Count > 0)
            {
                if (isPending(rollNumber)) return false;

                return true;
            }
            return true;
        }

        private void FrmBooking_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Students WHERE rollNumber = '" + rollNumber + "'";
            DataTable dt = new DataTable();
            dt = (new BUSStudent()).searchStudent(sql);
            if (dt.Rows.Count > 0)
            {
                txtRollNumber.Text = dt.Rows[0][0].ToString();
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
                    txtRoom.Text = rooms;
                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtBirthdate.Text = "";
            cbGender.SelectedIndex = -1;
            txtAddress.Text = "";
            txtPhonenumber.Text = "";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            FrmSelectFreeRoom f = new FrmSelectFreeRoom(rollNumber);
            f.Show();
            this.Close();
        }
    }
}
