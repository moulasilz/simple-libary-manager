using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsAppQLTV
{
    public partial class Manager_BorrowForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True;");
        string SearchQueryCmdFull = @"Select * from dbo.phieumuon;";
        string SearchQueryCmdCheck;
        DataSet Loan_ds = new DataSet();
        int isChecked = 0;
        public Manager_BorrowForm()
        {
            InitializeComponent();
            PickAppointmentDate.Value = DateTime.Now;
        }
        // Fill data from database to datagridview table
        private void FillDataToGirdView(string SearchQueryCmd)
        {
            Loan_ds.Reset();
            SqlCommand cmd = new SqlCommand(SearchQueryCmd, conn);
            SqlDataAdapter DataAdaper = new SqlDataAdapter(cmd);
            DataAdaper.Fill(Loan_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renameofloan(Loan_ds);
            LoanListTable.DataSource = Loan_ds.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(LoanListTable);
            tabledesign.autofillgirdviewcol(LoanListTable, Loan_ds.Tables[0].Columns.Count);
        }
        private void LoanListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet DetailedLoan_ds = new DataSet();
            string QueryCmd = @"Select dbo.chitietphieumuon.masach, dbo.sach.tensach
		                        from (dbo.chitietphieumuon INNER JOIN dbo.sach ON dbo.chitietphieumuon.masach = dbo.sach.masach)
		                        where (dbo.chitietphieumuon.maphieumuon = '" + LoanListTable.Rows[LoanListTable.CurrentRow.Index].Cells[0].Value.ToString() + "');";
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(DetailedLoan_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renameofdetailedloan(DetailedLoan_ds);
            DetailedLoanListTable.DataSource = DetailedLoan_ds.Tables[0].DefaultView;
            tabledesign.autofillgirdviewcol(DetailedLoanListTable, DetailedLoan_ds.Tables[0].Columns.Count);
            filldatatolabel(LoanListTable.CurrentRow.Index);
        }

        private void BorrowManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    conn.Open();
                }
                catch 
                {
                    conn.ConnectionString = @"Data Source=.\SQLExpress;Initial Catalog=qlthuvien;Integrated Security=True";
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "không thể kết nối database");
                this.Close();
            }
            FillDataToGirdView(SearchQueryCmdFull);
        }

        private void BorrowManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch  { }
        }
        // Show notic of 
        private void BookIDrichTextBox_Enter(object sender, EventArgs e)
        {
            noticlabelBookID.Visible = true;
        }
        private void BookIDrichTextBox_Leave(object sender, EventArgs e)
        {
            noticlabelBookID.Visible = false;
        }
       
// Disable type text, only type number
        private void disabletypetext(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void CardIDtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            disabletypetext(sender, e);
        }
        private void LoanIDtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            disabletypetext(sender, e);
        }
        private void BookIDrichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            disabletypetext(sender, e);
        }

