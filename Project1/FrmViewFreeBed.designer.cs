
namespace Project1
{
    partial class FrmViewFreeBed
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.dgRoomNotFull = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgRoomUsage = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDom = new System.Windows.Forms.ComboBox();
            this.domsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kTXManagerDataSet = new Project1.KTXManagerDataSet();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.domsTableAdapter = new Project1.KTXManagerDataSetTableAdapters.DomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomNotFull)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTXManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Dom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Gender";
            // 
            // btnShowList
            // 
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(580, 23);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(85, 28);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "View";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click_1);
            // 
            // dgRoomNotFull
            // 
            this.dgRoomNotFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRoomNotFull.BackgroundColor = System.Drawing.Color.White;
            this.dgRoomNotFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomNotFull.Location = new System.Drawing.Point(48, 66);
            this.dgRoomNotFull.Margin = new System.Windows.Forms.Padding(2);
            this.dgRoomNotFull.Name = "dgRoomNotFull";
            this.dgRoomNotFull.RowHeadersWidth = 51;
            this.dgRoomNotFull.RowTemplate.Height = 24;
            this.dgRoomNotFull.Size = new System.Drawing.Size(644, 180);
            this.dgRoomNotFull.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgRoomUsage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(48, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(644, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dgRoomUsage
            // 
            this.dgRoomUsage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRoomUsage.BackgroundColor = System.Drawing.Color.White;
            this.dgRoomUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomUsage.Location = new System.Drawing.Point(0, 40);
            this.dgRoomUsage.Margin = new System.Windows.Forms.Padding(2);
            this.dgRoomUsage.Name = "dgRoomUsage";
            this.dgRoomUsage.RowHeadersWidth = 51;
            this.dgRoomUsage.RowTemplate.Height = 24;
            this.dgRoomUsage.Size = new System.Drawing.Size(644, 92);
            this.dgRoomUsage.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Report for Room Usage";
            // 
            // cbDom
            // 
            this.cbDom.DataSource = this.domsBindingSource;
            this.cbDom.DisplayMember = "domID";
            this.cbDom.FormattingEnabled = true;
            this.cbDom.Location = new System.Drawing.Point(141, 33);
            this.cbDom.Name = "cbDom";
            this.cbDom.Size = new System.Drawing.Size(121, 21);
            this.cbDom.TabIndex = 7;
            this.cbDom.ValueMember = "domID";
            // 
            // domsBindingSource
            // 
            this.domsBindingSource.DataMember = "Doms";
            this.domsBindingSource.DataSource = this.kTXManagerDataSet;
            // 
            // kTXManagerDataSet
            // 
            this.kTXManagerDataSet.DataSetName = "KTXManagerDataSet";
            this.kTXManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(415, 32);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 8;
            // 
            // domsTableAdapter
            // 
            this.domsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFreeBedStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 405);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbDom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgRoomNotFull);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFreeBedStatistic";
            this.Text = "FrmSystem";
            this.Load += new System.EventHandler(this.FrmSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomNotFull)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTXManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.DataGridView dgRoomNotFull;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgRoomUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDom;
        private System.Windows.Forms.ComboBox cbGender;
        private KTXManagerDataSet kTXManagerDataSet;
        private System.Windows.Forms.BindingSource domsBindingSource;
        private KTXManagerDataSetTableAdapters.DomsTableAdapter domsTableAdapter;
    }
}