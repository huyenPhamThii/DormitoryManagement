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
    public partial class FrmMainStudent : Form
    {
        public FrmMainStudent()
        {
            InitializeComponent();
        }

        String rollNumber, roomS = "";

        public FrmMainStudent(string name, string room)
        {
            InitializeComponent();
            rollNumber = name;
            roomS = room;
        }

        public FrmMainStudent(string name)
        {
            InitializeComponent();
            rollNumber = name;
            
        }

        private void addForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void bookABedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmBooking(rollNumber));
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmChangePassword());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmWelcome().ShowDialog();
            this.Close();
        }

        private void viewFreeBedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmViewFreeBed());
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmStudentProfile(rollNumber));
        }

        private void FrmMainStudent_Load(object sender, EventArgs e)
        {
            addForm(new FrmBooking(rollNumber, roomS));
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            addForm(new FrmContact());
        }

        private void cancelARoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new Student.FrmCancel());
        }
    }
}
