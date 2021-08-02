using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1.Admin
{
    public partial class FrmBookingHistory : Form
    {
        public FrmBookingHistory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBookingHistory_Load(object sender, EventArgs e)
        {
            loadGird();
        }

        private void loadGird()
        {
            dgContent.AutoGenerateColumns = false;
            dgContent.DataSource = (new BUSBooking()).getBookingListHistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            new FrmBookingConfirm().ShowDialog();
            loadGird();
        }
    }
}
