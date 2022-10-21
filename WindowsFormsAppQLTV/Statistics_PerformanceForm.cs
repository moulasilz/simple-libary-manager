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
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace WindowsFormsAppQLTV
{
    public partial class Statistics_PerformanceForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=qlthuvien;Integrated Security=True;");
        int Countphieumuon;
        int Countphieuchuatra;
        int Countphieuchuatraquahan;
        int Countdatra;
        int Countdatraquahan;
        int Countluotsachmuon;
        int Countluotsachmuonquahan;
        string SearchQueryCmd;
        DataSet Books_ds = new DataSet();
        private int RowIndex;
        private bool IsAlltime = true;

        public Statistics_PerformanceForm()
        {
            
            InitializeComponent();
            dateFromPicker.Value = DateTime.Now;
            dateToPicker.Value = DateTime.Now;
        }
        private void PerformanceStatisticsForm_Load(object sender, EventArgs e)
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
            countdataAlltime();
            loadfullbook();
        }
        private void PerformanceStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { conn.Close(); }
            catch  { }
        }

        private void fillChart()
        {
            Chart.Series.Clear();
            Chart.Titles.Clear();
            Chart.Titles.Add("Thống kê phiếu mượn");
            Chart.Series.Add("Chưa trả").ChartType = SeriesChartType.Column;
            Chart.Series.Add("Chưa trả quá hạn").ChartType = SeriesChartType.Column;
            Chart.Series.Add("Đã trả đúng hạn").ChartType = SeriesChartType.Column;
            Chart.Series.Add("Đã trả quá hạn").ChartType = SeriesChartType.Column;

            Chart.Series["Chưa trả"].Points.AddXY("Chưa trả", Countphieuchuatra);
            Chart.Series["Chưa trả quá hạn"].Points.AddXY("Chưa trả quá hạn", Countphieuchuatraquahan);
            Chart.Series["Đã trả đúng hạn"].Points.AddXY("Đã trả đúng hạn", Countdatra);
            Chart.Series["Đã trả quá hạn"].Points.AddXY("Đã trả quá hạn", Countdatraquahan);
        }
        private void countdataAlltime()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                //tổng lượt mượn(phiếu mượn)        
                cmd.CommandText = "SELECT COUNT(*) FROM dbo.phieumuon;";
                Countphieumuon = (int)cmd.ExecuteScalar();

                //Tổng phiếu chưa trả
                cmd.CommandText = "SELECT COUNT(*) FROM dbo.phieumuon where(dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NULL); ";
                Countphieuchuatra = (int)cmd.ExecuteScalar();

                //Tổng phiếu chưa trả quá hạn
                cmd.CommandText = "SELECT COUNT(*) FROM dbo.phieumuon where(dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NULL);";
                Countphieuchuatraquahan = (int)cmd.ExecuteScalar();

                //Tổng phiếu đã trả
                cmd.CommandText = "SELECT COUNT(*) FROM dbo.phieumuon where(dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL); ";
                Countdatra = (int)cmd.ExecuteScalar();

                //Tổng phiếu đã trả quá hạn
                cmd.CommandText = "SELECT COUNT(*) FROM dbo.phieumuon where(dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL);";
                Countdatraquahan = (int)cmd.ExecuteScalar();

                //tổng lượt sách được mượn          
                cmd.CommandText = "SELECT COUNT(*) FROM dbo.chitietphieumuon;";
                Countluotsachmuon = (int)cmd.ExecuteScalar();

                //tổng lượt sách  mượn quá hạn
                cmd.CommandText = @"SELECT COUNT(chitietphieumuon.machitiet)
			                        FROM dbo.chitietphieumuon,dbo.phieumuon
			                        where (chitietphieumuon.maphieumuon = phieumuon.maphieumuon 
                                    AND (phieumuon.ngayhentra <= GETDATE() OR phieumuon.ngayhentra <= dbo.phieumuon.ngaytra))";
                Countluotsachmuonquahan = (int)cmd.ExecuteScalar();
            }
            Totalofloan.Text = Countphieumuon.ToString();
            Totalofbook.Text = Countluotsachmuon.ToString();
            Rateofoutdate.Text = ((float)Countluotsachmuonquahan / Countluotsachmuon).ToString("P", CultureInfo.InvariantCulture);

            fillChart();
        }
        private void countdataAlltimebydate()
        {
            using (var cmd = new SqlCommand())
            {
                string fromDATE = dateFromPicker.Value.Date.ToString("yyyy/MM/dd");
                string toDATE = dateToPicker.Value.Date.ToString("yyyy/MM/dd");
                cmd.Connection = conn;
                //tổng lượt mượn(phiếu mượn)        
                cmd.CommandText = @"SELECT COUNT(*) FROM dbo.phieumuon
		                            where (dbo.phieumuon.ngaymuon >= '" + fromDATE + "' AND dbo.phieumuon.ngaymuon <= '" + toDATE + @"');";
                Countphieumuon = (int)cmd.ExecuteScalar();

                //Tổng phiếu chưa trả
                cmd.CommandText = @"SELECT COUNT(*) FROM dbo.phieumuon
		                            where (dbo.phieumuon.ngaymuon >= '" + fromDATE + "' AND dbo.phieumuon.ngaymuon <= '" + toDATE + @"' 
		                            AND dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NULL);";
                Countphieuchuatra = (int)cmd.ExecuteScalar();

                //Tổng phiếu chưa trả quá hạn
                cmd.CommandText = @"SELECT COUNT(*) FROM dbo.phieumuon
                                    where(dbo.phieumuon.ngaymuon >= '" + fromDATE + "' AND dbo.phieumuon.ngaymuon <= '" + toDATE + @"'
                                    AND dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NULL); ";
                Countphieuchuatraquahan = (int)cmd.ExecuteScalar();

                //Tổng phiếu đã trả đúng hạn
                cmd.CommandText = @"SELECT COUNT(*) FROM dbo.phieumuon
		                            where (dbo.phieumuon.ngaymuon >= '" + fromDATE + "' AND dbo.phieumuon.ngaymuon <= '" + toDATE + @"' 
		                            AND dbo.phieumuon.ngayhentra >= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL);";
                Countdatra = (int)cmd.ExecuteScalar();

                //Tổng phiếu đã trả quá hạn
                cmd.CommandText = @"SELECT COUNT(*) FROM dbo.phieumuon
		                            where (dbo.phieumuon.ngaymuon >= '" + fromDATE + "' AND dbo.phieumuon.ngaymuon <= '" + toDATE + @"' 
		                            AND dbo.phieumuon.ngayhentra <= GETDATE() AND dbo.phieumuon.ngaytra is NOT NULL);";
                Countdatraquahan = (int)cmd.ExecuteScalar();

                //tổng lượt sách được mượn          
                cmd.CommandText = @"SELECT COUNT(*) FROM dbo.chitietphieumuon, dbo.phieumuon
		                            where (dbo.chitietphieumuon.maphieumuon = dbo.phieumuon.maphieumuon 
                                    AND dbo.phieumuon.ngaymuon >='" + fromDATE + "' AND dbo.phieumuon.ngaymuon <= '" + toDATE + @"');";
                Countluotsachmuon = (int)cmd.ExecuteScalar();

                //tổng lượt sách mượn quá hạn
                cmd.CommandText = @"Select COUNT(chitietphieumuon.machitiet) 
			                        from dbo.chitietphieumuon,dbo.phieumuon
			                        where(chitietphieumuon.maphieumuon = phieumuon.maphieumuon 
			                        AND dbo.phieumuon.ngaymuon >='"+ fromDATE + @"' AND dbo.phieumuon.ngaymuon <= '" + toDATE + @"'
			                        AND (phieumuon.ngayhentra <= GETDATE() OR phieumuon.ngayhentra <= dbo.phieumuon.ngaytra) )";
                Countluotsachmuonquahan = (int)cmd.ExecuteScalar();
            }
            Totalofloan.Text = Countphieumuon.ToString();
            Totalofbook.Text = Countluotsachmuon.ToString();
            Rateofoutdate.Text = ((float)Countluotsachmuonquahan / Countluotsachmuon).ToString("P", CultureInfo.InvariantCulture);
            fillChart();
        }
        private void AlltimeBtn_Click(object sender, EventArgs e)
        {
            IsAlltime=true; 
            countdataAlltime();
            
            
        }
        private void ThismonthBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateToPicker.Value = date;
            DateTime datefrom = date.AddDays(-(date.Day - 1));
            dateFromPicker.Value = datefrom;
            RequestDataBtn_Click(sender, e);

        }
        private void ThisweekBtn_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateToPicker.Value = date;
            DateTime datefrom = date.AddDays(-(( (int)date.DayOfWeek - 1) ));
            dateFromPicker.Value = datefrom;
            RequestDataBtn_Click(sender, e);
        }
        private void CustomBtn_Click(object sender, EventArgs e)
        {
            dateToPicker.Enabled = true;
            dateFromPicker.Enabled = true;
        }
        private void RequestDataBtn_Click(object sender, EventArgs e)
        {
            IsAlltime = false;
            countdataAlltimebydate();
        }

        // Đổ dữ liệu vào bảng datagridview
        private void FillDataToGirdView()
        {
            Books_ds.Reset();
            SqlCommand cmd = new SqlCommand(SearchQueryCmd, conn);
            SqlDataAdapter BooksDataAdaper = new SqlDataAdapter(cmd);
            BooksDataAdaper.Fill(Books_ds);
            tabledesign tabledesign = new tabledesign();
            tabledesign.renamecolofbookwithcount(Books_ds);
            BooksListTable.DataSource = Books_ds.Tables[0].DefaultView;
            tabledesign.changeformatofdatetimedatagrid(BooksListTable);
            tabledesign.autofillgirdviewcol(BooksListTable, Books_ds.Tables[0].Columns.Count);
        }

        private void loadfullbook()
        {
            SearchQueryCmd = @"Select CountTable.masach,dbo.sach.tensach, CountTable.Luotmuon
		                        from((
			                        SELECT  sach.masach, COUNT(chitietphieumuon.machitiet) as Luotmuon
				                        FROM  dbo.sach LEFT JOIN dbo.chitietphieumuon
				                        ON chitietphieumuon.masach = sach.masach
				                        GROUP BY (sach.masach)
			                        ) CountTable INNER JOIN dbo.sach ON CountTable.masach = dbo.sach.masach)";
            FillDataToGirdView();
        }
        private void loadbookbydate()
        {
            SearchQueryCmd = @"Select CountTable.masach,dbo.sach.tensach, CountTable.Luotmuon
		                    from((
			                    SELECT  sach.masach, COUNT(chitietphieumuon.machitiet) as Luotmuon
				                    FROM  dbo.sach LEFT JOIN dbo.chitietphieumuon
				                    ON chitietphieumuon.masach = sach.masach, dbo.phieumuon
				                    where (phieumuon.maphieumuon = chitietphieumuon.maphieumuon 
				                    AND phieumuon.ngaymuon >= '"+ dateFromPicker.Value.Date.ToString("yyyy/MM/dd") +@"' 
                                    AND phieumuon.ngaymuon <= '"+ dateToPicker.Value.Date.ToString("yyyy/MM/dd") +@"')
				                    GROUP BY (sach.masach)
			                    )CountTable INNER JOIN dbo.sach ON CountTable.masach = dbo.sach.masach)";
            FillDataToGirdView();
        }
        private void TotalofbookBtn_Click(object sender, EventArgs e)
        {
            if (IsAlltime)
            {
                loadfullbook();
            }
            else
            {
                loadbookbydate();
            }
            
        }
        // Lọc những sách được yêu thích (lượt mượn từ 5 trở lên)
        private void ToptotalBtn_Click(object sender, EventArgs e)
        {
            for (; RowIndex < BooksListTable.Rows.Count -1; RowIndex++)
            {
                if ((int)BooksListTable.Rows[RowIndex].Cells[2].Value < 5)
                {
                    BooksListTable.Rows.RemoveAt(RowIndex);
                    RowIndex--;
                }
            }
            RowIndex = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
