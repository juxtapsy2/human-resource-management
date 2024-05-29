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
    public partial class FormTaiKhoan : Form
    {
        private FormMain form1;
        public FormTaiKhoan(string Tentaikhoan, FormMain form1)
        {
            InitializeComponent();
            labelName.Text = Tentaikhoan;
            this.form1 = form1;
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            BL_TaiKhoan passwordChanger = new BL_TaiKhoan();
            string username = txtTenDangNhap.Text;
            string newPassword = txtNewPass.Text;
            string oldPassword = textOldPass.Text;
            string error = string.Empty;
            bool success = passwordChanger.ChangePassword(username, oldPassword, newPassword);

            if (success)
            {
                MessageBox.Show("Password changed successfully!");
                textOldPass.Clear();
                txtNewPass.Clear();
                txtTenDangNhap.Clear();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please check your credentials.");
                textOldPass.Clear();
                txtNewPass.Clear();
                txtTenDangNhap.Clear();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.form1.Close();
        }
    }
}
