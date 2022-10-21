namespace WindowsFormsAppQLTV
{
    partial class Statistics_BorrowGiveForm
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
            this.LoanListTable = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.headername = new System.Windows.Forms.Label();
            this.OptionalDatePanel = new System.Windows.Forms.Panel();
            this.optionaldateBtn = new System.Windows.Forms.Button();
            this.dateto = new System.Windows.Forms.Label();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.datefrom = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailedLoanListTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LoanListTable)).BeginInit();
            this.Headerpanel.SuspendLayout();
            this.OptionalDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedLoanListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LoanListTable
            // 
            this.LoanListTable.AllowUserToDeleteRows = false;
            this.LoanListTable.AllowUserToResizeRows = false;
            this.LoanListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanListTable.Location = new System.Drawing.Point(13, 185);
            this.LoanListTable.Margin = new System.Windows.Forms.Padding(4);
            this.LoanListTable.Name = "LoanListTable";
            this.LoanListTable.ReadOnly = true;
            this.LoanListTable.RowHeadersWidth = 51;
            this.LoanListTable.RowTemplate.Height = 24;
            this.LoanListTable.Size = new System.Drawing.Size(618, 476);
            this.LoanListTable.TabIndex = 3;
            this.LoanListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanListTable_CellClick);
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Thống kê tất cả phiếu mượn",
            "Thống kê phiếu mượn trong tháng",
            "Thống kê phiếu mượn theo ngày tuỳ chọn",
            "Thống kê phiếu mượn đã trả trong tháng",
            "Thống kê phiếu mượn đã trả theo ngày tuỳ chọn",
            "Thống kê phiếu mượn chưa trả"});
            this.comboBox.Location = new System.Drawing.Point(314, 104);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(400, 28);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
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
            this.Headerpanel.TabIndex = 6;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackgroundImage = global::WindowsFormsAppQLTV.Properties.Resources.CloseBtn;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(952, 10);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(49, 46);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headername
            // 
            this.headername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headername.AutoSize = true;
            this.headername.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.headername.Location = new System.Drawing.Point(441, 22);
            this.headername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headername.Name = "headername";
            this.headername.Size = new System.Drawing.Size(223, 23);
            this.headername.TabIndex = 0;
            this.headername.Text = "Thống kê mượn trả ";
            // 
            // OptionalDatePanel
            // 
            this.OptionalDatePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OptionalDatePanel.Controls.Add(this.optionaldateBtn);
            this.OptionalDatePanel.Controls.Add(this.dateto);
            this.OptionalDatePanel.Controls.Add(this.dateFromPicker);
            this.OptionalDatePanel.Controls.Add(this.datefrom);
            this.OptionalDatePanel.Controls.Add(this.dateToPicker);
            this.OptionalDatePanel.Location = new System.Drawing.Point(280, 139);
            this.OptionalDatePanel.Name = "OptionalDatePanel";
            this.OptionalDatePanel.Size = new System.Drawing.Size(437, 39);
            this.OptionalDatePanel.TabIndex = 21;
            this.OptionalDatePanel.Visible = false;
            // 
            // optionaldateBtn
            // 
            this.optionaldateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionaldateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.optionaldateBtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.optionaldateBtn.Location = new System.Drawing.Point(382, -1);
            this.optionaldateBtn.Name = "optionaldateBtn";
            this.optionaldateBtn.Size = new System.Drawing.Size(52, 39);
            this.optionaldateBtn.TabIndex = 15;
            this.optionaldateBtn.Text = "ok";
            this.optionaldateBtn.UseVisualStyleBackColor = false;
            this.optionaldateBtn.Click += new System.EventHandler(this.optionaldateBtn_Click);
            // 
            // dateto
            // 
            this.dateto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateto.AutoSize = true;
            this.dateto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Underline);
            this.dateto.Location = new System.Drawing.Point(194, 7);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(51, 20);
            this.dateto.TabIndex = 19;
            this.dateto.Text = "Đến:";
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFromPicker.CalendarFont = new System.Drawing.Font("Verdana", 10F);
            this.dateFromPicker.CustomFormat = "dd/MM/yyyy";
            this.dateFromPicker.Font = new System.Drawing.Font("Verdana", 9F);
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromPicker.Location = new System.Drawing.Point(60, 3);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(127, 26);
            this.dateFromPicker.TabIndex = 17;
            // 
            // datefrom
            // 
            this.datefrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datefrom.AutoSize = true;
            this.datefrom.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Underline);
            this.datefrom.Location = new System.Drawing.Point(16, 7);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(38, 20);
            this.datefrom.TabIndex = 18;
            this.datefrom.Text = "Từ:";
            // 
            // dateToPicker
            // 
            this.dateToPicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateToPicker.CustomFormat = "dd/MM/yyyy";
            this.dateToPicker.Font = new System.Drawing.Font("Verdana", 9F);
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToPicker.Location = new System.Drawing.Point(249, 3);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(127, 26);
            this.dateToPicker.TabIndex = 16;
            this.dateToPicker.Value = new System.DateTime(2022, 4, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(244, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chọn:";
            // 
            // DetailedLoanListTable
            // 
            this.DetailedLoanListTable.AllowUserToDeleteRows = false;
            this.DetailedLoanListTable.AllowUserToResizeRows = false;
            this.DetailedLoanListTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailedLoanListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailedLoanListTable.Location = new System.Drawing.Point(639, 185);
            this.DetailedLoanListTable.Margin = new System.Windows.Forms.Padding(4);
            this.DetailedLoanListTable.Name = "DetailedLoanListTable";
            this.DetailedLoanListTable.ReadOnly = true;
            this.DetailedLoanListTable.RowHeadersWidth = 51;
            this.DetailedLoanListTable.RowTemplate.Height = 24;
            this.DetailedLoanListTable.Size = new System.Drawing.Size(362, 476);
            this.DetailedLoanListTable.TabIndex = 23;
            // 
            // Statistics_BorrowGiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.DetailedLoanListTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptionalDatePanel);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.LoanListTable);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics_BorrowGiveForm";
            this.Text = "BorrowGiveStatisticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BorrowGiveStatisticsForm_FormClosed);
            this.Load += new System.EventHandler(this.BorrowGiveStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoanListTable)).EndInit();
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            this.OptionalDatePanel.ResumeLayout(false);
            this.OptionalDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedLoanListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView LoanListTable;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label headername;
        private System.Windows.Forms.Panel OptionalDatePanel;
        private System.Windows.Forms.Button optionaldateBtn;
        private System.Windows.Forms.Label dateto;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Label datefrom;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DetailedLoanListTable;
        private System.Windows.Forms.Button exitBtn;
    }
}