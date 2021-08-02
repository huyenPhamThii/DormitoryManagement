
namespace Project1
{
    partial class FrmSearchStudentByStdInfor
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
            this.gbSearchInput = new System.Windows.Forms.GroupBox();
            this.btnSearchRollNumber = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.rollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearchInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchInput
            // 
            this.gbSearchInput.Controls.Add(this.btnSearchRollNumber);
            this.gbSearchInput.Controls.Add(this.btnSearchName);
            this.gbSearchInput.Controls.Add(this.txtRollNumber);
            this.gbSearchInput.Controls.Add(this.txtName);
            this.gbSearchInput.Controls.Add(this.label2);
            this.gbSearchInput.Controls.Add(this.label1);
            this.gbSearchInput.Location = new System.Drawing.Point(12, 12);
            this.gbSearchInput.Name = "gbSearchInput";
            this.gbSearchInput.Size = new System.Drawing.Size(598, 95);
            this.gbSearchInput.TabIndex = 2;
            this.gbSearchInput.TabStop = false;
            this.gbSearchInput.Text = "Enter search information";
            // 
            // btnSearchRollNumber
            // 
            this.btnSearchRollNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRollNumber.Location = new System.Drawing.Point(445, 54);
            this.btnSearchRollNumber.Name = "btnSearchRollNumber";
            this.btnSearchRollNumber.Size = new System.Drawing.Size(113, 23);
            this.btnSearchRollNumber.TabIndex = 13;
            this.btnSearchRollNumber.Text = "Search by RN";
            this.btnSearchRollNumber.UseVisualStyleBackColor = true;
            this.btnSearchRollNumber.Click += new System.EventHandler(this.btnSearchRollNumber_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(136, 54);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(113, 23);
            this.btnSearchName.TabIndex = 8;
            this.btnSearchName.Text = "Search by name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(411, 28);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(147, 20);
            this.txtRollNumber.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student name:";
            // 
            // dgResult
            // 
            this.dgResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResult.BackgroundColor = System.Drawing.Color.White;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNumber,
            this.studentName,
            this.dateBirth,
            this.gender,
            this.address,
            this.phone,
            this.roomID});
            this.dgResult.Location = new System.Drawing.Point(12, 113);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(935, 306);
            this.dgResult.TabIndex = 3;
            this.dgResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResult_CellClick);
            this.dgResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgResult_CellFormatting);
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
            this.dateBirth.HeaderText = "DOB";
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
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone number";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // roomID
            // 
            this.roomID.DataPropertyName = "roomID";
            this.roomID.HeaderText = "Room";
            this.roomID.Name = "roomID";
            this.roomID.ReadOnly = true;
            // 
            // FrmSearchStudentByStdInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 431);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.gbSearchInput);
            this.Name = "FrmSearchStudentByStdInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search ";
            this.gbSearchInput.ResumeLayout(false);
            this.gbSearchInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSearchInput;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Button btnSearchRollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomID;
    }
}