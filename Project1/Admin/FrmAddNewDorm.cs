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
    public partial class FrmAddNewDorm : Form
    {
        public FrmAddNewDorm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dom = txtDom.Text;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            if(!(new BUSDom()).checkDom(dom))
            {
                if((new BUSDom()).addDom(dom, quantity))
                {
                    MessageBox.Show("Add dorm successfully");
                }
                else
                {
                    MessageBox.Show("Add dorm fail");
                }
            }
            else
            {
                MessageBox.Show("Dorm has exist");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new FrmMainStudent().ShowDialog();
        }
    }
}
