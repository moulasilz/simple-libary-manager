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

namespace WindowsFormsAppQLTV
{
    public partial class Manager_BookForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True;");
        const string SearchQueryCmdFull = @"SELECT * FROM dbo.sach ;";
        string SearchQueryCmd;
        DataSet Books_ds = new DataSet();
        public Manager_BookForm()
        {
            InitializeComponent();
            BookImportdate.Value = DateTime.Now;
        }
        
        private void Manager_BookForm_Load(object sender, EventArgs e)
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
            FillDataToGirdView(SearchQueryCmdFull, Books_ds);
        }
        private void Manager_BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch {}
            
        }
        // Chỉ nhập được ký tự số vào ô mã sách
        private void BookIDtextbox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void FillDataToGirdView(string QueryCmd, DataSet Books_ds)
        {
            Books_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(Books_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renamecolofbook(Books_ds);
            BooksListTable.DataSource = Books_ds.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(BooksListTable);
            tabledesign.autofillgirdviewcol(BooksListTable, Books_ds.Tables[0].Columns.Count);
            BookIDtextbox.ReadOnly = true;
            IsExportedBtn.Enabled = false;
        }
        private bool IsExist(string keyword)
        {
            SqlCommand CmdCheck = new SqlCommand(@"SELECT * FROM dbo.sach WHERE sach.masach ='" + keyword + "'", conn);
            if(CmdCheck.ExecuteScalar() is null) { return false; }
            return true;
        }
        // THÊM MỚI SÁCH VÀ CẬP NHẬT SÁCH TRONG THƯ VIỆN 
        private void ConfirmAndCallMethod(string QueryCmd,string methodname, string caption)
        {
            var message = new List<string>();
            message.Add("Thông tin sách:");
            message.Add(" - Mã sách: " + BookIDtextbox.Text);
            message.Add(" - Tên sách: " + BookNametexbox.Text);
            message.Add(" - Tên tác giả " + BookAuthorTextbox.Text);
            message.Add(" - Tình trạng: " + BookConditiontextbox.Text);
            message.Add(" - Ngày nhập sách: " + BookImportdate.Text);
            // Convert to array and show list
            var result = MessageBox.Show(string.Join(Environment.NewLine, message.ToArray()), caption,
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand SQLMethod = new SqlCommand(QueryCmd, conn);
                    int run = SQLMethod.ExecuteNonQuery();
                    if(run > 0)
                    {
                        MessageBox.Show(methodname + " thành công!");
                        FillDataToGirdView(SearchQueryCmdFull, Books_ds);
                    }
                    else { MessageBox.Show(methodname + " không thành công!"); }
                    
                }
                catch
                {
                    MessageBox.Show(methodname +" không thành công!");
                }
            }
        }
        // Lắng nghe sự kiện : Sự kiện click button thêm 
        private void AddbookBtn_Click(object sender, EventArgs e)
        {
            if (IsExist(BookIDtextbox.Text) is false)
            {
                BookImportdate.Value = DateTime.Now;
                SearchQueryCmd = @"INSERT INTO dbo.sach values ('" + BookIDtextbox.Text + "', N'" + BookNametexbox.Text.Trim() + "', N'" + BookAuthorTextbox.Text.Trim() + "', N'" + BookConditiontextbox.Text.Trim() + "', '0', GETDATE(), NULL)";
                ConfirmAndCallMethod(SearchQueryCmd, "Thêm", "Thêm mới!");
            }
            else { MessageBox.Show("Mã sách " + BookIDtextbox.Text + " đã tồn tại!"); }
            
        }
        // Lắng nghe sự kiện : Sự kiện click button sửa 
        private void EditbookBtn_Click(object sender, EventArgs e)
        {
            if(IsExist(BookIDtextbox.Text) )
            {
                SearchQueryCmd = @"UPDATE dbo.sach SET tensach =N'" + BookNametexbox.Text.Trim() + "', tentacgia =N'" + BookAuthorTextbox.Text.Trim() + "', tinhtrangsach = N'" + BookConditiontextbox.Text.Trim() + "' WHERE sach.masach = '" + BookIDtextbox.Text + "'";
                ConfirmAndCallMethod(SearchQueryCmd, "Sửa", "Sửa đổi thông tin!");
            }
            else { MessageBox.Show("Mã sách " + BookIDtextbox.Text + " không tồn tại!"); }

        }

