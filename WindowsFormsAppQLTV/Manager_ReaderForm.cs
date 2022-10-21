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
    public partial class Manager_ReaderForm : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True");
        DataSet Reader_ds = new DataSet();
        string SearchQueryCmd;
        int ReaderID;
        int CardID;
        public Manager_ReaderForm()
        {
            InitializeComponent();
        }
        // không cho phép nhập ký tự, chỉ chấp nhận nhập số
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void FillDataToGirdView(string QueryCmd, DataSet Dataset)
        {
            Dataset.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(Dataset);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renamecolofreader(Dataset);
            ReaderListTable.DataSource = Dataset.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(ReaderListTable);
            tabledesign.autofillgirdviewcol(ReaderListTable, Dataset.Tables[0].Columns.Count);
        }
        private void ReaderManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                try {
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
            ResetInfoBtn_Click(sender, e); 
        }
        private void Manager_ReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch  { }
        }

        //THÊM BẠN ĐỌC MỚI VÀ TẠO THẺ
        private DialogResult ConfirmInfomation(int ReaderID, int CardID, string caption)
        {
            var message = new List<string>();
            message.Add("Thông tin bạn đọc:");
            message.Add(" - Mã bạn đọc: " + ReaderID);
            message.Add(" - Tên bạn đọc: " + txttenbandoc.Text);
            message.Add(" - Địa chỉ: " + txtdiachi.Text);
            message.Add(" - Số điện thoại: " + txtsdt.Text);
            message.Add(" - Ngày sinh: " + dt_ngaysinh.Text);
            message.Add(" - Mã thẻ thư viện: " + CardID);
            message.Add(" - Ngày cấp thẻ: " + dt_ngaycap.Text);
            message.Add(" - Ngày hết hạn thẻ: " + dt_ngayhethan.Text);
            // Convert to array and show error list
            var result = MessageBox.Show(string.Join(Environment.NewLine, message.ToArray()), caption,
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return result;
        }
        private void bt_them__Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(txtmabandoc.Text, out int TryInt))
            {
                MessageBox.Show("Vui lòng khởi tạo trước khi thêm mới!");
                return;
            }
            if (txttenbandoc.Text == "" || txtsdt.Text == "" || txtdiachi.Text =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            using (var SqlCommandRunner = new SqlCommand())
            {
                SqlCommandRunner.Connection = conn;

                SqlCommandRunner.CommandText = @"SELECT COUNT(*) FROM dbo.bandoc Where bandoc.sdt = '"+txtsdt.Text+"'";
                if((int)SqlCommandRunner.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Số điện thoại "+txtsdt.Text+" đã tồn tại!");
                }
                else
                {
                    // lấy mã bạn đọc của bạn đọc cuối cùng
                    SqlCommandRunner.CommandText = @"WITH Ordered AS( SELECT ROW_NUMBER() OVER (ORDER BY bandoc.mabandoc) AS RowNumber, bandoc.mabandoc FROM dbo.bandoc)
			                                    SELECT Ordered.mabandoc FROM Ordered
			                                    WHERE RowNumber = (SELECT COUNT(bandoc.mabandoc) FROM bandoc)";
                    ReaderID = (int)SqlCommandRunner.ExecuteScalar();

                    // Lấy mã thẻ thư viện cuối cùng
                    SqlCommandRunner.CommandText = @"WITH Ordered AS( SELECT ROW_NUMBER() OVER (ORDER BY thethuvien.mathe) AS RowNumber, thethuvien.mathe FROM dbo.thethuvien)
			                                    SELECT Ordered.mathe FROM Ordered
			                                    WHERE RowNumber = (SELECT COUNT(thethuvien.mathe) FROM dbo.thethuvien)";
                    CardID = (int)SqlCommandRunner.ExecuteScalar();
                    if (ConfirmInfomation(++ReaderID, ++CardID,"Thêm mới bạn đọc. Ok để thêm mới!") == DialogResult.No)
                    {
                        MessageBox.Show("Bạn đã huỷ thêm mới!");
                    }
                    else
                    {
                        try
                        {
                            // Tiến hành thêm bạn đọc mới
                            SqlCommandRunner.CommandText = @"INSERT INTO dbo.bandoc values('" + ReaderID.ToString() + "', N'" + txttenbandoc.Text.Trim() + "','" + txtsdt.Text + "', N'" + txtdiachi.Text.Trim() + "','" + dt_ngaysinh.Value.ToString("yyyy/MM/dd") + "','0')";
                            SqlCommandRunner.ExecuteNonQuery();
                            //Thêm dữ liệu vào thẻ thư viện(tạo thẻ mới cho bạn đọc mới)
                            SqlCommandRunner.CommandText = "INSERT INTO dbo.thethuvien values('" + CardID.ToString() + "','" + ReaderID.ToString() + "',GETDATE(),'" + dt_ngayhethan.Value.ToString("yyyy/MM/dd") + "')";
                            int kq = SqlCommandRunner.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Bạn đã thêm thành công vào CSDL!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                searchTodisplayMethod(CardID.ToString());
                                DisplayInfoToTextbox();
                            }
                            else
                            {
                                MessageBox.Show("Bạn chưa thêm thành công vào CSDL!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                SqlCommandRunner.CommandText = @"Delete from dbo.bandoc where bandoc.mabandoc ='" + ReaderID.ToString() + "'";
                                SqlCommandRunner.ExecuteNonQuery();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa thêm thành công vào CSDL!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    }
                }
                
            }
        }
        //SỬA THÔNG TIN BẠN ĐỌC  VÀ THAY ĐỔI HẠN THẺ
        private void ChangeInfoBtn_Click(object sender, EventArgs e)
        {
            if (txttenbandoc.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            ReaderID = Int32.Parse(txtmabandoc.Text);
            CardID = Int32.Parse(txtmathe.Text);
            if (ConfirmInfomation(ReaderID, CardID, "Thay đổi thông tin. Ok để thay đổi!") == DialogResult.No)
            {
                MessageBox.Show("Bạn đã huỷ thay đổi!");
            }
            else
            {
                using (var SqlCommandRunner = new SqlCommand())
                {
                    SqlCommandRunner.Connection = conn;

                    SqlCommandRunner.CommandText = @"SELECT COUNT(*) FROM dbo.bandoc Where bandoc.sdt = '" + txtsdt.Text + "'";
                    if ((int)SqlCommandRunner.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Số điện thoại " + txtsdt.Text + " đã tồn tại!");
                    }
                    else
                    {
                        try
                        {
                            // Tiến hành thay đổi thông tin bạn đọc

                            SqlCommandRunner.CommandText = @"UPDATE dbo.bandoc SET ten = N'" + txttenbandoc.Text.Trim() + "', sdt = '" + txtsdt.Text + "', diachi = N'" + txtdiachi.Text.Trim() + "', ngaysinh ='" + dt_ngaysinh.Value.ToString("yyyy/MM/dd") + "' WHERE mabandoc = '" + txtmabandoc.Text + "';";
                            SqlCommandRunner.ExecuteNonQuery();

                            // Gia hạn thẻ(tiến hành thay đổi ngày hạn thẻ)
                            SqlCommandRunner.CommandText = "UPDATE dbo.thethuvien SET hanthe = '" + dt_ngayhethan.Value.ToString("yyyy/MM/dd") + "' WHERE mathe = '" + txtmathe.Text + "';";
                            int kq = SqlCommandRunner.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                MessageBox.Show("Bạn đã sửa thông tin bạn đọc " + txtmabandoc.Text + " thành công!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                searchTodisplayMethod(CardID.ToString());
                                DisplayInfoToTextbox();
                            }
                            else
                            {
                                MessageBox.Show("Bạn chưa sửa thông tin bạn đọc " + txtmabandoc.Text + " thành công!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch 
                        {
                            MessageBox.Show("Bạn chưa sửa thông tin bạn đọc " + txtmabandoc.Text + " thành công!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }

                }
                
            }

        }
        
        //Hiển thị thông tin trên textbox

        private void DisplayInfoToTextbox()
        {
            txtmabandoc.Text = ReaderListTable.CurrentRow.Cells[0].Value.ToString();
            txttenbandoc.Text = ReaderListTable.CurrentRow.Cells[1].Value.ToString();
            txtsdt.Text = ReaderListTable.CurrentRow.Cells[2].Value.ToString();
            txtdiachi.Text = ReaderListTable.CurrentRow.Cells[3].Value.ToString();
            dt_ngaysinh.Text = ReaderListTable.CurrentRow.Cells[4].Value.ToString();
            txtmathe.Text = ReaderListTable.CurrentRow.Cells[6].Value.ToString();
            dt_ngaycap.Text = ReaderListTable.CurrentRow.Cells[7].Value.ToString();
            dt_ngayhethan.Text = ReaderListTable.CurrentRow.Cells[8].Value.ToString();
        }
        private void ReaderListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayInfoToTextbox();
        }

        //Khởi tạo
        private void ResetInfoBtn_Click(object sender, EventArgs e)
        {
                txtmabandoc.Text = "tự động cấp khi thêm mới";
                txttenbandoc.Text = "";
                txtsdt.Text = "";
                txtdiachi.Text = "";
                txtmathe.Text = "tự động cấp khi thêm mới";
                dt_ngaysinh.Value = DateTime.Now;
                dt_ngaycap.Value = DateTime.Now;
                dt_ngayhethan.Value = DateTime.Now;
            SearchQueryCmd = @"SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe  
			        FROM (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) ;";
            FillDataToGirdView(SearchQueryCmd, Reader_ds);
        }

        //tìm kiếm bằng tên, hoặc mã thẻ, hoặc số điện thoại
        private void searchTodisplayMethod(string keyword)
        {
            bool isNumber = int.TryParse(keyword, out int numericValue);
            if (isNumber)
            {
                SearchQueryCmd = @"select bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe 
			    from (dbo.bandoc INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) 
			    where( thethuvien.mathe = '" + keyword + "'OR bandoc.sdt = '" + keyword + "')";
                FillDataToGirdView(SearchQueryCmd, Reader_ds);
            }
            else
            {
                SearchQueryCmd = @"select bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe 
			    from (dbo.bandoc INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) 
			    where bandoc.ten like N'%" + keyword + "%'";
                FillDataToGirdView(SearchQueryCmd, Reader_ds);
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            searchTodisplayMethod((txtkeyword.Text).Trim());
        }

        private void txtkeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBtn_Click(sender, e);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
