
namespace Project1
{
    partial class FrmStudentManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbPhong = new System.Windows.Forms.GroupBox();
            this.cbDom = new System.Windows.Forms.ComboBox();
            this.domsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kTXManagerDataSet1 = new Project1.KTXManagerDataSet1();
            this.dgRoom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.domsTableAdapter = new Project1.KTXManagerDataSet1TableAdapters.DomsTableAdapter();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.rollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTXManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPhong
            // 
            this.gbPhong.Controls.Add(this.cbDom);
            this.gbPhong.Controls.Add(this.dgRoom);
            this.gbPhong.Controls.Add(this.label1);
            this.gbPhong.Location = new System.Drawing.Point(10, 26);
            this.gbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.gbPhong.Name = "gbPhong";
            this.gbPhong.Padding = new System.Windows.Forms.Padding(2);
            this.gbPhong.Size = new System.Drawing.Size(150, 391);
            this.gbPhong.TabIndex = 1;
            this.gbPhong.TabStop = false;
            this.gbPhong.Text = "Select room";
            // 
            // cbDom
            // 
            this.cbDom.DataSource = this.domsBindingSource;
            this.cbDom.DisplayMember = "domID";
            this.cbDom.FormattingEnabled = true;
            this.cbDom.Location = new System.Drawing.Point(76, 25);
            this.cbDom.Name = "cbDom";
            this.cbDom.Size = new System.Drawing.Size(74, 21);
            this.cbDom.TabIndex = 3;
            this.cbDom.ValueMember = "domID";
            this.cbDom.SelectedIndexChanged += new System.EventHandler(this.cbDom_SelectedIndexChanged);
            // 
            // domsBindingSource
            // 
            this.domsBindingSource.DataMember = "Doms";
            this.domsBindingSource.DataSource = this.kTXManagerDataSet1;
            // 
            // kTXManagerDataSet1
            // 
            this.kTXManagerDataSet1.DataSetName = "KTXManagerDataSet1";
            this.kTXManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgRoom
            // 
            this.dgRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoom.Location = new System.Drawing.Point(5, 61);
            this.dgRoom.Margin = new System.Windows.Forms.Padding(2);
            this.dgRoom.Name = "dgRoom";
            this.dgRoom.ReadOnly = true;
            this.dgRoom.RowHeadersWidth = 51;
            this.dgRoom.RowTemplate.Height = 24;
            this.dgRoom.Size = new System.Drawing.Size(140, 326);
            this.dgRoom.TabIndex = 2;
            this.dgRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRoom_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select dom:";
            // 
            // domsTableAdapter
            // 
            this.domsTableAdapter.ClearBeforeFill = true;
            // 
            // dgStudent
            // 
            this.dgStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNumber,
            this.studentName,
            this.dateBirth,
            this.gender,
            this.address,
            this.phone,
            this.roomID,
            this.quantity,
            this.count,
            this.roomRole,
            this.domID});
            this.dgStudent.Location = new System.Drawing.Point(164, 26);
            this.dgStudent.Margin = new System.Windows.Forms.Padding(2);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.ReadOnly = true;
            this.dgStudent.RowHeadersWidth = 51;
            this.dgStudent.RowTemplate.Height = 24;
            this.dgStudent.Size = new System.Drawing.Size(759, 387);
            this.dgStudent.TabIndex = 22;
            this.dgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudent_CellClick);
            this.dgStudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgStudent_CellFormatting);
            // 
            // rollNumber
            // 
            this.rollNumber.DataPropertyName = "rollNumber";
            this.rollNumber.HeaderText = "Roll Number";
            this.rollNumber.Name = "rollNumber";
            this.rollNumber.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentName";
            this.studentName.HeaderText = "Name";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // dateBirth
            // 
            this.dateBirth.DataPropertyName = "dateBirth";
            this.dateBirth.HeaderText = "Date Of Birht";
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Adress";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // roomID
            // 
            this.roomID.DataPropertyName = "roomID";
            this.roomID.HeaderText = "Room Name";
            this.roomID.Name = "roomID";
            this.roomID.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Size of room";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "Student\'s quantity";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // roomRole
            // 
            this.roomRole.DataPropertyName = "roomRole";
            this.roomRole.HeaderText = "Room Role";
            this.roomRole.Name = "roomRole";
            this.roomRole.ReadOnly = true;
            // 
            // domID
            // 
            this.domID.DataPropertyName = "domID";
            this.domID.HeaderText = "Dom Name";
            this.domID.Name = "domID";
            this.domID.ReadOnly = true;
            // 
            // FrmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 427);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.gbPhong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStudentManagement";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.gbPhong.ResumeLayout(false);
            this.gbPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTXManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPhong;
        private System.Windows.Forms.DataGridView dgRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDom;
        private KTXManagerDataSet1 kTXManagerDataSet1;
        private System.Windows.Forms.BindingSource domsBindingSource;
        private KTXManagerDataSet1TableAdapters.DomsTableAdapter domsTableAdapter;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn domID;
    }
}