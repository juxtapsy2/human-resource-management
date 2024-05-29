using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS_LinQ.BS_Layer;
namespace QLNS_LinQ
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

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textOldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
