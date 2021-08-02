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
    public partial class FrmBookingConfirm : Form
    {
        public FrmBookingConfirm()
        {
            InitializeComponent();
        }

        private void FrmBookConfirm_Load(object sender, EventArgs e)
        {
            loadGird();
        }

        private void loadGird()
        {
            dgContent.AutoGenerateColumns = false;
            dgContent.DataSource = (new BUSBooking()).getBookingList();
        }

        private void dgContent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgContent.Columns[e.ColumnIndex].Name == "gender")
            {
                if (e.Value != null)
                {
                    int gender = e.Value.ToString().Equals("True") ? 1 : 0;
                    if (gender == 1)
                    {
                        e.Value = "Male";
                    }
                    else
                    {
                        e.Value = "Female";
                    }
                    e.FormattingApplied = true;
                }
            }

            if (this.dgContent.Columns[e.ColumnIndex].Name == "status")
            {
                if (e.Value != null)
                {
                    int status = 2;
                    if (e.Value.ToString().Equals("1")) status = 1;
                    if (e.Value.ToString().Equals("0")) status = 0;

                    if (status == 0)
                    {
                        e.Value = "Reject";
                    }
                    else if (status == 1)
                    {
                        e.Value = "Accept";
                    }
                    else
                    {
                        e.Value = "Pending";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string rollNumber = dgContent.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dgContent.Rows[e.RowIndex].Cells[1].Value.ToString();
            string dob = dgContent.Rows[e.RowIndex].Cells[2].Value.ToString();
            int gender = dgContent.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("Male") ? 1 : 0;
            //MessageBox.Show(gender + "");
            string addr = dgContent.Rows[e.RowIndex].Cells[4].Value.ToString();
            string phone = dgContent.Rows[e.RowIndex].Cells[5].Value.ToString();
            string room = dgContent.Rows[e.RowIndex].Cells[6].Value.ToString();
            string note = dgContent.Rows[e.RowIndex].Cells[7].Value.ToString();

            //check the option is Accept or Reject
            if (dgContent.Columns[e.ColumnIndex].Name == "accept")
            {
                if (MessageBox.Show("Are your sure to accept this request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //check quantity of student in room
                    if (!isValidToAdd(room))
                    {
                        MessageBox.Show("This room is full of students", "Can not add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //add new student in student table
                        if (new BUSStudent().updateStudent(rollNumber, name, dob, gender, addr, phone, room))
                        {
                            if ((new BUSBooking()).deleteStudentFromBooking(rollNumber))
                            {
                                //update status in booking history table
                                string sql = "INSERT INTO BookingHistory VALUES('" + rollNumber + "', '" + name + "', '" + dob + "', " + gender + ", '" + addr + "', '" + phone + "', '" + room + "'," + 1 + ", '" + note + "');";
                                if (new BUSBooking().updateRequest(sql))
                                {
                                    MessageBox.Show("Accept successfully");
                                    loadGird();

                                }
                                else
                                {
                                    MessageBox.Show("Accept fail(Update status fail)");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Accept fail(Delete from booking fail)");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Accept fail(Add student fail)");
                        }
                        //add 1 in room table
                        new BUSRoom().countAdd(room);

                    }

                }
            }
            if (dgContent.Columns[e.ColumnIndex].Name == "reject")
            {
                if (MessageBox.Show("Are your sure to reject this request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if ((new BUSBooking()).deleteStudentFromBooking(rollNumber))
                    {
                        MessageBox.Show("Reject successfully");
                        loadGird();
                    }
                    else
                    {
                        MessageBox.Show("Accept fail(Delete from booking fail)");
                    }

                }

            }
        }

        //check number of student in room is valid to add
        private bool isValidToAdd(string room)
        {
            string sql = "SELECT quantity, [count] FROM Rooms WHERE roomID = '" + room + "'";
            int quantity = Int32.Parse(new BUSRoom().getTypeOfRoom(sql).Rows[0][0].ToString());
            int count = Int32.Parse(new BUSRoom().getStudentQuantityInRoom(sql).Rows[0][1].ToString());
            if (quantity > count) return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
