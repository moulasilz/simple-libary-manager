namespace WindowsFormsAppQLTV
{
    partial class Manager_ReaderForm
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
            this.txtmathe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenbandoc = new System.Windows.Forms.TextBox();
            this.txtmabandoc = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ReaderListTable = new System.Windows.Forms.DataGridView();
            this.ResetInfoBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.ChangeInfoBtn = new System.Windows.Forms.Button();
            this.bt_them_ = new System.Windows.Forms.Button();
            this.txtkeyword = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderListTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.Headerpanel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.exitBtn.TabIndex = 98;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headername
            // 
            this.headername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headername.AutoSize = true;
            this.headername.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.headername.Location = new System.Drawing.Point(434, 22);
            this.headername.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.headername.Name = "headername";
            this.headername.Size = new System.Drawing.Size(184, 23);
            this.headername.TabIndex = 0;
            this.headername.Text = "Quản lý bạn đọc";
            // 
            // txtmathe
            // 
            this.txtmathe.Location = new System.Drawing.Point(139, 5);
            this.txtmathe.Margin = new System.Windows.Forms.Padding(4);
            this.txtmathe.Name = "txtmathe";
            this.txtmathe.ReadOnly = true;
            this.txtmathe.Size = new System.Drawing.Size(272, 28);
            this.txtmathe.TabIndex = 79;
            this.txtmathe.Text = "tự động cấp khi thêm mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Tên bạn đọc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "Điện thoại:";
            // 
            // txttenbandoc
            // 
            this.txttenbandoc.Location = new System.Drawing.Point(119, 41);
            this.txttenbandoc.Margin = new System.Windows.Forms.Padding(4);
            this.txttenbandoc.Name = "txttenbandoc";
            this.txttenbandoc.Size = new System.Drawing.Size(259, 28);
            this.txttenbandoc.TabIndex = 72;
            // 
            // txtmabandoc
            // 
            this.txtmabandoc.Location = new System.Drawing.Point(119, 7);
            this.txtmabandoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtmabandoc.Name = "txtmabandoc";
            this.txtmabandoc.ReadOnly = true;
            this.txtmabandoc.Size = new System.Drawing.Size(259, 28);
            this.txtmabandoc.TabIndex = 77;
            this.txtmabandoc.Text = "tự động cấp khi thêm mới";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(119, 75);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(259, 28);
            this.txtsdt.TabIndex = 73;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(4, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Mã thẻ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(139, 39);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(272, 28);
            this.txtdiachi.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 81;
            this.label8.Text = "Địa chỉ :";
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "dd/MM/yyy";
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaysinh.Location = new System.Drawing.Point(119, 111);
            this.dt_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(259, 28);
            this.dt_ngaysinh.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(4, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 76;
            this.label11.Text = "Mã bạn đọc";
            // 
            // ReaderListTable
            // 
            this.ReaderListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReaderListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderListTable.Location = new System.Drawing.Point(13, 373);
            this.ReaderListTable.Margin = new System.Windows.Forms.Padding(4);
            this.ReaderListTable.Name = "ReaderListTable";
            this.ReaderListTable.ReadOnly = true;
            this.ReaderListTable.RowHeadersWidth = 51;
            this.ReaderListTable.Size = new System.Drawing.Size(988, 288);
            this.ReaderListTable.TabIndex = 82;
            this.ReaderListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReaderListTable_CellClick);
            // 
            // ResetInfoBtn
            // 
            this.ResetInfoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetInfoBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetInfoBtn.Location = new System.Drawing.Point(269, 332);
            this.ResetInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ResetInfoBtn.Name = "ResetInfoBtn";
            this.ResetInfoBtn.Size = new System.Drawing.Size(117, 32);
            this.ResetInfoBtn.TabIndex = 92;
            this.ResetInfoBtn.Text = "Khởi tạo";
            this.ResetInfoBtn.UseVisualStyleBackColor = false;
            this.ResetInfoBtn.Click += new System.EventHandler(this.ResetInfoBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 84;
            this.label7.Text = "Ngày hết hạn:";
            // 
            // dt_ngayhethan
            // 
            this.dt_ngayhethan.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayhethan.Location = new System.Drawing.Point(139, 109);
            this.dt_ngayhethan.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngayhethan.Name = "dt_ngayhethan";
            this.dt_ngayhethan.Size = new System.Drawing.Size(272, 28);
            this.dt_ngayhethan.TabIndex = 85;
            // 
            // ChangeInfoBtn
            // 
            this.ChangeInfoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChangeInfoBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeInfoBtn.Location = new System.Drawing.Point(565, 332);
            this.ChangeInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeInfoBtn.Name = "ChangeInfoBtn";
            this.ChangeInfoBtn.Size = new System.Drawing.Size(117, 32);
            this.ChangeInfoBtn.TabIndex = 91;
            this.ChangeInfoBtn.Text = "Sửa";
            this.ChangeInfoBtn.UseVisualStyleBackColor = false;
            this.ChangeInfoBtn.Click += new System.EventHandler(this.ChangeInfoBtn_Click);
            // 
            // bt_them_
            // 
            this.bt_them_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_them_.BackColor = System.Drawing.Color.White;
            this.bt_them_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them_.Location = new System.Drawing.Point(419, 331);
            this.bt_them_.Margin = new System.Windows.Forms.Padding(4);
            this.bt_them_.Name = "bt_them_";
            this.bt_them_.Size = new System.Drawing.Size(119, 34);
            this.bt_them_.TabIndex = 90;
            this.bt_them_.Text = "Thêm";
            this.bt_them_.UseVisualStyleBackColor = false;
            this.bt_them_.Click += new System.EventHandler(this.bt_them__Click);
            // 
            // txtkeyword
            // 
            this.txtkeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtkeyword.Location = new System.Drawing.Point(0, 4);
            this.txtkeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(477, 28);
            this.txtkeyword.TabIndex = 87;
            this.txtkeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkeyword_KeyDown);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(689, 269);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(108, 28);
            this.SearchBtn.TabIndex = 88;
            this.SearchBtn.Text = "Tìm kiếm";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(84, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "Nhập từ khóa";
            // 
            // dt_ngaycap
            // 
            this.dt_ngaycap.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaycap.Enabled = false;
            this.dt_ngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaycap.Location = new System.Drawing.Point(139, 73);
            this.dt_ngaycap.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaycap.Name = "dt_ngaycap";
            this.dt_ngaycap.Size = new System.Drawing.Size(272, 28);
            this.dt_ngaycap.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 83;
            this.label6.Text = "Ngày cấp";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(397, 14);
            this.label9.TabIndex = 94;
            this.label9.Text = "*Bạn có thể tìm bằng mã thẻ thư viện, tên, hoặc số điện thoại";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtmabandoc);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dt_ngaysinh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.txttenbandoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(67, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 147);
            this.panel1.TabIndex = 95;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtmathe);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtdiachi);
            this.panel2.Controls.Add(this.dt_ngayhethan);
            this.panel2.Controls.Add(this.dt_ngaycap);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(501, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 144);
            this.panel2.TabIndex = 96;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtkeyword);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(205, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 57);
            this.panel3.TabIndex = 97;
            // 
            // Manager_ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReaderListTable);
            this.Controls.Add(this.ResetInfoBtn);
            this.Controls.Add(this.ChangeInfoBtn);
            this.Controls.Add(this.bt_them_);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Headerpanel);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager_ReaderForm";
            this.Text = "ReaderManagerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_ReaderForm_FormClosed);
            this.Load += new System.EventHandler(this.ReaderManagerForm_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderListTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label headername;
        private System.Windows.Forms.TextBox txtmathe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenbandoc;
        private System.Windows.Forms.TextBox txtmabandoc;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView ReaderListTable;
        private System.Windows.Forms.Button ResetInfoBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_ngayhethan;
        private System.Windows.Forms.Button ChangeInfoBtn;
        private System.Windows.Forms.Button bt_them_;
        private System.Windows.Forms.TextBox txtkeyword;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_ngaycap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exitBtn;
    }
}