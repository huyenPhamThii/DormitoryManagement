
namespace Project1
{
    partial class FrmSearchStudentByRoom
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
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.gbSearchInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchInput
            // 
            this.gbSearchInput.Controls.Add(this.btnSearchRoom);
            this.gbSearchInput.Controls.Add(this.txtRoom);
            this.gbSearchInput.Controls.Add(this.label1);
            this.gbSearchInput.Location = new System.Drawing.Point(12, 12);
            this.gbSearchInput.Name = "gbSearchInput";
            this.gbSearchInput.Size = new System.Drawing.Size(426, 69);
            this.gbSearchInput.TabIndex = 3;
            this.gbSearchInput.TabStop = false;
            this.gbSearchInput.Text = "Enter search information";
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoom.Location = new System.Drawing.Point(279, 28);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(113, 23);
            this.btnSearchRoom.TabIndex = 8;
            this.btnSearchRoom.Text = "Search by room";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(102, 28);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(147, 20);
            this.txtRoom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room name:";
            // 
            // dgResult
            // 
            this.dgResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResult.BackgroundColor = System.Drawing.Color.White;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(3, 87);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(877, 376);
            this.dgResult.TabIndex = 4;
            // 
            // FrmSearchStudentByRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 475);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.gbSearchInput);
            this.Name = "FrmSearchStudentByRoom";
            this.Text = "FrmSearchRoom";
            this.gbSearchInput.ResumeLayout(false);
            this.gbSearchInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchInput;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgResult;
    }
}