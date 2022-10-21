namespace WindowsFormsAppQLTV
{
    partial class Statistics_PerformanceForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.headername = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.ThismonthBtn = new System.Windows.Forms.Button();
            this.RequestDataBtn = new System.Windows.Forms.Button();
            this.CustomBtn = new System.Windows.Forms.Button();
            this.ThisweekBtn = new System.Windows.Forms.Button();
            this.Totalofbookpanel = new System.Windows.Forms.Panel();
            this.Totalofbook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlltimeBtn = new System.Windows.Forms.Button();
            this.BooksListTable = new System.Windows.Forms.DataGridView();
            this.TotalPanel = new System.Windows.Forms.Panel();
            this.Totalofloan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalofbookBtn = new System.Windows.Forms.Button();
            this.ToptotalBtn = new System.Windows.Forms.Button();
            this.Rateofoutdatelabel = new System.Windows.Forms.Panel();
            this.Rateofoutdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.Totalofbookpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListTable)).BeginInit();
            this.TotalPanel.SuspendLayout();
            this.Rateofoutdatelabel.SuspendLayout();
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
            this.Headerpanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(1014, 70);
            this.Headerpanel.TabIndex = 11;
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
            this.exitBtn.TabIndex = 29;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headername
            // 
            this.headername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headername.AutoSize = true;
            this.headername.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.headername.Location = new System.Drawing.Point(411, 22);
            this.headername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headername.Name = "headername";
            this.headername.Size = new System.Drawing.Size(309, 23);
            this.headername.TabIndex = 0;
            this.headername.Text = "Thống kê báo cáo hiệu quả ";
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Verdana", 10F);
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Verdana", 10F);
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Verdana", 10F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(584, 220);
            this.Chart.Name = "Chart";
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Verdana", 10F);
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.SmartLabelStyle.Enabled = false;
            series1.YValuesPerPoint = 4;
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(418, 356);
            this.Chart.TabIndex = 12;
            this.Chart.Text = " ";
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dateFromPicker.CustomFormat = "dd/MM/yyyy";
            this.dateFromPicker.Enabled = false;
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromPicker.Location = new System.Drawing.Point(143, 91);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(146, 28);
            this.dateFromPicker.TabIndex = 13;
            // 
            // dateToPicker
            // 
            this.dateToPicker.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dateToPicker.CustomFormat = "dd/MM/yyyy";
            this.dateToPicker.Enabled = false;
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToPicker.Location = new System.Drawing.Point(298, 91);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(146, 28);
            this.dateToPicker.TabIndex = 14;
            // 
            // ThismonthBtn
            // 
            this.ThismonthBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThismonthBtn.Location = new System.Drawing.Point(775, 91);
            this.ThismonthBtn.Name = "ThismonthBtn";
            this.ThismonthBtn.Size = new System.Drawing.Size(110, 28);
            this.ThismonthBtn.TabIndex = 18;
            this.ThismonthBtn.Text = "Tháng này";
            this.ThismonthBtn.UseVisualStyleBackColor = true;
            this.ThismonthBtn.Click += new System.EventHandler(this.ThismonthBtn_Click);
            // 
            // RequestDataBtn
            // 
            this.RequestDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestDataBtn.Location = new System.Drawing.Point(505, 91);
            this.RequestDataBtn.Name = "RequestDataBtn";
            this.RequestDataBtn.Size = new System.Drawing.Size(58, 28);
            this.RequestDataBtn.TabIndex = 19;
            this.RequestDataBtn.Text = "OK";
            this.RequestDataBtn.UseVisualStyleBackColor = true;
            this.RequestDataBtn.Click += new System.EventHandler(this.RequestDataBtn_Click);
            // 
            // CustomBtn
            // 
            this.CustomBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomBtn.Location = new System.Drawing.Point(569, 91);
            this.CustomBtn.Name = "CustomBtn";
            this.CustomBtn.Size = new System.Drawing.Size(97, 28);
            this.CustomBtn.TabIndex = 20;
            this.CustomBtn.Text = "Tuỳ chọn";
            this.CustomBtn.UseVisualStyleBackColor = true;
            this.CustomBtn.Click += new System.EventHandler(this.CustomBtn_Click);
            // 
            // ThisweekBtn
            // 
            this.ThisweekBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThisweekBtn.Location = new System.Drawing.Point(672, 91);
            this.ThisweekBtn.Name = "ThisweekBtn";
            this.ThisweekBtn.Size = new System.Drawing.Size(97, 28);
            this.ThisweekBtn.TabIndex = 21;
            this.ThisweekBtn.Text = "Tuần này";
            this.ThisweekBtn.UseVisualStyleBackColor = true;
            this.ThisweekBtn.Click += new System.EventHandler(this.ThisweekBtn_Click);
            // 
            // Totalofbookpanel
            // 
            this.Totalofbookpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Totalofbookpanel.BackColor = System.Drawing.Color.White;
            this.Totalofbookpanel.Controls.Add(this.Totalofbook);
            this.Totalofbookpanel.Controls.Add(this.label2);
            this.Totalofbookpanel.Location = new System.Drawing.Point(12, 593);
            this.Totalofbookpanel.Name = "Totalofbookpanel";
            this.Totalofbookpanel.Size = new System.Drawing.Size(279, 69);
            this.Totalofbookpanel.TabIndex = 24;
            // 
            // Totalofbook
            // 
            this.Totalofbook.AutoSize = true;
            this.Totalofbook.Location = new System.Drawing.Point(109, 29);
            this.Totalofbook.Name = "Totalofbook";
            this.Totalofbook.Size = new System.Drawing.Size(64, 20);
            this.Totalofbook.TabIndex = 2;
            this.Totalofbook.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "lượt sách được mượn";
            // 
            // AlltimeBtn
            // 
            this.AlltimeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlltimeBtn.Location = new System.Drawing.Point(892, 91);
            this.AlltimeBtn.Name = "AlltimeBtn";
            this.AlltimeBtn.Size = new System.Drawing.Size(110, 28);
            this.AlltimeBtn.TabIndex = 25;
            this.AlltimeBtn.Text = "Tất cả";
            this.AlltimeBtn.UseVisualStyleBackColor = true;
            this.AlltimeBtn.Click += new System.EventHandler(this.AlltimeBtn_Click);
            // 
            // BooksListTable
            // 
            this.BooksListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksListTable.Location = new System.Drawing.Point(12, 220);
            this.BooksListTable.Name = "BooksListTable";
            this.BooksListTable.RowHeadersWidth = 51;
            this.BooksListTable.RowTemplate.Height = 24;
            this.BooksListTable.Size = new System.Drawing.Size(564, 356);
            this.BooksListTable.TabIndex = 26;
            // 
            // TotalPanel
            // 
            this.TotalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPanel.BackColor = System.Drawing.Color.White;
            this.TotalPanel.Controls.Add(this.Totalofloan);
            this.TotalPanel.Controls.Add(this.label6);
            this.TotalPanel.Location = new System.Drawing.Point(602, 150);
            this.TotalPanel.Name = "TotalPanel";
            this.TotalPanel.Size = new System.Drawing.Size(197, 59);
            this.TotalPanel.TabIndex = 24;
            // 
            // Totalofloan
            // 
            this.Totalofloan.AutoSize = true;
            this.Totalofloan.Location = new System.Drawing.Point(66, 29);
            this.Totalofloan.Name = "Totalofloan";
            this.Totalofloan.Size = new System.Drawing.Size(64, 20);
            this.Totalofloan.TabIndex = 1;
            this.Totalofloan.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "tổng phiếu mượn";
            // 
            // TotalofbookBtn
            // 
            this.TotalofbookBtn.Location = new System.Drawing.Point(12, 150);
            this.TotalofbookBtn.Name = "TotalofbookBtn";
            this.TotalofbookBtn.Size = new System.Drawing.Size(279, 59);
            this.TotalofbookBtn.TabIndex = 27;
            this.TotalofbookBtn.Text = "tổng lượt mượn từng đầu sách";
            this.TotalofbookBtn.UseVisualStyleBackColor = true;
            this.TotalofbookBtn.Click += new System.EventHandler(this.TotalofbookBtn_Click);
            // 
            // ToptotalBtn
            // 
            this.ToptotalBtn.Location = new System.Drawing.Point(297, 150);
            this.ToptotalBtn.Name = "ToptotalBtn";
            this.ToptotalBtn.Size = new System.Drawing.Size(279, 59);
            this.ToptotalBtn.TabIndex = 28;
            this.ToptotalBtn.Text = "Top đầu sách được yêu thích";
            this.ToptotalBtn.UseVisualStyleBackColor = true;
            this.ToptotalBtn.Click += new System.EventHandler(this.ToptotalBtn_Click);
            // 
            // Rateofoutdatelabel
            // 
            this.Rateofoutdatelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rateofoutdatelabel.BackColor = System.Drawing.Color.White;
            this.Rateofoutdatelabel.Controls.Add(this.Rateofoutdate);
            this.Rateofoutdatelabel.Controls.Add(this.label3);
            this.Rateofoutdatelabel.Location = new System.Drawing.Point(298, 593);
            this.Rateofoutdatelabel.Name = "Rateofoutdatelabel";
            this.Rateofoutdatelabel.Size = new System.Drawing.Size(278, 69);
            this.Rateofoutdatelabel.TabIndex = 25;
            // 
            // Rateofoutdate
            // 
            this.Rateofoutdate.AutoSize = true;
            this.Rateofoutdate.Location = new System.Drawing.Point(102, 29);
            this.Rateofoutdate.Name = "Rateofoutdate";
            this.Rateofoutdate.Size = new System.Drawing.Size(64, 20);
            this.Rateofoutdate.TabIndex = 2;
            this.Rateofoutdate.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tỷ lệ sách mượn quá hạn";
            // 
            // Statistics_PerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.Rateofoutdatelabel);
            this.Controls.Add(this.ToptotalBtn);
            this.Controls.Add(this.TotalofbookBtn);
            this.Controls.Add(this.TotalPanel);
            this.Controls.Add(this.BooksListTable);
            this.Controls.Add(this.AlltimeBtn);
            this.Controls.Add(this.Totalofbookpanel);
            this.Controls.Add(this.ThisweekBtn);
            this.Controls.Add(this.CustomBtn);
            this.Controls.Add(this.RequestDataBtn);
            this.Controls.Add(this.ThismonthBtn);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Headerpanel);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics_PerformanceForm";
            this.Text = "PerformanceStatisticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PerformanceStatisticsForm_FormClosed);
            this.Load += new System.EventHandler(this.PerformanceStatisticsForm_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.Totalofbookpanel.ResumeLayout(false);
            this.Totalofbookpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListTable)).EndInit();
            this.TotalPanel.ResumeLayout(false);
            this.TotalPanel.PerformLayout();
            this.Rateofoutdatelabel.ResumeLayout(false);
            this.Rateofoutdatelabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label headername;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Button ThismonthBtn;
        private System.Windows.Forms.Button RequestDataBtn;
        private System.Windows.Forms.Button CustomBtn;
        private System.Windows.Forms.Button ThisweekBtn;
        private System.Windows.Forms.Panel Totalofbookpanel;
        private System.Windows.Forms.Label Totalofbook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AlltimeBtn;
        private System.Windows.Forms.DataGridView BooksListTable;
        private System.Windows.Forms.Panel TotalPanel;
        private System.Windows.Forms.Label Totalofloan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TotalofbookBtn;
        private System.Windows.Forms.Button ToptotalBtn;
        private System.Windows.Forms.Panel Rateofoutdatelabel;
        private System.Windows.Forms.Label Rateofoutdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitBtn;
    }
}