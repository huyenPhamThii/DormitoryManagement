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
    public partial class FrmSearchStudentByRoom : Form
    {
        public FrmSearchStudentByRoom()
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

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            string room = txtRoom.Text.Trim();
            if (!isValidInput(room))
            {
                MessageBox.Show("Invalid input!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string str = "SELECT * FROM Students WHERE roomID LIKE '%" + room + "%'";

            dgResult.DataSource = (new BUSStudent()).searchStudent(str);
        }
    }
}
