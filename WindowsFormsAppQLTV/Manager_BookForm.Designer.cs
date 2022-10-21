namespace WindowsFormsAppQLTV
{
    partial class Manager_BookForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Exportdatelabel = new System.Windows.Forms.Label();
            this.Countlabel = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IsExportedBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.EditbookBtn = new System.Windows.Forms.Button();
            this.AddbookBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BookImportdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BookConditiontextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BookAuthorTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookNametexbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookIDtextbox = new System.Windows.Forms.TextBox();
            this.BooksListTable = new System.Windows.Forms.DataGridView();
            this.Headerpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.Headerpanel.Margin = new System.Windows.Forms.Padding(5);
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
            this.exitBtn.TabIndex = 1;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headername
            // 
            this.headername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headername.AutoSize = true;
            this.headername.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.headername.Location = new System.Drawing.Point(456, 22);
            this.headername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headername.Name = "headername";
            this.headername.Size = new System.Drawing.Size(196, 23);
            this.headername.TabIndex = 0;
            this.headername.Text = "Quản lý kho sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Exportdatelabel);
            this.groupBox1.Controls.Add(this.Countlabel);
            this.groupBox1.Controls.Add(this.Statuslabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.IsExportedBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.SearchTextbox);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 7F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "*có thể tìm bằng tên hoặc mã sách";
            // 
            // Exportdatelabel
            // 
            this.Exportdatelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exportdatelabel.AutoSize = true;
            this.Exportdatelabel.Font = new System.Drawing.Font("Verdana", 9.2F);
            this.Exportdatelabel.Location = new System.Drawing.Point(130, 153);
            this.Exportdatelabel.Name = "Exportdatelabel";
            this.Exportdatelabel.Size = new System.Drawing.Size(52, 18);
            this.Exportdatelabel.TabIndex = 19;
            this.Exportdatelabel.Text = "Trống";
            // 
            // Countlabel
            // 
            this.Countlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Countlabel.AutoSize = true;
            this.Countlabel.Font = new System.Drawing.Font("Verdana", 9.2F);
            this.Countlabel.Location = new System.Drawing.Point(131, 123);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(18, 18);
            this.Countlabel.TabIndex = 18;
            this.Countlabel.Text = "0";
            // 
            // Statuslabel
            // 
            this.Statuslabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Font = new System.Drawing.Font("Verdana", 9.2F);
            this.Statuslabel.ForeColor = System.Drawing.Color.Green;
            this.Statuslabel.Location = new System.Drawing.Point(130, 92);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(52, 18);
            this.Statuslabel.TabIndex = 17;
            this.Statuslabel.Text = "Trống";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(26, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày xuất:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(26, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lượt mượn:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(26, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trạng thái:";
            // 
            // IsExportedBtn
            // 
            this.IsExportedBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IsExportedBtn.Enabled = false;
            this.IsExportedBtn.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.IsExportedBtn.Location = new System.Drawing.Point(35, 182);
            this.IsExportedBtn.Name = "IsExportedBtn";
            this.IsExportedBtn.Size = new System.Drawing.Size(191, 38);
            this.IsExportedBtn.TabIndex = 1;
            this.IsExportedBtn.Text = "Đánh dấu đã xuất";
            this.IsExportedBtn.UseVisualStyleBackColor = true;
            this.IsExportedBtn.Click += new System.EventHandler(this.IsExportedBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBtn.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.SearchBtn.Location = new System.Drawing.Point(214, 32);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(68, 28);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Tìm";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextbox.Font = new System.Drawing.Font("Verdana", 10F);
            this.SearchTextbox.Location = new System.Drawing.Point(6, 32);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(202, 28);
            this.SearchTextbox.TabIndex = 0;
            this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RefreshBtn);
            this.groupBox3.Controls.Add(this.EditbookBtn);
            this.groupBox3.Controls.Add(this.AddbookBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.BookImportdate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BookConditiontextbox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BookAuthorTextbox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BookNametexbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BookIDtextbox);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(306, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 235);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cập nhật sách";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.RefreshBtn.Location = new System.Drawing.Point(509, 175);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(140, 40);
            this.RefreshBtn.TabIndex = 12;
            this.RefreshBtn.Text = "Khởi tạo";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // EditbookBtn
            // 
            this.EditbookBtn.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.EditbookBtn.Location = new System.Drawing.Point(509, 125);
            this.EditbookBtn.Name = "EditbookBtn";
            this.EditbookBtn.Size = new System.Drawing.Size(140, 40);
            this.EditbookBtn.TabIndex = 11;
            this.EditbookBtn.Text = "Sửa";
            this.EditbookBtn.UseVisualStyleBackColor = true;
            this.EditbookBtn.Click += new System.EventHandler(this.EditbookBtn_Click);
            // 
            // AddbookBtn
            // 
            this.AddbookBtn.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.AddbookBtn.Location = new System.Drawing.Point(509, 75);
            this.AddbookBtn.Name = "AddbookBtn";
            this.AddbookBtn.Size = new System.Drawing.Size(140, 40);
            this.AddbookBtn.TabIndex = 2;
            this.AddbookBtn.Text = "Thêm";
            this.AddbookBtn.UseVisualStyleBackColor = true;
            this.AddbookBtn.Click += new System.EventHandler(this.AddbookBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(414, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày nhập:";
            // 
            // BookImportdate
            // 
            this.BookImportdate.CustomFormat = "dd/MM/yyyy";
            this.BookImportdate.Enabled = false;
            this.BookImportdate.Font = new System.Drawing.Font("Verdana", 10F);
            this.BookImportdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BookImportdate.Location = new System.Drawing.Point(521, 32);
            this.BookImportdate.Name = "BookImportdate";
            this.BookImportdate.Size = new System.Drawing.Size(169, 28);
            this.BookImportdate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tình trạng sách:";
            // 
            // BookConditiontextbox
            // 
            this.BookConditiontextbox.Font = new System.Drawing.Font("Verdana", 10F);
            this.BookConditiontextbox.Location = new System.Drawing.Point(151, 182);
            this.BookConditiontextbox.Name = "BookConditiontextbox";
            this.BookConditiontextbox.Size = new System.Drawing.Size(302, 28);
            this.BookConditiontextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên sách:";
            // 
            // BookAuthorTextbox
            // 
            this.BookAuthorTextbox.Font = new System.Drawing.Font("Verdana", 10F);
            this.BookAuthorTextbox.Location = new System.Drawing.Point(151, 132);
            this.BookAuthorTextbox.Name = "BookAuthorTextbox";
            this.BookAuthorTextbox.Size = new System.Drawing.Size(302, 28);
            this.BookAuthorTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên tác giả:";
            // 
            // BookNametexbox
            // 
            this.BookNametexbox.Font = new System.Drawing.Font("Verdana", 10F);
            this.BookNametexbox.Location = new System.Drawing.Point(151, 82);
            this.BookNametexbox.Name = "BookNametexbox";
            this.BookNametexbox.Size = new System.Drawing.Size(302, 28);
            this.BookNametexbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách:";
            // 
            // BookIDtextbox
            // 
            this.BookIDtextbox.Font = new System.Drawing.Font("Verdana", 10F);
            this.BookIDtextbox.Location = new System.Drawing.Point(151, 32);
            this.BookIDtextbox.Name = "BookIDtextbox";
            this.BookIDtextbox.ReadOnly = true;
            this.BookIDtextbox.Size = new System.Drawing.Size(239, 28);
            this.BookIDtextbox.TabIndex = 1;
            this.BookIDtextbox.Click += new System.EventHandler(this.BookIDtextbox_Click);
            this.BookIDtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookIDtextbox_KeyPress);
            // 
            // BooksListTable
            // 
            this.BooksListTable.AllowUserToDeleteRows = false;
            this.BooksListTable.AllowUserToResizeRows = false;
            this.BooksListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksListTable.Location = new System.Drawing.Point(13, 320);
            this.BooksListTable.Margin = new System.Windows.Forms.Padding(4);
            this.BooksListTable.Name = "BooksListTable";
            this.BooksListTable.ReadOnly = true;
            this.BooksListTable.RowHeadersWidth = 51;
            this.BooksListTable.RowTemplate.Height = 24;
            this.BooksListTable.Size = new System.Drawing.Size(988, 341);
            this.BooksListTable.TabIndex = 9;
            this.BooksListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksListTable_CellClick);
            // 
            // Manager_BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.BooksListTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Headerpanel);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager_BookForm";
            this.Text = "Manager_BookForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_BookForm_FormClosed);
            this.Load += new System.EventHandler(this.Manager_BookForm_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label headername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView BooksListTable;
        private System.Windows.Forms.Label Exportdatelabel;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button IsExportedBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button EditbookBtn;
        private System.Windows.Forms.Button AddbookBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BookImportdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookConditiontextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BookAuthorTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookNametexbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookIDtextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exitBtn;
    }
}