// Insert new Loan information to database

        // Check Card ID (validate Card ID)
        private void CheckCardID() 
        {
            int IsCardValid;
            int LoanNotReturn;
            int IsReaderBanned;
            int ReaderMistake;
            using (var cmdCheck = new SqlCommand())
            {
                cmdCheck.Connection = conn;
                //Check: is card out of date?
                cmdCheck.CommandText = @"select COUNT(*) from dbo.thethuvien
		                where (thethuvien.mathe = '" + CardIDtextBox.Text + "' AND thethuvien.hanthe < GETDATE())";
                IsCardValid = (int)cmdCheck.ExecuteScalar();

                //Check: is reader have borrow not return?
                cmdCheck.CommandText = @"select COUNT(*) from dbo.phieumuon
		                                where (phieumuon.mathe =  '" + CardIDtextBox.Text + "'  AND phieumuon.ngaytra is NULL)";
                LoanNotReturn = (int)cmdCheck.ExecuteScalar();

                //Check: is reader have too much mistake (mistake>15)?
                cmdCheck.CommandText = @"SELECT COUNT(bandoc.mabandoc)FROM dbo.bandoc, dbo.thethuvien
			                                WHERE (thethuvien.mathe =  '" + CardIDtextBox.Text + "'  AND bandoc.mabandoc = thethuvien.mabandoc AND bandoc.loi > '15')";
                IsReaderBanned = (int)cmdCheck.ExecuteScalar();

                //Get: reader mistake times
                cmdCheck.CommandText = @"SELECT bandoc.loi FROM dbo.bandoc, dbo.thethuvien
			                                        WHERE (bandoc.mabandoc = thethuvien.mabandoc AND thethuvien.mathe = '" + CardIDtextBox.Text + "')";
                ReaderMistake = (int)cmdCheck.ExecuteScalar();
            }
            if (IsCardValid == 1 || IsReaderBanned == 1 || LoanNotReturn == 1)
            {
                // Create and add error list items to the list
                var ErrorList = new List<string>();
                ErrorList.Add("Thẻ " + CardIDtextBox.Text + " không thể mượn sách. Lý do:");
                if (IsCardValid == 1) ErrorList.Add(" - Thẻ đã quá hạn.");
                if (IsReaderBanned == 1) ErrorList.Add(" - Thẻ bị cấm: có quá nhiều lần vi phạm (" + ReaderMistake + " lần).");
                if (LoanNotReturn == 1) ErrorList.Add(" - Thẻ có sách mượn chưa trả.");
                // Convert to array and show error list
                MessageBox.Show(string.Join(Environment.NewLine, ErrorList.ToArray()));
            }
            else
            {
                MessageBox.Show("Thẻ " + CardIDtextBox.Text + " hợp lệ (có thể mượn sách)");
                InsertNewLoanBtn.Enabled = true;
            }
        }
        private void CardcheckBtn_Click(object sender, EventArgs e)
        {
            InsertNewLoanBtn.Enabled = false;
            if (CardIDtextBox.Text == "") MessageBox.Show("Vui lòng nhập mã thẻ!");
            else
            {
                SqlCommand CmdCheckAvailable = new SqlCommand(@"select * from dbo.thethuvien where thethuvien.mathe = '" + CardIDtextBox.Text + "'", conn);
                if (CmdCheckAvailable.ExecuteScalar() is null) MessageBox.Show("Thẻ " + CardIDtextBox.Text + " không tồn tại!");
                else CheckCardID();
            }
        }
        private void CardIDtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CardcheckBtn_Click(sender, e);
            }
        }
        // validate Book ID : is unReturned or doesn't exist
        private void validatebookID(SqlCommand sqlCommand)
        {
            isChecked = 0;
            for (int i = 0; i < BookIDrichTextBox.Lines.Length; i++)
            {
                if (BookIDrichTextBox.Lines[i].ToString() != "")
                {
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM dbo.sach Where sach.masach = '" + BookIDrichTextBox.Lines[i].ToString() + "'";
                    if ((int)sqlCommand.ExecuteScalar() == 0)
                    {
                        isChecked++;
                    }
                    sqlCommand.CommandText = @"SELECT COUNT(*) FROM dbo.sach Where (sach.masach = '" + BookIDrichTextBox.Lines[i].ToString() + "' AND sach.ngayxuat is NULL)";
                    if((int)sqlCommand.ExecuteScalar() == 0)
                    {
                        isChecked++;
                    }
                    sqlCommand.CommandText = @"SELECT COUNT(chitietphieumuon.masach) FROM  dbo.chitietphieumuon, dbo.phieumuon
			        WHERE (chitietphieumuon.masach = '" + BookIDrichTextBox.Lines[i].ToString() + "' AND chitietphieumuon.maphieumuon = phieumuon.maphieumuon AND phieumuon.ngaytra is NULL)";
                    if ((int)sqlCommand.ExecuteScalar() != 0)
                    {
                        isChecked++;
                    }
                }
            }
        }

        // click to Insert new loan 
        private void InsertNewLoanBtn_Click(object sender, EventArgs e)
        {
            int LastLoanID;
            int LastDetailID;
            using (var sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = conn;
                //Get last Loan ID value
                sqlCommand.CommandText = @"WITH Ordered AS(
				                SELECT ROW_NUMBER() OVER (ORDER BY phieumuon.maphieumuon) AS RowNumber, phieumuon.maphieumuon
				                FROM dbo.phieumuon)
			                SELECT Ordered.maphieumuon
			                FROM Ordered
			                WHERE RowNumber = (SELECT COUNT(phieumuon.maphieumuon) FROM phieumuon)";
                LastLoanID = (int)sqlCommand.ExecuteScalar();

                //Get last Detail ID value
                sqlCommand.CommandText = @"WITH Ordered AS(
					            SELECT ROW_NUMBER() OVER (ORDER BY chitietphieumuon.machitiet) AS RowNumber, chitietphieumuon.machitiet
					            FROM dbo.chitietphieumuon)
				            SELECT Ordered.machitiet
				            FROM Ordered
				            WHERE RowNumber = (SELECT COUNT(chitietphieumuon.machitiet) FROM dbo.chitietphieumuon)";
                LastDetailID = (int)sqlCommand.ExecuteScalar();
                validatebookID(sqlCommand);
                if (isChecked == 0)
                {
                    //Insert new loanpaper infomation to database
                    sqlCommand.CommandText = @"INSERT INTO dbo.phieumuon(maphieumuon,mathe,ngayhentra,ngaymuon,ngaytra)
				                            values ('" + (LastLoanID + 1) + "','" + CardIDtextBox.Text + "','" + PickAppointmentDate.Value.ToString("yyyy/MM/dd") + "',GETDATE(),NULL);";
                    sqlCommand.ExecuteNonQuery();

                    //Insert new detail loanpaper infomation to database (chitietphieumuon)
                    for (int i = 0; i < BookIDrichTextBox.Lines.Length; i++)
                    {
                        // Insert new detail loanpaper
                        sqlCommand.CommandText = @"INSERT INTO dbo.chitietphieumuon(machitiet,maphieumuon,masach)  
					                  values ('" + (++LastDetailID).ToString() + "', '" + (LastLoanID + 1).ToString() + "', '" + BookIDrichTextBox.Lines[i].ToString() + "')";
                        sqlCommand.ExecuteNonQuery();

                        // Increase count times of book
                        sqlCommand.CommandText = @"UPDATE dbo.sach SET sach.luotmuon = sach.luotmuon + 1 WHERE sach.masach = '" + BookIDrichTextBox.Lines[i].ToString() + "'";
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Tạo phiếu mượn thành công. Mã phiếu là : " + (LastLoanID + 1).ToString());
                    FillDataToGirdView(SearchQueryCmdFull);
                    InsertNewLoanBtn.Enabled = false;
                }
                else { MessageBox.Show("Chưa tạo được phiếu mượn!\n - Có mã sách đang được mượn chưa trả,\n hoặc mã sách không còn trong thư viện(đã xuất)" ); }
            }
        }


        // Search and update Loan information 

        private void filldatatolabel(int rownum)
        {
            IDStatuslabel.Text = LoanListTable.Rows[rownum].Cells[0].Value.ToString();
            SearchQueryCmdCheck = @"select * from dbo.phieumuon where phieumuon.maphieumuon = '" + IDStatuslabel.Text + "'";
            if (LoanListTable.Rows[rownum].Cells[4].Value.ToString() is "")
            {
                IsreturnedLoanBtn.Enabled = true;
                Statuslabel.Text = "Chưa trả";
                Statuslabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                IsreturnedLoanBtn.Enabled = false;
                Statuslabel.Text = "Đã trả";
                Statuslabel.ForeColor = System.Drawing.Color.Green;
            }
        }
        private void LoancheckBtn_Click(object sender, EventArgs e)
        {
            if (LoanIDtextbox.Text == "") MessageBox.Show("Vui lòng nhập mã phiếu!");
            else
            {
                SearchQueryCmdCheck = @"select * from dbo.phieumuon where phieumuon.maphieumuon = '" + LoanIDtextbox.Text + "'";
                SqlCommand CmdCheckAvailable = new SqlCommand(SearchQueryCmdCheck, conn);
                if (CmdCheckAvailable.ExecuteScalar() is null)
                    MessageBox.Show("Phiếu mượn " + LoanIDtextbox.Text + " không tồn tại!");
                else
                {
                    conn.Close();
                    conn.Open();
                    FillDataToGirdView(SearchQueryCmdCheck);
                    filldatatolabel(0);
                }
            }
        }
        private void LoanIDtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoancheckBtn_Click(sender, e);
            }
        }
        private void IsreturnedLoanBtn_Click(object sender, EventArgs e)
        {
            string InputBoxvaule = Interaction.InputBox("Bạn đọc đã vi phạm bao nhiêu lỗi ở lần mượn này?\nĐể giá trị 0 nếu không có lỗi vi phạm!", "Lỗi Vi Phạm", "0");
            int Inputvalue = int.Parse(InputBoxvaule);
            int Loanid = (int)LoanListTable.Rows[LoanListTable.CurrentRow.Index].Cells[0].Value;
            using(SqlCommand sql = new SqlCommand())
            {
                sql.Connection = conn;
                int result = 0;
                if(Inputvalue > 0)
                {
                    int CardID = (int)LoanListTable.Rows[LoanListTable.CurrentRow.Index].Cells[1].Value;
                    sql.CommandText = @"UPDATE dbo.bandoc SET bandoc.loi = bandoc.loi + "+ Inputvalue + @" FROM dbo.bandoc, dbo.thethuvien
				                        WHERE (bandoc.mabandoc = thethuvien.mabandoc AND thethuvien.mathe = '"+ CardID + "')";
                    result = sql.ExecuteNonQuery();
                }
                sql.CommandText = @"UPDATE dbo.phieumuon SET phieumuon.ngaytra = GETDATE()
			                    WHERE phieumuon.maphieumuon = '" + Loanid + "' AND phieumuon.ngaytra is NULL;";
                if((result + sql.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            filldatatolabel(0);
            RefreshBtn_Click(sender, e);
            


        }
        //  END: Search and update Loan information 
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FillDataToGirdView(SearchQueryCmdFull);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

