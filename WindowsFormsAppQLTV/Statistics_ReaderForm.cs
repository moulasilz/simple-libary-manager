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
    public partial class Statistics_ReaderForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True;");
        string SearchQueryCmd;
        DataSet Reader_ds = new DataSet();
        public Statistics_ReaderForm()
        {
            InitializeComponent();
            dateFromPicker.Value = DateTime.Now;
            dateToPicker.Value = DateTime.Now;
        }

        private void ReaderStatisticsForm_Load(object sender, EventArgs e)
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

        private void ReaderStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch { }
        }

        private void FillDataToGirdView(string SearchQueryCmd, DataSet Reader_ds)
        {
            Reader_ds.Reset();
            SqlCommand cmd = new SqlCommand(SearchQueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(Reader_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renamecolofreader(Reader_ds);
            ReaderListTable.DataSource = Reader_ds.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(ReaderListTable);
            tabledesign.autofillgirdviewcol(ReaderListTable, Reader_ds.Tables[0].Columns.Count);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionalDatePanel.Visible = false;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    Reader_ds.Reset();
                    SearchQueryCmd = @"SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe
		                                from (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc) ;";
                    FillDataToGirdView(SearchQueryCmd, Reader_ds);
                    break;
                case 1:
                    Reader_ds.Reset();
                    SearchQueryCmd = @"SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe
		                                from (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc)
		                                where (thethuvien.hanthe < GETDATE()) ;";
                    FillDataToGirdView(SearchQueryCmd, Reader_ds);
                    break;
                case 2:
                    Reader_ds.Reset();
                    SearchQueryCmd = @"SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe
		                                from (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc)
		                                where (MONTH(thethuvien.ngaycap) = MONTH(GETDATE()) 
			                            AND YEAR(thethuvien.ngaycap) = YEAR(GETDATE()));";
                    FillDataToGirdView(SearchQueryCmd, Reader_ds);
                    break;
                case 3:
                    OptionalDatePanel.Visible = true;
                    break;
            }
        }

        private void optionaldateBtn_Click(object sender, EventArgs e)
        {
            SearchQueryCmd = @"SELECT bandoc.mabandoc, bandoc.ten, bandoc.sdt, bandoc.diachi, bandoc.ngaysinh, bandoc.loi, thethuvien.mathe, thethuvien.ngaycap, thethuvien.hanthe
		                     from (dbo.bandoc  INNER JOIN dbo.thethuvien ON bandoc.mabandoc=thethuvien.mabandoc)
		                     where (thethuvien.ngaycap >= '" + dateFromPicker.Value.ToString("yyyy/MM/dd") + "' and thethuvien.ngaycap <= '" + dateToPicker.Value.ToString("yyyy/MM/dd") + "') ;";
            FillDataToGirdView(SearchQueryCmd, Reader_ds);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}