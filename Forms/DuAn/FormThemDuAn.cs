using QLNS_ADO.NET.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_ADO.NET
{
    public partial class FormThemDuAn : Form
    {
        bool Excel = false;
        public FormThemDuAn()
        {
            InitializeComponent();
        }

        private void btnThemDAMoi_Click(object sender, EventArgs e)
        {
            BL_DuAn projectManager = new BL_DuAn();
            string MaDAMoi = txtMaDAMoi.Text;
            string TenDAMoi = txtTenDAMoi.Text;
            string DiaDiemDAMoi = txtDiaDiemDAMoi.Text;
            string PhongDAMoi = cmbPhongDAMoi.Text;

            bool check = projectManager.ThemDuAn(MaDAMoi, TenDAMoi, DiaDiemDAMoi, PhongDAMoi);
            if (check)
            {
                MessageBox.Show("Thêm dự án thành công.");
            }
            else
            {
                MessageBox.Show("Thêm dự án thất bại!");
            }
        }

        private void FormThemDuAn_Load(object sender, EventArgs e)
        {
            BL_PhongBan phongBan = new BL_PhongBan();
            cmbPhongDAMoi.DataSource = phongBan.GetAllMaPB();
        }
    }
}
