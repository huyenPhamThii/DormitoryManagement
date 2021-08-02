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
    public partial class FrmMainAdmin : Form
    {
        public FrmMainAdmin()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            addForm(new FrmStudentManagement());
        }

        private void addForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.ControlBox = false;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }


        private void freeBedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmViewFreeBed());
        }

        private void listAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmStudentManagement());
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddNewStudent().ShowDialog();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmBookingConfirm());
        }

        private void addDomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmAddNewDorm());
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmViewFreeBed());
        }

        private void byStudentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmSearchStudentByStdInfor());
        }

        private void byRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmSearchStudentByRoom());
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmChangePassword());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmWelcome());
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new FrmContact());
        }

        private void bookingActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm(new Admin.FrmBookingHistory());
        }
    }
}
