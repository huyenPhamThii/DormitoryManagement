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
    public partial class FrmSelectFreeRoom : Form
    {
        public FrmSelectFreeRoom()
        {
            InitializeComponent();
        }

        string rollNumber;
        public FrmSelectFreeRoom(string a)
        {
            rollNumber = a;
            InitializeComponent();
        }

        private void FrmViewFreeRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kTXManagerDataSet2.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.FillBy(this.kTXManagerDataSet2.Rooms);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomsTableAdapter.FillBy(this.kTXManagerDataSet2.Rooms);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string x = listBox1.SelectedValue.ToString();
            this.Close();
            new FrmMainStudent(rollNumber, x).ShowDialog();
        }
    }
}
