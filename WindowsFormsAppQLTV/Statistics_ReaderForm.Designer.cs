namespace WindowsFormsAppQLTV
{
    partial class Statistics_ReaderForm
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
            this.ReaderListTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dateto = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.optionaldateBtn = new System.Windows.Forms.Button();
            this.OptionalDatePanel = new System.Windows.Forms.Panel();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderListTable)).BeginInit();
            this.OptionalDatePanel.SuspendLayout();
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
            this.Headerpanel.TabIndex = 5;
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
            this.exitBtn.TabIndex = 21;
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
            this.headername.Size = new System.Drawing.Size(201, 23);
            this.headername.TabIndex = 0;
            this.headername.Text = "Thống kê bạn đọc";
            // 
            // ReaderListTable
            // 
            this.ReaderListTable.AllowUserToDeleteRows = false;
            this.ReaderListTable.AllowUserToResizeRows = false;
            this.ReaderListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReaderListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderListTable.Location = new System.Drawing.Point(13, 169);
            this.ReaderListTable.Margin = new System.Windows.Forms.Padding(4);
            this.ReaderListTable.Name = "ReaderListTable";
            this.ReaderListTable.ReadOnly = true;
            this.ReaderListTable.RowHeadersWidth = 51;
            this.ReaderListTable.RowTemplate.Height = 24;
            this.ReaderListTable.Size = new System.Drawing.Size(988, 492);
            this.ReaderListTable.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(247, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chọn:";
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Thống kê tất cả bạn đọc",
            "Thống kê bạn đọc có thẻ quá hạn",
            "Thống kê bạn đọc đăng ký mới tháng này",
            "Thống kê bạn đọc đăng ký mới theo ngày tuỳ chọn"});
            this.comboBox.Location = new System.Drawing.Point(317, 92);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(400, 28);
            this.comboBox.TabIndex = 10;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
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
            // OptionalDatePanel
            // 
            this.OptionalDatePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OptionalDatePanel.Controls.Add(this.optionaldateBtn);
            this.OptionalDatePanel.Controls.Add(this.dateto);
            this.OptionalDatePanel.Controls.Add(this.dateFromPicker);
            this.OptionalDatePanel.Controls.Add(this.datefrom);
            this.OptionalDatePanel.Controls.Add(this.dateToPicker);
            this.OptionalDatePanel.Location = new System.Drawing.Point(280, 126);
            this.OptionalDatePanel.Name = "OptionalDatePanel";
            this.OptionalDatePanel.Size = new System.Drawing.Size(437, 39);
            this.OptionalDatePanel.TabIndex = 20;
            this.OptionalDatePanel.Visible = false;
            // 
            // Statistics_ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.OptionalDatePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.ReaderListTable);
            this.Controls.Add(this.Headerpanel);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics_ReaderForm";
            this.Text = "ReaderStatisticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReaderStatisticsForm_FormClosed);
            this.Load += new System.EventHandler(this.ReaderStatisticsForm_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderListTable)).EndInit();
            this.OptionalDatePanel.ResumeLayout(false);
            this.OptionalDatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label headername;
        private System.Windows.Forms.DataGridView ReaderListTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label dateto;
        private System.Windows.Forms.Label datefrom;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Button optionaldateBtn;
        private System.Windows.Forms.Panel OptionalDatePanel;
        private System.Windows.Forms.Button exitBtn;
    }
}