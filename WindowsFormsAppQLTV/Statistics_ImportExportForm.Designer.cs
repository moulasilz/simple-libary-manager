namespace WindowsFormsAppQLTV
{
    partial class Statistics_ImportExportForm
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
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.headername = new System.Windows.Forms.Label();
            this.BooksListTable = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.ThismonthBtn = new System.Windows.Forms.Button();
            this.optionaldateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.datefrom = new System.Windows.Forms.Label();
            this.dateto = new System.Windows.Forms.Label();
            this.ThisyearBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.Headerpanel.Controls.Add(this.exitBtn);
            this.Headerpanel.Controls.Add(this.headername);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.ForeColor = System.Drawing.Color.White;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(1014, 70);
            this.Headerpanel.TabIndex = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackgroundImage = global::WindowsFormsAppQLTV.Properties.Resources.CloseBtn;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(953, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(49, 46);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headername
            // 
            this.headername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headername.AutoSize = true;
            this.headername.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.headername.Location = new System.Drawing.Point(380, 22);
            this.headername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headername.Name = "headername";
            this.headername.Size = new System.Drawing.Size(290, 23);
            this.headername.TabIndex = 0;
            this.headername.Text = "Thống kê nhập, xuất sách";
            // 
            // BooksListTable
            // 
            this.BooksListTable.AllowUserToDeleteRows = false;
            this.BooksListTable.AllowUserToResizeRows = false;
            this.BooksListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksListTable.Location = new System.Drawing.Point(13, 169);
            this.BooksListTable.Margin = new System.Windows.Forms.Padding(4);
            this.BooksListTable.Name = "BooksListTable";
            this.BooksListTable.ReadOnly = true;
            this.BooksListTable.RowHeadersWidth = 51;
            this.BooksListTable.RowTemplate.Height = 24;
            this.BooksListTable.Size = new System.Drawing.Size(988, 492);
            this.BooksListTable.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "những sách đã nhập về",
            "những sách đã xuất khỏi thư viện"});
            this.comboBox.Location = new System.Drawing.Point(90, 86);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(468, 28);
            this.comboBox.TabIndex = 5;
            // 
            // ThismonthBtn
            // 
            this.ThismonthBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThismonthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ThismonthBtn.Font = new System.Drawing.Font("Verdana", 9.6F);
            this.ThismonthBtn.Location = new System.Drawing.Point(578, 81);
            this.ThismonthBtn.Name = "ThismonthBtn";
            this.ThismonthBtn.Size = new System.Drawing.Size(204, 39);
            this.ThismonthBtn.TabIndex = 6;
            this.ThismonthBtn.Text = "Trong tháng";
            this.ThismonthBtn.UseVisualStyleBackColor = false;
            this.ThismonthBtn.Click += new System.EventHandler(this.ThismonthBtn_Click);
            // 
            // optionaldateBtn
            // 
            this.optionaldateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionaldateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.optionaldateBtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.optionaldateBtn.Location = new System.Drawing.Point(894, 126);
            this.optionaldateBtn.Name = "optionaldateBtn";
            this.optionaldateBtn.Size = new System.Drawing.Size(52, 39);
            this.optionaldateBtn.TabIndex = 7;
            this.optionaldateBtn.Text = "ok";
            this.optionaldateBtn.UseVisualStyleBackColor = false;
            this.optionaldateBtn.Click += new System.EventHandler(this.optionaldateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn:";
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFromPicker.CalendarFont = new System.Drawing.Font("Verdana", 10F);
            this.dateFromPicker.CustomFormat = "dd/MM/yyyy";
            this.dateFromPicker.Font = new System.Drawing.Font("Verdana", 9F);
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromPicker.Location = new System.Drawing.Point(572, 134);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(127, 26);
            this.dateFromPicker.TabIndex = 10;
            // 
            // dateToPicker
            // 
            this.dateToPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateToPicker.CustomFormat = "dd/MM/yyyy";
            this.dateToPicker.Font = new System.Drawing.Font("Verdana", 9F);
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToPicker.Location = new System.Drawing.Point(761, 134);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(127, 26);
            this.dateToPicker.TabIndex = 10;
            this.dateToPicker.Value = new System.DateTime(2022, 4, 12, 0, 0, 0, 0);
            // 
            // datefrom
            // 
            this.datefrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datefrom.AutoSize = true;
            this.datefrom.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Underline);
            this.datefrom.Location = new System.Drawing.Point(528, 138);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(38, 20);
            this.datefrom.TabIndex = 11;
            this.datefrom.Text = "Từ:";
            // 
            // dateto
            // 
            this.dateto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateto.AutoSize = true;
            this.dateto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Underline);
            this.dateto.Location = new System.Drawing.Point(706, 138);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(51, 20);
            this.dateto.TabIndex = 12;
            this.dateto.Text = "Đến:";
            // 
            // ThisyearBtn
            // 
            this.ThisyearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThisyearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ThisyearBtn.Font = new System.Drawing.Font("Verdana", 9.6F);
            this.ThisyearBtn.Location = new System.Drawing.Point(788, 81);
            this.ThisyearBtn.Name = "ThisyearBtn";
            this.ThisyearBtn.Size = new System.Drawing.Size(204, 39);
            this.ThisyearBtn.TabIndex = 13;
            this.ThisyearBtn.Text = "Trong năm";
            this.ThisyearBtn.UseVisualStyleBackColor = false;
            this.ThisyearBtn.Click += new System.EventHandler(this.ThisyearBtn_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(384, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tuỳ chọn --->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Statistics_ImportExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThisyearBtn);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.datefrom);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optionaldateBtn);
            this.Controls.Add(this.ThismonthBtn);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.BooksListTable);
            this.Controls.Add(this.comboBox);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics_ImportExportForm";
            this.Text = "ImportExportStatisticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportExportStatisticsForm_FormClosed);
            this.Load += new System.EventHandler(this.ImportExportStatisticsForm_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label headername;
        private System.Windows.Forms.DataGridView BooksListTable;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button ThismonthBtn;
        private System.Windows.Forms.Button optionaldateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Label datefrom;
        private System.Windows.Forms.Label dateto;
        private System.Windows.Forms.Button ThisyearBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitBtn;
    }
}