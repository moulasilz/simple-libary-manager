namespace WindowsFormsAppQLTV
{
    partial class Manager_BorrowForm
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
            this.CardIDtextBox = new System.Windows.Forms.TextBox();
            this.CardcheckBtn = new System.Windows.Forms.Button();
            this.LoanInsertgrbox = new System.Windows.Forms.GroupBox();
            this.PickAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.InsertNewLoanBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noticlabelBookID = new System.Windows.Forms.Label();
            this.BookIDrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.IDStatuslabel = new System.Windows.Forms.Label();
            this.IsreturnedLoanBtn = new System.Windows.Forms.Button();
            this.labelforstatus = new System.Windows.Forms.Label();
            this.LabelforID = new System.Windows.Forms.Label();
            this.LoanIDtextbox = new System.Windows.Forms.TextBox();
            this.LoancheckBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LoanListTable = new System.Windows.Forms.DataGridView();
            this.DetailedLoanListTable = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.Headerpanel.SuspendLayout();
            this.LoanInsertgrbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedLoanListTable)).BeginInit();
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
            this.Headerpanel.TabIndex = 5;
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
            this.exitBtn.TabIndex = 12;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headername
            // 
            this.headername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headername.AutoSize = true;
            this.headername.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.headername.Location = new System.Drawing.Point(412, 22);
            this.headername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headername.Name = "headername";
            this.headername.Size = new System.Drawing.Size(255, 23);
            this.headername.TabIndex = 0;
            this.headername.Text = "Quản lý mượn trả sách";
            // 
            // CardIDtextBox
            // 
            this.CardIDtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardIDtextBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardIDtextBox.Location = new System.Drawing.Point(157, 45);
            this.CardIDtextBox.Name = "CardIDtextBox";
            this.CardIDtextBox.Size = new System.Drawing.Size(156, 28);
            this.CardIDtextBox.TabIndex = 1;
            this.CardIDtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CardIDtextBox_KeyDown);
            this.CardIDtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardIDtextBox_KeyPress);
            // 
            // CardcheckBtn
            // 
            this.CardcheckBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardcheckBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardcheckBtn.Location = new System.Drawing.Point(319, 42);
            this.CardcheckBtn.Name = "CardcheckBtn";
            this.CardcheckBtn.Size = new System.Drawing.Size(98, 33);
            this.CardcheckBtn.TabIndex = 1;
            this.CardcheckBtn.Text = "Kiểm tra";
            this.CardcheckBtn.UseVisualStyleBackColor = true;
            this.CardcheckBtn.Click += new System.EventHandler(this.CardcheckBtn_Click);
            // 
            // LoanInsertgrbox
            // 
            this.LoanInsertgrbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoanInsertgrbox.Controls.Add(this.PickAppointmentDate);
            this.LoanInsertgrbox.Controls.Add(this.InsertNewLoanBtn);
            this.LoanInsertgrbox.Controls.Add(this.CardIDtextBox);
            this.LoanInsertgrbox.Controls.Add(this.label2);
            this.LoanInsertgrbox.Controls.Add(this.noticlabelBookID);
            this.LoanInsertgrbox.Controls.Add(this.BookIDrichTextBox);
            this.LoanInsertgrbox.Controls.Add(this.CardcheckBtn);
            this.LoanInsertgrbox.Controls.Add(this.label1);
            this.LoanInsertgrbox.Controls.Add(this.label4);
            this.LoanInsertgrbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoanInsertgrbox.Location = new System.Drawing.Point(22, 293);
            this.LoanInsertgrbox.Name = "LoanInsertgrbox";
            this.LoanInsertgrbox.Size = new System.Drawing.Size(418, 369);
            this.LoanInsertgrbox.TabIndex = 7;
            this.LoanInsertgrbox.TabStop = false;
            this.LoanInsertgrbox.Text = "Tạo phiếu mượn";
            // 
            // PickAppointmentDate
            // 
            this.PickAppointmentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PickAppointmentDate.CustomFormat = "dd/MM/yyyy";
            this.PickAppointmentDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickAppointmentDate.Location = new System.Drawing.Point(157, 91);
            this.PickAppointmentDate.Name = "PickAppointmentDate";
            this.PickAppointmentDate.Size = new System.Drawing.Size(260, 28);
            this.PickAppointmentDate.TabIndex = 11;
            // 
            // InsertNewLoanBtn
            // 
            this.InsertNewLoanBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertNewLoanBtn.Enabled = false;
            this.InsertNewLoanBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertNewLoanBtn.Location = new System.Drawing.Point(107, 311);
            this.InsertNewLoanBtn.Name = "InsertNewLoanBtn";
            this.InsertNewLoanBtn.Size = new System.Drawing.Size(170, 40);
            this.InsertNewLoanBtn.TabIndex = 10;
            this.InsertNewLoanBtn.Text = "Tạo phiếu mượn";
            this.InsertNewLoanBtn.UseVisualStyleBackColor = true;
            this.InsertNewLoanBtn.Click += new System.EventHandler(this.InsertNewLoanBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày hẹn trả:";
            // 
            // noticlabelBookID
            // 
            this.noticlabelBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noticlabelBookID.AutoSize = true;
            this.noticlabelBookID.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.noticlabelBookID.ForeColor = System.Drawing.Color.Red;
            this.noticlabelBookID.Location = new System.Drawing.Point(154, 280);
            this.noticlabelBookID.Name = "noticlabelBookID";
            this.noticlabelBookID.Size = new System.Drawing.Size(205, 16);
            this.noticlabelBookID.TabIndex = 9;
            this.noticlabelBookID.Text = "Chú ý: mỗi dòng một mã sách";
            this.noticlabelBookID.Visible = false;
            // 
            // BookIDrichTextBox
            // 
            this.BookIDrichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookIDrichTextBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDrichTextBox.Location = new System.Drawing.Point(157, 140);
            this.BookIDrichTextBox.Name = "BookIDrichTextBox";
            this.BookIDrichTextBox.Size = new System.Drawing.Size(260, 137);
            this.BookIDrichTextBox.TabIndex = 7;
            this.BookIDrichTextBox.Text = "";
            this.BookIDrichTextBox.Enter += new System.EventHandler(this.BookIDrichTextBox_Enter);
            this.BookIDrichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookIDrichTextBox_KeyPress);
            this.BookIDrichTextBox.Leave += new System.EventHandler(this.BookIDrichTextBox_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã thẻ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã sách mượn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Statuslabel);
            this.groupBox1.Controls.Add(this.IDStatuslabel);
            this.groupBox1.Controls.Add(this.IsreturnedLoanBtn);
            this.groupBox1.Controls.Add(this.labelforstatus);
            this.groupBox1.Controls.Add(this.LabelforID);
            this.groupBox1.Controls.Add(this.LoanIDtextbox);
            this.groupBox1.Controls.Add(this.LoancheckBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(150, 131);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(56, 20);
            this.Statuslabel.TabIndex = 19;
            this.Statuslabel.Text = "Trống";
            // 
            // IDStatuslabel
            // 
            this.IDStatuslabel.AutoSize = true;
            this.IDStatuslabel.Location = new System.Drawing.Point(150, 99);
            this.IDStatuslabel.Name = "IDStatuslabel";
            this.IDStatuslabel.Size = new System.Drawing.Size(56, 20);
            this.IDStatuslabel.TabIndex = 18;
            this.IDStatuslabel.Text = "Trống";
            // 
            // IsreturnedLoanBtn
            // 
            this.IsreturnedLoanBtn.Enabled = false;
            this.IsreturnedLoanBtn.Location = new System.Drawing.Point(308, 99);
            this.IsreturnedLoanBtn.Name = "IsreturnedLoanBtn";
            this.IsreturnedLoanBtn.Size = new System.Drawing.Size(103, 52);
            this.IsreturnedLoanBtn.TabIndex = 17;
            this.IsreturnedLoanBtn.Text = "Đánh dấu đã trả";
            this.IsreturnedLoanBtn.UseVisualStyleBackColor = true;
            this.IsreturnedLoanBtn.Click += new System.EventHandler(this.IsreturnedLoanBtn_Click);
            // 
            // labelforstatus
            // 
            this.labelforstatus.AutoSize = true;
            this.labelforstatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelforstatus.Location = new System.Drawing.Point(41, 131);
            this.labelforstatus.Name = "labelforstatus";
            this.labelforstatus.Size = new System.Drawing.Size(114, 20);
            this.labelforstatus.TabIndex = 16;
            this.labelforstatus.Text = "Trạng thái:";
            // 
            // LabelforID
            // 
            this.LabelforID.AutoSize = true;
            this.LabelforID.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.LabelforID.Location = new System.Drawing.Point(41, 99);
            this.LabelforID.Name = "LabelforID";
            this.LabelforID.Size = new System.Drawing.Size(69, 20);
            this.LabelforID.TabIndex = 15;
            this.LabelforID.Text = "Phiếu:";
            // 
            // LoanIDtextbox
            // 
            this.LoanIDtextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoanIDtextbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanIDtextbox.Location = new System.Drawing.Point(166, 54);
            this.LoanIDtextbox.Name = "LoanIDtextbox";
            this.LoanIDtextbox.Size = new System.Drawing.Size(175, 28);
            this.LoanIDtextbox.TabIndex = 12;
            this.LoanIDtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoanIDtextbox_KeyDown);
            this.LoanIDtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoanIDtextbox_KeyPress);
            // 
            // LoancheckBtn
            // 
            this.LoancheckBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoancheckBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoancheckBtn.Location = new System.Drawing.Point(347, 51);
            this.LoancheckBtn.Name = "LoancheckBtn";
            this.LoancheckBtn.Size = new System.Drawing.Size(70, 33);
            this.LoancheckBtn.TabIndex = 13;
            this.LoancheckBtn.Text = "Tìm";
            this.LoancheckBtn.UseVisualStyleBackColor = true;
            this.LoancheckBtn.Click += new System.EventHandler(this.LoancheckBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã phiếu mượn:";
            // 
            // LoanListTable
            // 
            this.LoanListTable.AllowUserToAddRows = false;
            this.LoanListTable.AllowUserToDeleteRows = false;
            this.LoanListTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanListTable.Location = new System.Drawing.Point(459, 115);
            this.LoanListTable.Name = "LoanListTable";
            this.LoanListTable.ReadOnly = true;
            this.LoanListTable.RowHeadersWidth = 51;
            this.LoanListTable.RowTemplate.Height = 24;
            this.LoanListTable.Size = new System.Drawing.Size(543, 322);
            this.LoanListTable.TabIndex = 9;
            this.LoanListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanListTable_CellClick);
            // 
            // DetailedLoanListTable
            // 
            this.DetailedLoanListTable.AllowUserToAddRows = false;
            this.DetailedLoanListTable.AllowUserToDeleteRows = false;
            this.DetailedLoanListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailedLoanListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailedLoanListTable.Location = new System.Drawing.Point(459, 443);
            this.DetailedLoanListTable.Name = "DetailedLoanListTable";
            this.DetailedLoanListTable.ReadOnly = true;
            this.DetailedLoanListTable.RowHeadersWidth = 51;
            this.DetailedLoanListTable.RowTemplate.Height = 24;
            this.DetailedLoanListTable.Size = new System.Drawing.Size(543, 219);
            this.DetailedLoanListTable.TabIndex = 10;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.Location = new System.Drawing.Point(909, 78);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(93, 31);
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.Text = "Làm mới";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Manager_BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1014, 674);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DetailedLoanListTable);
            this.Controls.Add(this.LoanListTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoanInsertgrbox);
            this.Controls.Add(this.Headerpanel);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager_BorrowForm";
            this.Text = "BorrowManagerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BorrowManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.BorrowManagerForm_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            this.LoanInsertgrbox.ResumeLayout(false);
            this.LoanInsertgrbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedLoanListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label headername;
        private System.Windows.Forms.Button CardcheckBtn;
        private System.Windows.Forms.TextBox CardIDtextBox;
        private System.Windows.Forms.GroupBox LoanInsertgrbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox BookIDrichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noticlabelBookID;
        private System.Windows.Forms.DateTimePicker PickAppointmentDate;
        private System.Windows.Forms.Button InsertNewLoanBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button IsreturnedLoanBtn;
        private System.Windows.Forms.Label labelforstatus;
        private System.Windows.Forms.Label LabelforID;
        private System.Windows.Forms.TextBox LoanIDtextbox;
        private System.Windows.Forms.Button LoancheckBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LoanListTable;
        private System.Windows.Forms.DataGridView DetailedLoanListTable;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label IDStatuslabel;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}