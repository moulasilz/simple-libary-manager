using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQLTV
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            panelSubMenuStatistics.Visible = false;
        }

// Change color of function button when deactive childform
        private void ChangeColorDeactivated()
        {
            this.ReaderManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.PerformanceStatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.BorrowGiveStatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.ReaderStatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.ImportExportStatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.BookStatisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.statisticsManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.BookManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.BorrowGiveManagerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
        }

// Change color of function button when active childform
        private void ChangeColorActivated(Button btn)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }    
        
// Open Children Form inside panelMainContainer

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Add(childForm);
            panelMainContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

// CHỨC NĂNG QUẢN LÝ BẠN ĐỌC

        private void ReaderManagerBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(ReaderManagerBtn);
            panelSubMenuStatistics.Visible = false;
            openChildFormInPanel(new Manager_ReaderForm());
        }

// CHỨC NĂNG MƯỢN, TRẢ SÁCH

        private void BorrowGiveManagerBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(BorrowGiveManagerBtn);
            panelSubMenuStatistics.Visible = false;
            openChildFormInPanel(new Manager_BorrowForm());
        }

// CHỨC NĂNG QUẢN LÝ SÁCH

        private void BookManagerBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(BookManagerBtn);
            panelSubMenuStatistics.Visible = false;
            openChildFormInPanel(new Manager_BookForm());

        }

// CHỨC NĂNG THỐNG KÊ , BÁO CÁO

        // Click To Show and Hide Sub Menu Function
        private void statisticsManagerBtn_Click(object sender, EventArgs e)
        {
            panelSubMenuStatistics.Visible = true;
        }

        // Open: Thống kê đầu sách
        private void BookStatisticsBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(BookStatisticsBtn);
            openChildFormInPanel(new Statistics_BookForm());
        }
        // Open: Thống kê nhập, xuất sách
        private void ImportExportStatisticsBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(ImportExportStatisticsBtn);
            openChildFormInPanel(new Statistics_ImportExportForm());
        }
        // Open: Thống kê bạn đọc
        private void ReaderStatisticsBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(ReaderStatisticsBtn);
            openChildFormInPanel(new Statistics_ReaderForm());
        }
        // Open: Thống kê mượn trả
        private void BorrowGiveStatisticsBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(BorrowGiveStatisticsBtn);
            openChildFormInPanel(new Statistics_BorrowGiveForm());
            
        }
        // Open: Thống kê hiệu quả chung
        private void PerformanceStatisticsBtn_Click(object sender, EventArgs e)
        {
            ChangeColorDeactivated();
            ChangeColorActivated(PerformanceStatisticsBtn);
            openChildFormInPanel(new Statistics_PerformanceForm());
        }

// Form Closing Conditional
        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult test;
            test = MessageBox.Show("bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (test == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        
    }
}
