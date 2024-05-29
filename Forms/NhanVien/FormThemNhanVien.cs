using QLNS_EntityFramework.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNS_EntityFramework
{
    public partial class FormThemNhanVien : Form
    {

        string strAvt = "";
        string txtFilePath = "";
        bool Excel = false;
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BL_NhanVien studentManager = new BL_NhanVien();
            string MaNV = txtMaNV.Text;
            string MaHD = cmbMaHD.Text;
            string HotenNV = txtHotenNV.Text;
            DateTime NgSinh = dtpNgSinh.Value;
            string Dchi = txtDchi.Text;
            string Phai = cmbPhai.Text;
            string MaNQL = cmbMaNQL.Text;
            string Phong = cmbPhong.Text;

            bool check = studentManager.ThemNhanVien(MaNV, MaHD, HotenNV, NgSinh, Dchi, Phai,  MaNQL, Phong, strAvt, Excel, txtFilePath);
            if (check)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image (*.png)|*.png|Image (*.jpeg, *.jpg)|*.jpeg, *.jpg|All files (*.*)|*.*",
                Title = "Chọn ảnh chân dung"
            };
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                strAvt = openFile.FileName;
                picChanDung.BackgroundImage = Image.FromStream(openFile.OpenFile());
            }
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {

            BL_NhanVien studentManager = new BL_NhanVien();
            BL_HopDong hopdong = new BL_HopDong();
            BL_PhongBan phongban = new BL_PhongBan();
            cmbMaNQL.DataSource = studentManager.GetAllMaNV();
            cmbMaHD.DataSource = hopdong.GetAllMaHD();
            cmbPhong.DataSource = phongban.GetAllMaPB();
            dtpNgSinh.Format = DateTimePickerFormat.Custom;
            dtpNgSinh.CustomFormat = "dd/MM/yyyy";
            cmbPhai.Items.Add("Nam");
            cmbPhai.Items.Add("Nữ");
            cmbPhai.SelectedIndex = 0;
        }
    }
}
