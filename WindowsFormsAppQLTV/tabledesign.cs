using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsAppQLTV
{
    internal class tabledesign
    {
        private void renamecol(DataSet ds, string[] nameofcol)
        {
            if(ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    ds.Tables[0].Columns[i].ColumnName = nameofcol[i];
                }
            }
            
        }
        public void renamecolofbook(DataSet ds)
        {
            string[] nameofcol = { "Mã sách", "Tên sách", "Tên tác giả", "Tình trạng sách", "Lượt mượn", "Ngày nhập", "Ngày xuất" };
            renamecol(ds, nameofcol);
        }
        public void renamecolofbookwithcount(DataSet ds)
        {
            string[] nameofcol = { "Mã sách", "Tên sách", "Lượt mượn"};
            renamecol(ds, nameofcol);
        }
        public void renamecolofreader(DataSet ds)
        {
            string[] nameofcol = { "Mã bạn đọc", "Tên", "SĐT", "Địa Chỉ", "Ngày Sinh", "Lượt vi phạm", "Mã thẻ", "Ngày cấp", "Hạn thẻ" };
            renamecol(ds, nameofcol);
        }
        public void renameofloan(DataSet ds)
        {
            string[] nameofcol = { "Mã phiếu mượn", "Mã thẻ", "Ngày hẹn trả", "Ngày mượn", "Ngày trả" };
            renamecol(ds, nameofcol);
        }
        public void renameofdetailedloan(DataSet ds)
        {
            string[] nameofcol = { "Mã sách", "Tên sách" };
            renamecol(ds, nameofcol);
        }

        public void changeformatofdatetimedatagrid(DataGridView ListTable)
        {
            for (int i = 0; i <ListTable.Columns.Count; i++)
            {
                if (ListTable.Columns[i].ValueType.IsAssignableFrom(typeof(DateTime)))
                {
                    ListTable.Columns[i].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
        }

        public void autofillgirdviewcol(DataGridView dataGridView, int count)
        {
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

    }
}
