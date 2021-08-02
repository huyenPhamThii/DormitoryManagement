
namespace Project1
{
    partial class FrmBookingConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgContent = new System.Windows.Forms.DataGridView();
            this.rollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgContent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOKING LIST";
            // 
            // dgContent
            // 
            this.dgContent.AllowUserToOrderColumns = true;
            this.dgContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContent.BackgroundColor = System.Drawing.Color.White;
            this.dgContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNumber,
            this.studentName,
            this.dob,
            this.gender,
            this.address,
            this.phone,
            this.roomID,
            this.note,
            this.accept,
            this.reject});
            this.dgContent.Location = new System.Drawing.Point(-3, 89);
            this.dgContent.Name = "dgContent";
            this.dgContent.Size = new System.Drawing.Size(813, 362);
            this.dgContent.TabIndex = 1;
            this.dgContent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContent_CellContentClick);
            this.dgContent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgContent_CellFormatting);
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
            // dob
            // 
            this.dob.DataPropertyName = "dateBirth";
            this.dob.HeaderText = "Date of birth";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
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
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // accept
            // 
            this.accept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.accept.HeaderText = "Action";
            this.accept.Name = "accept";
            this.accept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accept.Text = "Accept";
            this.accept.UseColumnTextForButtonValue = true;
            this.accept.Width = 62;
            // 
            // reject
            // 
            this.reject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.reject.HeaderText = "Action";
            this.reject.Name = "reject";
            this.reject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reject.Text = "Reject";
            this.reject.UseColumnTextForButtonValue = true;
            this.reject.Width = 62;
            // 
            // FrmBookingConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.dgContent);
            this.Controls.Add(this.label1);
            this.Name = "FrmBookingConfirm";
            this.Text = "FrmBookConfirm";
            this.Load += new System.EventHandler(this.FrmBookConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewButtonColumn accept;
        private System.Windows.Forms.DataGridViewButtonColumn reject;
    }
}