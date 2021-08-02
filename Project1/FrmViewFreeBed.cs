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
    public partial class FrmViewFreeBed : Form
    {
        public FrmViewFreeBed()
        {
            InitializeComponent();
            cbGender.SelectedIndex = 0;
        }


        private void btnShowList_Click_1(object sender, EventArgs e)
        {
            dgRoomNotFull.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRoomUsage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string a = cbDom.Text;
            string b = "true";
            if(cbGender.SelectedIndex == 1)
            {
                b = "false";
            }
            dgRoomNotFull.DataSource = (new BUSRoom()).loadRoomNotFull(a,b);
            dgRoomUsage.DataSource = (new BUSRoom()).loadRoomUsage(a, b);
        }

        private void FrmSystem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kTXManagerDataSet.Doms' table. You can move, or remove it, as needed.
            this.domsTableAdapter.Fill(this.kTXManagerDataSet.Doms);
            

        }

    }
}
