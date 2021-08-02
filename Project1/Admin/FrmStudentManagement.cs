
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
    public partial class FrmStudentManagement : Form
    {
        public FrmStudentManagement()
        {
            InitializeComponent();
        }
        public FrmStudentManagement(string account)
        {
            InitializeComponent();
            this.Text = "Welcome " + account;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            
            loadGrid();
        }

        private void loadGrid()
        {
            // TODO: This line of code loads data into the 'kTXManagerDataSet1.Doms' table. You can move, or remove it, as needed.
            this.domsTableAdapter.Fill(this.kTXManagerDataSet1.Doms);
            //load student to data grid view
            dgStudent.DataSource = (new BUSStudent()).loadStudent();
            //load room to data grid view
            dgRoom.DataSource = (new BUSRoom()).loadRoom("A");
        }
        
        private void cbDom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbDom.Text;
            dgRoom.DataSource = (new BUSRoom()).loadRoom(a);
            dgStudent.DataSource = (new BUSStudent()).loadStudentFromDom(a);

        }

        private void dgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dgRoom.Rows[e.RowIndex].Cells["Room"].FormattedValue.ToString();
            dgStudent.DataSource = (new BUSStudent()).loadStudentFromRoom(a);
        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetailStudent f = new FrmDetailStudent(dgStudent.Rows[e.RowIndex].Cells["rollNumber"].FormattedValue.ToString(),
                dgStudent.Rows[e.RowIndex].Cells["studentName"].FormattedValue.ToString(),
                dgStudent.Rows[e.RowIndex].Cells["dateBirth"].FormattedValue.ToString(),
                dgStudent.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString(),
                dgStudent.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString(),
                dgStudent.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString(),
                dgStudent.Rows[e.RowIndex].Cells["roomID"].FormattedValue.ToString());
            f.ShowDialog();
            loadGrid();
        }

        private void dgStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgStudent.Columns[e.ColumnIndex].Name == "gender")
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

            if (this.dgStudent.Columns[e.ColumnIndex].Name == "roomRole")
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
