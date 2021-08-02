using BUS;
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
    public partial class FrmSearchStudentByStdInfor : Form
    {
        public FrmSearchStudentByStdInfor()
        {
            InitializeComponent();
        }

        private bool isValidInput(string s)
        {
            if (s == "") return false;
            Regex regex = new Regex("^([a-zA-Z0-9/ ]+)$");
            if (!regex.IsMatch(s)) return false;
            return true;
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            txtRollNumber.Text = "";
            string name = txtName.Text.Trim();
            if (!isValidInput(name))
            {
                MessageBox.Show("Invalid input!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string str = "SELECT * FROM Students WHERE studentName LIKE '%" + name + "%'";
            dgResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgResult.DataSource = (new BUSStudent()).searchStudent(str);
        }

        private void btnSearchRollNumber_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            string rollNumber = txtRollNumber.Text.Trim();
            if (!isValidInput(rollNumber))
            {
                MessageBox.Show("Invalid input!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string str = "SELECT * FROM Students WHERE rollNumber LIKE '%" + rollNumber + "%'";

            dgResult.DataSource = (new BUSStudent()).searchStudent(str);
        }

        private void btnSearchByRoom_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmStudentManagement().ShowDialog();
            this.Close();
        }

        private void dgResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetailStudent f = new FrmDetailStudent(dgResult.Rows[e.RowIndex].Cells["rollNumber"].FormattedValue.ToString(),
               dgResult.Rows[e.RowIndex].Cells["studentName"].FormattedValue.ToString(),
               dgResult.Rows[e.RowIndex].Cells["dateBirth"].FormattedValue.ToString(),
               dgResult.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString(),
               dgResult.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString(),
               dgResult.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString(),
               dgResult.Rows[e.RowIndex].Cells["roomID"].FormattedValue.ToString());
            f.ShowDialog();
        }

        private void dgResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgResult.Columns[e.ColumnIndex].Name == "gender")
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
        }
    }
}
