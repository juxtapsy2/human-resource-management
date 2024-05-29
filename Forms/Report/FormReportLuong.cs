using QLNS_LinQ.Forms.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_LinQ.Forms
{
    public partial class FormReportLuong : Form
    {
        public FormReportLuong()
        {
            InitializeComponent();
        }

        private void FormReportLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_QLNS.LUONG' table. You can move, or remove it, as needed.
            this.lUONGTableAdapter.Fill(this.dataSet_QLNS.LUONG);
            // TODO: This line of code loads data into the 'dataSet_QLNS.LUONG' table. You can move, or remove it, as needed.
            this.lUONGTableAdapter.Fill(this.dataSet_QLNS.LUONG);
            this.reportViewer1.RefreshReport();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.lUONGTableAdapter.FillByMaNV(this.dataSet_QLNS.LUONG, this.txtMaNV.Text);
            this.reportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.lUONGTableAdapter.Fill(this.dataSet_QLNS.LUONG);
            this.reportViewer1.RefreshReport();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            FormThongKeLuong formThongKeLuong = new FormThongKeLuong();
            formThongKeLuong.ShowDialog();
        }
    }
}
