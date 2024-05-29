using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_EntityFramework.Forms.ThongKe
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKeLuong_Click(object sender, EventArgs e)
        {
            FormThongKeLuong formTKLuong = new FormThongKeLuong();
            formTKLuong.ShowDialog();
        }

        private void btnThongKeNhanLuc_Click(object sender, EventArgs e)
        {
            FormThongKeNhanLuc formTKNhanLuc = new FormThongKeNhanLuc();
            formTKNhanLuc.ShowDialog();
        }
    }
}
