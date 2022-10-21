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
    public partial class Statistics_BookForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True;");
        public Statistics_BookForm()
        {
            InitializeComponent();
        }
        private void BookStatisticsForm_Load(object sender, EventArgs e)
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

        private void BookStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch  { }
        }

        private void FillDataToGirdView(string SearchQueryCmd, DataSet Books_ds)
        {
            SqlCommand cmd = new SqlCommand(SearchQueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(Books_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renamecolofbook(Books_ds);
            BooksListTable.DataSource = Books_ds.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(BooksListTable);
            tabledesign.autofillgirdviewcol(BooksListTable, Books_ds.Tables[0].Columns.Count);
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataSet Books_ds = new DataSet();
            string SearchQueryCmd;
            if (comboBox.Text == "Đầu sách đang được mượn")
            {
                SearchQueryCmd = @"Select dbo.sach.masach, dbo.sach.tensach, dbo.sach.tentacgia, dbo.sach.tinhtrangsach, dbo.sach.luotmuon, dbo.sach.ngaynhap, dbo.sach.ngayxuat 
                                   from dbo.sach, dbo.chitietphieumuon, dbo.phieumuon 
                                   where(dbo.sach.masach = dbo.chitietphieumuon.masach and dbo.chitietphieumuon.maphieumuon = dbo.phieumuon.maphieumuon and dbo.phieumuon.ngaytra is NULL);";
                FillDataToGirdView(SearchQueryCmd, Books_ds);
            }
            else if (comboBox.Text == "Tất cả đầu sách")
            {
                SearchQueryCmd = "SELECT * From dbo.sach";
                FillDataToGirdView(SearchQueryCmd, Books_ds);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}