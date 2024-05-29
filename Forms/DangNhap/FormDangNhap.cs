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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BL_TaiKhoan dangNhap = new BL_TaiKhoan();
            bool result = dangNhap.Login(txtTenDangNhap.Text.Trim(),txtMatKhau.Text.Trim());
            if (result)
            {
                FormMain main = new FormMain(txtTenDangNhap.Text.Trim());
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                this.Hide();
                main.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công ! Vui lòng nhập lại");
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void checkHide_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkHide.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