// TÌM KIẾM SÁCH 

        // Kiểm tra sách có đang được mượn hay không
        private bool IsUnReturned()
        {
            SearchQueryCmd = @"SELECT COUNT(chitietphieumuon.masach) FROM  dbo.chitietphieumuon, dbo.phieumuon
			WHERE (chitietphieumuon.masach = '" + BookIDtextbox.Text + "' AND chitietphieumuon.maphieumuon = phieumuon.maphieumuon AND phieumuon.ngaytra is NULL)";
            SqlCommand sqlcheck = new SqlCommand(SearchQueryCmd, conn);
            if ((int)sqlcheck.ExecuteScalar() == 0)
            {
                return false;
            }
            return true;
        }
        // Làm trống dữ liệu trong textbox và label
        private void cleartexboxlabel()
        {
            BookIDtextbox.Text = "";
            BookNametexbox.Text = "";
            BookAuthorTextbox.Text = "";
            BookConditiontextbox.Text = "";
            Countlabel.Text = "";
            BookImportdate.Value = DateTime.Now;
            Exportdatelabel.Text = "";
            Statuslabel.Text = "";
        }
        // đổ dữ liệu của một đối tượng sách cụ thể 
        private void Fillspecific(int RowNum)
        {
            BookIDtextbox.ReadOnly = true;
            if ((BooksListTable.Rows[RowNum].Cells[0].Value.ToString() is "") is false)
            {
                BookIDtextbox.Text = BooksListTable.Rows[RowNum].Cells[0].Value.ToString();
                BookNametexbox.Text = BooksListTable.Rows[RowNum].Cells[1].Value.ToString();
                BookAuthorTextbox.Text = BooksListTable.Rows[RowNum].Cells[2].Value.ToString();
                BookConditiontextbox.Text = BooksListTable.Rows[RowNum].Cells[3].Value.ToString();
                Countlabel.Text = BooksListTable.Rows[RowNum].Cells[4].Value.ToString();
                BookImportdate.Value = DateTime.Parse(BooksListTable.Rows[RowNum].Cells[5].Value.ToString());
                if (BooksListTable.Rows[RowNum].Cells[6].Value.ToString() is "")
                {

                    Exportdatelabel.Text = "Chưa xuất";
                    Exportdatelabel.ForeColor = Color.Blue;
                    IsExportedBtn.Enabled = true;
                }
                else
                {
                    Exportdatelabel.Text = DateTime.Parse(BooksListTable.Rows[RowNum].Cells[6].Value.ToString()).ToString("dd/MM/yyyy");
                    Exportdatelabel.ForeColor = Color.Red;
                    IsExportedBtn.Enabled = false;
                }
                if (IsUnReturned())
                {
                    Statuslabel.Text = "Đang mượn.";
                    Statuslabel.ForeColor = Color.Blue;

                }
                else
                {
                    Statuslabel.Text = "Chưa mượn.";
                    Statuslabel.ForeColor = Color.Green;
                }
            }
            else { cleartexboxlabel(); }
        }
        // Lắng nghe sự kiện : 1. click vào nút tìm kiếm sách.  2. Enter tại textbox tìm kiếm
        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBtn_Click(sender, e);
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = SearchTextbox.Text.Trim();
            bool IsNumber = int.TryParse(keyword, out int number);
            if (IsNumber)
            {
                SearchQueryCmd = @"SELECT * FROM dbo.sach WHERE sach.masach ='" + keyword + "'";
                FillDataToGirdView(SearchQueryCmd, Books_ds);
                if (IsExist(keyword)) { Fillspecific(0); }
                else {MessageBox.Show("Mã sách " + SearchTextbox.Text + " không tồn tại!"); }
            }
            else
            {
               if(keyword != "")
                {
                    SearchQueryCmd = @"SELECT * FROM dbo.sach WHERE sach.tensach like N'%" + keyword + "%'";
                    FillDataToGirdView(SearchQueryCmd, Books_ds);
                }
                else { MessageBox.Show("Vui lòng nhập dữ liệu tìm kiếm!");}
            }
        }

        // ĐÁNH DẤU SÁCH ĐÃ XUẤT KHỎI THƯ VIỆN 
        private void IsExportedBtn_Click(object sender, EventArgs e)
        {
            if(IsUnReturned()){
                MessageBox.Show("Không thể đánh dấu đã xuất!\n - Sách đang được mượn."); 
            }
            else
            {
                SearchQueryCmd = @"UPDATE dbo.sach SET sach.ngayxuat=GETDATE()
			                   WHERE sach.masach ='" + BookIDtextbox.Text + "' AND sach.ngayxuat is NULL;";
                SqlCommand sqlCommand = new SqlCommand(SearchQueryCmd, conn);
                try
                {
                    int result = sqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        int RowIndex = BooksListTable.CurrentRow.Index;
                        FillDataToGirdView(SearchQueryCmdFull, Books_ds);
                        Fillspecific(RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            
        }
        // LÀM MỚI FORM
        
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            cleartexboxlabel();
            FillDataToGirdView(SearchQueryCmdFull, Books_ds);

        }
        // Lắng nghe sự kiện: click vào vào ô cụ thể trên datagridview
        private void BooksListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fillspecific(BooksListTable.CurrentRow.Index);
        }
        // Lắng nghe sự kiện : Click textbox mã sách để nhập mã sách 
        private void BookIDtextbox_Click(object sender, EventArgs e)
        {
            if(BookIDtextbox.ReadOnly == true)
            {
                DialogResult result = MessageBox.Show("Bạn muốn mở nhập mã sách?(chỉ nên mở khi nhập mới)", "Mở chỉnh sửa mã sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BookIDtextbox.ReadOnly = false;
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
