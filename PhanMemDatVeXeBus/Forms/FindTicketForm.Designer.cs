namespace PhanMemDatVeXeBus
{
    partial class FindTicketForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BusList = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonFindTicket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.endingpoint = new System.Windows.Forms.ComboBox();
            this.startingpoint = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.buttonFindTicket);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.endingpoint);
            this.panel1.Controls.Add(this.startingpoint);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 439);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BusList);
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách xe bus";
            // 
            // BusList
            // 
            this.BusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5});
            this.BusList.Location = new System.Drawing.Point(10, 27);
            this.BusList.Name = "BusList";
            this.BusList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.BusList.RowTemplate.Height = 24;
            this.BusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BusList.Size = new System.Drawing.Size(593, 135);
            this.BusList.TabIndex = 1;
            this.BusList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusList_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "26-11-2020";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // buttonFindTicket
            // 
            this.buttonFindTicket.Location = new System.Drawing.Point(237, 194);
            this.buttonFindTicket.Name = "buttonFindTicket";
            this.buttonFindTicket.Size = new System.Drawing.Size(125, 50);
            this.buttonFindTicket.TabIndex = 7;
            this.buttonFindTicket.Text = "Tìm vé";
            this.buttonFindTicket.UseVisualStyleBackColor = true;
            this.buttonFindTicket.Click += new System.EventHandler(this.buttonFindTicket_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày đi: ";
            // 
            // endingpoint
            // 
            this.endingpoint.FormattingEnabled = true;
            this.endingpoint.Items.AddRange(new object[] {
            "TP. Hồ Chí Minh",
            "Hà Nội",
            "Đà Nẵng",
            "Vũng Tàu"});
            this.endingpoint.Location = new System.Drawing.Point(421, 74);
            this.endingpoint.Name = "endingpoint";
            this.endingpoint.Size = new System.Drawing.Size(175, 30);
            this.endingpoint.TabIndex = 4;
            // 
            // startingpoint
            // 
            this.startingpoint.FormattingEnabled = true;
            this.startingpoint.Items.AddRange(new object[] {
            "TP. Hồ Chí Minh",
            "Hà Nội",
            "Đà Nẵng",
            "Vũng Tàu"});
            this.startingpoint.Location = new System.Drawing.Point(119, 70);
            this.startingpoint.Name = "startingpoint";
            this.startingpoint.Size = new System.Drawing.Size(175, 30);
            this.startingpoint.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điểm đến: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm đi: ";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BusOwnerName";
            this.Column1.HeaderText = "Tên nhà xe";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StartingPoint";
            this.Column3.HeaderText = "Điểm đi";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EndingPoint";
            this.Column4.HeaderText = "Điểm đến";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Time";
            this.Column2.HeaderText = "Ngày đi";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TicketPrize";
            this.Column5.HeaderText = "Giá vé";
            this.Column5.Name = "Column5";
            // 
            // FindTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 466);
            this.Controls.Add(this.panel1);
            this.Name = "FindTicketForm";
            this.Text = "Tìm vé xe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox endingpoint;
        private System.Windows.Forms.ComboBox startingpoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFindTicket;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView BusList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}