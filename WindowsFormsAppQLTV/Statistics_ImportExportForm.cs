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
    public partial class Statistics_ImportExportForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True;");
        string SearchQueryCmd;
        public Statistics_ImportExportForm()
        {
            InitializeComponent();
            dateFromPicker.Value = DateTime.Now;
            dateToPicker.Value = DateTime.Now;
        }
        private void ImportExportStatisticsForm_Load(object sender, EventArgs e)
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
            comboBox.SelectedIndex= 0;
            ThismonthBtn_Click(sender, e);
            this.ActiveControl = ThismonthBtn;
        }
        private void ImportExportStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch  { }
        }
        
        
        private void FillDataToGirdView(string QueryCmd)
        {
            DataSet Books_ds = new DataSet();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(Books_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renamecolofbook(Books_ds);
            BooksListTable.DataSource = Books_ds.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(BooksListTable);
            tabledesign.autofillgirdviewcol(BooksListTable, Books_ds.Tables[0].Columns.Count);
        }
        private void OptionCheckandFilldata()
        {
            
            if (comboBox.Text == "những sách đã nhập về")
            {
                SearchQueryCmd = @"Select* from dbo.sach where(dbo.sach.ngaynhap >= '"+ dateFromPicker.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.sach.ngaynhap <= '" + dateToPicker.Value.Date.ToString("yyyy/MM/dd") + "');";
                FillDataToGirdView(SearchQueryCmd);
            }
            else if (comboBox.Text == "những sách đã xuất khỏi thư viện")
            {
                SearchQueryCmd = @"Select* from dbo.sach where(dbo.sach.ngayxuat >= '" + dateFromPicker.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.sach.ngayxuat <= '" + dateToPicker.Value.Date.ToString("yyyy/MM/dd") + "');";
                FillDataToGirdView(SearchQueryCmd);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lựa chọn thống kê!");
            }
        }
        private void ThismonthBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateToPicker.Text = date.ToString();
            DateTime datefrom = date.AddDays(-(date.Day - 1));
            dateFromPicker.Text = datefrom.ToString();
            OptionCheckandFilldata();
        }

        private void optionaldateBtn_Click(object sender, EventArgs e)
        {
            OptionCheckandFilldata();
        }

        private void ThisyearBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateToPicker.Text = date.ToString();
            DateTime datefrom = date.AddDays(-(date.Day - 1)).AddMonths(-(date.Month - 1));
            dateFromPicker.Text = datefrom.ToString();
            OptionCheckandFilldata();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
