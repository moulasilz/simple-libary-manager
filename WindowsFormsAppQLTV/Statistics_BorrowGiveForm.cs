using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppQLTV
{
    public partial class Statistics_BorrowGiveForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True;");
        string SearchQueryCmd;
        DataSet Loan_ds = new DataSet();
        public Statistics_BorrowGiveForm()
        {
            InitializeComponent();
            dateFromPicker.Value = DateTime.Now;
            dateToPicker.Value = DateTime.Now;
        
        }
        private void BorrowGiveStatisticsForm_Load(object sender, EventArgs e)
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
            comboBox.SelectedIndex = 0;
        }
        private void BorrowGiveStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch { }
        }
        private void FillDataToGirdView(string QueryCmd, DataSet Loan_ds)
        {
            Loan_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(Loan_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renameofloan(Loan_ds);
            LoanListTable.DataSource = Loan_ds.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(LoanListTable);
            tabledesign.autofillgirdviewcol(LoanListTable, Loan_ds.Tables[0].Columns.Count);
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionalDatePanel.Visible = false;
            switch (comboBox.SelectedIndex)
            {
                // Thống kê tất cả phiếu mượn
                case 0:
                    SearchQueryCmd = @"Select * from dbo.phieumuon;";
                    FillDataToGirdView(SearchQueryCmd, Loan_ds);
                    break;

                // Thống kê phiếu mượn trong tháng
                case 1:
                    SearchQueryCmd = @"Select * from dbo.phieumuon
		                            where (MONTH(dbo.phieumuon.ngaymuon) = MONTH(GETDATE()) 
			                        AND YEAR(dbo.phieumuon.ngaymuon) = YEAR(GETDATE()));";
                    FillDataToGirdView(SearchQueryCmd, Loan_ds);

                    break;

                // Thống kê phiếu mượn theo ngày tuỳ chọn
                case 2:
                    OptionalDatePanel.Visible = true;
                    break;

                // Thống kê phiếu mượn đã trả trong tháng
                case 3:
                    SearchQueryCmd = @"Select * from dbo.phieumuon 
		                                where (MONTH(dbo.phieumuon.ngaytra) = MONTH(GETDATE()) 
			                            AND YEAR(dbo.phieumuon.ngaytra) = YEAR(GETDATE()));";
                    FillDataToGirdView(SearchQueryCmd, Loan_ds);

                    break;
                // Thống kê phiếu mượn đã trả theo ngày tuỳ chọn
                case 4:
                    OptionalDatePanel.Visible = true;

                    break;
                // Thống kê phiếu mượn chưa trả
                case 5:
                    SearchQueryCmd = @"Select * from dbo.phieumuon 
		                               where (dbo.phieumuon.ngaytra is NULL);";
                    FillDataToGirdView(SearchQueryCmd, Loan_ds);

                    break;

            }
        }

        private void optionaldateBtn_Click(object sender, EventArgs e)
        {
            
            if (comboBox.Text == "Thống kê phiếu mượn theo ngày tuỳ chọn")
            {
                SearchQueryCmd = @"Select * from dbo.phieumuon 
		        where (dbo.phieumuon.ngaymuon >='"+ dateFromPicker.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.phieumuon.ngaymuon <= '"+ dateToPicker.Value.Date.ToString("yyyy/MM/dd") + "');";
                FillDataToGirdView(SearchQueryCmd, Loan_ds);

            }
            else if(comboBox.Text == "Thống kê phiếu mượn đã trả theo ngày tuỳ chọn")
            {
                SearchQueryCmd = @"Select * from dbo.phieumuon 
		        where (dbo.phieumuon.ngaytra >='" + dateFromPicker.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.phieumuon.ngaytra <= '" + dateToPicker.Value.Date.ToString("yyyy/MM/dd") + "');";
                FillDataToGirdView(SearchQueryCmd, Loan_ds);
            }
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

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
