using QLNS_EntityFramework.Forms.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_EntityFramework.Forms.Report
{
    public partial class FormReportTongQuanNV : Form
    {
        public FormReportTongQuanNV()
        {
            InitializeComponent();
        }

        private void FormReportTongQuanNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_QLNS.TONGQUANNV' table. You can move, or remove it, as needed.
            this.tONGQUANNVTableAdapter.Fill(this.dataSet_QLNS.TONGQUANNV);
            this.reportViewer1.RefreshReport();

        }

        private void btnFindTQMaNV_Click(object sender, EventArgs e)
        {
            this.tONGQUANNVTableAdapter.FillByMaNV(this.dataSet_QLNS.TONGQUANNV, txtTongQuanMaNV.Text);
            this.reportViewer1.RefreshReport();
        }

        private void btnBackTQNV_Click(object sender, EventArgs e)
        {
            this.tONGQUANNVTableAdapter.Fill(this.dataSet_QLNS.TONGQUANNV);
            this.reportViewer1.RefreshReport();
        }

        private void btnThongKeNhanLuc_Click(object sender, EventArgs e)
        {
            FormThongKeNhanLuc formTKNhanLuc = new FormThongKeNhanLuc();
            formTKNhanLuc.ShowDialog();
        }
    }
}
