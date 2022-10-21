namespace WindowsFormsAppQLTV
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuStatistics = new System.Windows.Forms.Panel();
            this.PerformanceStatisticsBtn = new System.Windows.Forms.Button();
            this.BorrowGiveStatisticsBtn = new System.Windows.Forms.Button();
            this.ReaderStatisticsBtn = new System.Windows.Forms.Button();
            this.ImportExportStatisticsBtn = new System.Windows.Forms.Button();
            this.BookStatisticsBtn = new System.Windows.Forms.Button();
            this.statisticsManagerBtn = new System.Windows.Forms.Button();
            this.BookManagerBtn = new System.Windows.Forms.Button();
            this.BorrowGiveManagerBtn = new System.Windows.Forms.Button();
            this.ReaderManagerBtn = new System.Windows.Forms.Button();
            this.panelheadertop = new System.Windows.Forms.Panel();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.panelMenu.Controls.Add(this.panelSubMenuStatistics);
            this.panelMenu.Controls.Add(this.statisticsManagerBtn);
            this.panelMenu.Controls.Add(this.BookManagerBtn);
            this.panelMenu.Controls.Add(this.BorrowGiveManagerBtn);
            this.panelMenu.Controls.Add(this.ReaderManagerBtn);
            this.panelMenu.Controls.Add(this.panelheadertop);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(316, 721);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSubMenuStatistics
            // 
            this.panelSubMenuStatistics.Controls.Add(this.PerformanceStatisticsBtn);
            this.panelSubMenuStatistics.Controls.Add(this.BorrowGiveStatisticsBtn);
            this.panelSubMenuStatistics.Controls.Add(this.ReaderStatisticsBtn);
            this.panelSubMenuStatistics.Controls.Add(this.ImportExportStatisticsBtn);
            this.panelSubMenuStatistics.Controls.Add(this.BookStatisticsBtn);
            this.panelSubMenuStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuStatistics.Location = new System.Drawing.Point(0, 311);
            this.panelSubMenuStatistics.Name = "panelSubMenuStatistics";
            this.panelSubMenuStatistics.Size = new System.Drawing.Size(316, 307);
            this.panelSubMenuStatistics.TabIndex = 11;
            this.panelSubMenuStatistics.Visible = false;
            // 
            // PerformanceStatisticsBtn
            // 
            this.PerformanceStatisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PerformanceStatisticsBtn.FlatAppearance.BorderSize = 0;
            this.PerformanceStatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformanceStatisticsBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformanceStatisticsBtn.ForeColor = System.Drawing.Color.White;
            this.PerformanceStatisticsBtn.Location = new System.Drawing.Point(0, 240);
            this.PerformanceStatisticsBtn.Name = "PerformanceStatisticsBtn";
            this.PerformanceStatisticsBtn.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.PerformanceStatisticsBtn.Size = new System.Drawing.Size(316, 60);
            this.PerformanceStatisticsBtn.TabIndex = 8;
            this.PerformanceStatisticsBtn.Text = "Thống kê báo cáo hiệu quả";
            this.PerformanceStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PerformanceStatisticsBtn.UseVisualStyleBackColor = true;
            this.PerformanceStatisticsBtn.Click += new System.EventHandler(this.PerformanceStatisticsBtn_Click);
            // 
            // BorrowGiveStatisticsBtn
            // 
            this.BorrowGiveStatisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorrowGiveStatisticsBtn.FlatAppearance.BorderSize = 0;
            this.BorrowGiveStatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowGiveStatisticsBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowGiveStatisticsBtn.ForeColor = System.Drawing.Color.White;
            this.BorrowGiveStatisticsBtn.Location = new System.Drawing.Point(0, 180);
            this.BorrowGiveStatisticsBtn.Name = "BorrowGiveStatisticsBtn";
            this.BorrowGiveStatisticsBtn.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.BorrowGiveStatisticsBtn.Size = new System.Drawing.Size(316, 60);
            this.BorrowGiveStatisticsBtn.TabIndex = 7;
            this.BorrowGiveStatisticsBtn.Text = "Thống kê mượn, trả";
            this.BorrowGiveStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowGiveStatisticsBtn.UseVisualStyleBackColor = true;
            this.BorrowGiveStatisticsBtn.Click += new System.EventHandler(this.BorrowGiveStatisticsBtn_Click);
            // 
            // ReaderStatisticsBtn
            // 
            this.ReaderStatisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReaderStatisticsBtn.FlatAppearance.BorderSize = 0;
            this.ReaderStatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReaderStatisticsBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderStatisticsBtn.ForeColor = System.Drawing.Color.White;
            this.ReaderStatisticsBtn.Location = new System.Drawing.Point(0, 120);
            this.ReaderStatisticsBtn.Name = "ReaderStatisticsBtn";
            this.ReaderStatisticsBtn.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ReaderStatisticsBtn.Size = new System.Drawing.Size(316, 60);
            this.ReaderStatisticsBtn.TabIndex = 6;
            this.ReaderStatisticsBtn.Text = "Thống kê bạn đọc";
            this.ReaderStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReaderStatisticsBtn.UseVisualStyleBackColor = true;
            this.ReaderStatisticsBtn.Click += new System.EventHandler(this.ReaderStatisticsBtn_Click);
            // 
            // ImportExportStatisticsBtn
            // 
            this.ImportExportStatisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImportExportStatisticsBtn.FlatAppearance.BorderSize = 0;
            this.ImportExportStatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportExportStatisticsBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportExportStatisticsBtn.ForeColor = System.Drawing.Color.White;
            this.ImportExportStatisticsBtn.Location = new System.Drawing.Point(0, 60);
            this.ImportExportStatisticsBtn.Name = "ImportExportStatisticsBtn";
            this.ImportExportStatisticsBtn.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ImportExportStatisticsBtn.Size = new System.Drawing.Size(316, 60);
            this.ImportExportStatisticsBtn.TabIndex = 5;
            this.ImportExportStatisticsBtn.Text = "Thống kê nhâp, xuất sách";
            this.ImportExportStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportExportStatisticsBtn.UseVisualStyleBackColor = true;
            this.ImportExportStatisticsBtn.Click += new System.EventHandler(this.ImportExportStatisticsBtn_Click);
            // 
            // BookStatisticsBtn
            // 
            this.BookStatisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookStatisticsBtn.FlatAppearance.BorderSize = 0;
            this.BookStatisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookStatisticsBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookStatisticsBtn.ForeColor = System.Drawing.Color.White;
            this.BookStatisticsBtn.Location = new System.Drawing.Point(0, 0);
            this.BookStatisticsBtn.Name = "BookStatisticsBtn";
            this.BookStatisticsBtn.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.BookStatisticsBtn.Size = new System.Drawing.Size(316, 60);
            this.BookStatisticsBtn.TabIndex = 4;
            this.BookStatisticsBtn.Text = "Thống kê đầu sách";
            this.BookStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookStatisticsBtn.UseVisualStyleBackColor = false;
            this.BookStatisticsBtn.Click += new System.EventHandler(this.BookStatisticsBtn_Click);
            // 
            // statisticsManagerBtn
            // 
            this.statisticsManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsManagerBtn.FlatAppearance.BorderSize = 0;
            this.statisticsManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsManagerBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsManagerBtn.ForeColor = System.Drawing.Color.White;
            this.statisticsManagerBtn.Image = global::WindowsFormsAppQLTV.Properties.Resources.icons8_left_verticle_line_parting_block_into_two_section_16;
            this.statisticsManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsManagerBtn.Location = new System.Drawing.Point(0, 251);
            this.statisticsManagerBtn.Name = "statisticsManagerBtn";
            this.statisticsManagerBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.statisticsManagerBtn.Size = new System.Drawing.Size(316, 60);
            this.statisticsManagerBtn.TabIndex = 10;
            this.statisticsManagerBtn.Text = "     Thống kê báo cáo";
            this.statisticsManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsManagerBtn.UseVisualStyleBackColor = true;
            this.statisticsManagerBtn.Click += new System.EventHandler(this.statisticsManagerBtn_Click);
            // 
            // BookManagerBtn
            // 
            this.BookManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookManagerBtn.FlatAppearance.BorderSize = 0;
            this.BookManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookManagerBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookManagerBtn.ForeColor = System.Drawing.Color.White;
            this.BookManagerBtn.Image = global::WindowsFormsAppQLTV.Properties.Resources.icons8_left_verticle_line_parting_block_into_two_section_16;
            this.BookManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookManagerBtn.Location = new System.Drawing.Point(0, 191);
            this.BookManagerBtn.Name = "BookManagerBtn";
            this.BookManagerBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BookManagerBtn.Size = new System.Drawing.Size(316, 60);
            this.BookManagerBtn.TabIndex = 8;
            this.BookManagerBtn.Text = "     Quản lý kho sách";
            this.BookManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookManagerBtn.UseVisualStyleBackColor = true;
            this.BookManagerBtn.Click += new System.EventHandler(this.BookManagerBtn_Click);
            // 
            // BorrowGiveManagerBtn
            // 
            this.BorrowGiveManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorrowGiveManagerBtn.FlatAppearance.BorderSize = 0;
            this.BorrowGiveManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowGiveManagerBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowGiveManagerBtn.ForeColor = System.Drawing.Color.White;
            this.BorrowGiveManagerBtn.Image = global::WindowsFormsAppQLTV.Properties.Resources.icons8_left_verticle_line_parting_block_into_two_section_16;
            this.BorrowGiveManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowGiveManagerBtn.Location = new System.Drawing.Point(0, 131);
            this.BorrowGiveManagerBtn.Name = "BorrowGiveManagerBtn";
            this.BorrowGiveManagerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BorrowGiveManagerBtn.Size = new System.Drawing.Size(316, 60);
            this.BorrowGiveManagerBtn.TabIndex = 6;
            this.BorrowGiveManagerBtn.Text = "     Quản lý mượn trả";
            this.BorrowGiveManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowGiveManagerBtn.UseVisualStyleBackColor = true;
            this.BorrowGiveManagerBtn.Click += new System.EventHandler(this.BorrowGiveManagerBtn_Click);
            // 
            // ReaderManagerBtn
            // 
            this.ReaderManagerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReaderManagerBtn.FlatAppearance.BorderSize = 0;
            this.ReaderManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReaderManagerBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderManagerBtn.ForeColor = System.Drawing.Color.White;
            this.ReaderManagerBtn.Image = global::WindowsFormsAppQLTV.Properties.Resources.icons8_left_verticle_line_parting_block_into_two_section_16;
            this.ReaderManagerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReaderManagerBtn.Location = new System.Drawing.Point(0, 71);
            this.ReaderManagerBtn.Name = "ReaderManagerBtn";
            this.ReaderManagerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ReaderManagerBtn.Size = new System.Drawing.Size(316, 60);
            this.ReaderManagerBtn.TabIndex = 4;
            this.ReaderManagerBtn.Text = "     Quản lý bạn đọc";
            this.ReaderManagerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReaderManagerBtn.UseVisualStyleBackColor = true;
            this.ReaderManagerBtn.Click += new System.EventHandler(this.ReaderManagerBtn_Click);
            // 
            // panelheadertop
            // 
            this.panelheadertop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.panelheadertop.BackgroundImage = global::WindowsFormsAppQLTV.Properties.Resources._1111111;
            this.panelheadertop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelheadertop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheadertop.Location = new System.Drawing.Point(0, 0);
            this.panelheadertop.Name = "panelheadertop";
            this.panelheadertop.Size = new System.Drawing.Size(316, 71);
            this.panelheadertop.TabIndex = 0;
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainContainer.BackgroundImage = global::WindowsFormsAppQLTV.Properties.Resources.LogoLibrary_removebg_preview;
            this.panelMainContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMainContainer.Location = new System.Drawing.Point(316, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1032, 721);
            this.panelMainContainer.TabIndex = 1;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FormMainMenu";
            this.Text = "Chương trình quản lý thư viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheadertop;
        private System.Windows.Forms.Button ReaderManagerBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BorrowGiveManagerBtn;
        private System.Windows.Forms.Panel panelSubMenuStatistics;
        private System.Windows.Forms.Button PerformanceStatisticsBtn;
        private System.Windows.Forms.Button BorrowGiveStatisticsBtn;
        private System.Windows.Forms.Button ReaderStatisticsBtn;
        private System.Windows.Forms.Button ImportExportStatisticsBtn;
        private System.Windows.Forms.Button BookStatisticsBtn;
        private System.Windows.Forms.Button statisticsManagerBtn;
        private System.Windows.Forms.Button BookManagerBtn;
        private System.Windows.Forms.Panel panelMainContainer;
    }
}

