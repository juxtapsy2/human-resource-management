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

namespace QLNS_ADO.NET.Forms.PhongBan
{
    public partial class FormThemPhongBan : Form
    {
        public FormThemPhongBan()
        {
            InitializeComponent();
        }

        private void FormThemPhongBan_Load(object sender, EventArgs e)
        {
           BL_NhanVien nhanVien = new BL_NhanVien();
           cmbTrPhong.DataSource = nhanVien.GetAllMaNV();
           dtpNgNhanChuc.Format = DateTimePickerFormat.Custom;
           dtpNgNhanChuc.CustomFormat = "dd/MM/yyyy";

        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            BL_PhongBan phongBan = new BL_PhongBan();
            string MaPB = txtMaPBM.Text;
            string TenPB =txtTenPBM.Text;
            string TrPhong = cmbTrPhong.Text;
            DateTime NgNhamChuc = dtpNgNhanChuc.Value;
            string Diadiem = txtDiaDiemM.Text;
          
            bool check = phongBan.ThemPhongBan(MaPB, TenPB, TrPhong, NgNhamChuc, Diadiem);

            if (check)
            {
               
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them that bai");
            }  
        }
    }
}
