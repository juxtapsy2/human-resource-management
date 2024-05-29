using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS_EntityFramework.BS_Layer;
namespace QLNS_EntityFramework
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
            bool result = dangNhap.Login(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
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
                MessageBox.Show("Bạn đã đăng nhập thất bại");
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
            }
        }

        private void checkHide_CheckedChanged(object sender, EventArgs e)
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

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}
