using QLNS_EntityFramework.Forms.About;
using QLNS_EntityFramework.Forms.HopDong;
using QLNS_EntityFramework.Forms.Luong;
using QLNS_EntityFramework.Forms.PhongBan;
using QLNS_EntityFramework.Forms.Report;
using QLNS_EntityFramework.Forms.ThoiViec;
using QLNS_EntityFramework.Forms.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_EntityFramework
{
    public partial class FormMain : Form
    {
        public FormMain(string Tendangnhap)
        {
            InitializeComponent();
            lableXinChao.Text = "Xin chào " + Tendangnhap + "!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelcountNhanvien.Text = CountRecords("NHANVIEN").ToString();
            labelCountPhongBan.Text = CountRecords("PHONGBAN").ToString();
            labelcountDuAn.Text = CountRecords("DUAN").ToString();
            string currentDate = DateTime.Today.ToString("D");

            // Set the label text to include the greeting and the current date
            label17.Text = "Xin chào ! Hôm nay là: " + currentDate;
            btnTimkiem.TabStop = false;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.TabStop = false;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;

            btnNhanVienMoi.TabStop = false;
            btnNhanVienMoi.FlatStyle = FlatStyle.Flat;
            btnNhanVienMoi.FlatAppearance.BorderSize = 0;

            btnThoiViec.TabStop = false;
            btnThoiViec.FlatStyle = FlatStyle.Flat;
            btnThoiViec.FlatAppearance.BorderSize = 0;


            btnGioithieu.TabStop = false;
            btnGioithieu.FlatStyle = FlatStyle.Flat;
            btnGioithieu.FlatAppearance.BorderSize = 0;
            btnHopDong.TabStop = false;
            btnHopDong.FlatStyle = FlatStyle.Flat;
            btnHopDong.FlatAppearance.BorderSize = 0;

            btnDuAnMoi.TabStop = false;
            btnDuAnMoi.FlatStyle = FlatStyle.Flat;
            btnDuAnMoi.FlatAppearance.BorderSize = 0;

            btnPhongBanMoi.TabStop = false;
            btnPhongBanMoi.FlatStyle = FlatStyle.Flat;
            btnPhongBanMoi.FlatAppearance.BorderSize = 0;

            btnThanhNhan.TabStop = false;
            btnThanhNhan.FlatStyle = FlatStyle.Flat;
            btnThanhNhan.FlatAppearance.BorderSize = 0;

            btnLuong.TabStop = false;
            btnLuong.FlatStyle = FlatStyle.Flat;
            btnLuong.FlatAppearance.BorderSize = 0;

            btnThongKe.TabStop = false;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.FlatAppearance.BorderSize = 0;

            btnTongQuan.TabStop = false;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.FlatAppearance.BorderSize = 0;
        }

        private int CountRecords(string tableName)
        {
            using (var dbContext = new QLNSEntities())
            {
                var count = dbContext.Database.SqlQuery<int>($"SELECT COUNT(*) FROM {tableName}").FirstOrDefault();

                return count;
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaiKhoan taikhoan = new FormTaiKhoan(lableXinChao.Text.ToString(), this);

            taikhoan.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            FormTimKiem timkiem = new FormTimKiem();

            timkiem.ShowDialog();
        }

        private void btnThanhNhan_Click(object sender, EventArgs e)
        {
            FormThanNhan thannhan = new FormThanNhan();
            thannhan.ShowDialog();
        }

        private void btnNhanVienMoi_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            formThemNhanVien.ShowDialog();
        }

        private void btnDuAnMoi_Click(object sender, EventArgs e)
        {
            FormThemDuAn formThemDuAn = new FormThemDuAn();
            formThemDuAn.ShowDialog();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            FormHopDong formHD = new FormHopDong();
            formHD.ShowDialog();
        }

        private void btnPhongBanMoi_Click(object sender, EventArgs e)
        {
            FormThemPhongBan formThemPB = new FormThemPhongBan();
            formThemPB.ShowDialog();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            FormLuong formLuong = new FormLuong();
            formLuong.ShowDialog();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            FormReportTongQuanNV formReportTQNV = new FormReportTongQuanNV(); 
            formReportTQNV.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe formTK = new FormThongKe();
            formTK.ShowDialog();
        }

        private void btnThoiViec_Click(object sender, EventArgs e)
        {
            FormThoiViec formThoiViec = new FormThoiViec();
            formThoiViec.ShowDialog();
        }

        private void btnGioithieu_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            FormDSNhanVien dsnhanvien = new FormDSNhanVien();
            dsnhanvien.ShowDialog();
        }
        private void btnDSDuAn_Click(object sender, EventArgs e)
        {
            FormDSDuAn dsduan = new FormDSDuAn();
            dsduan.ShowDialog();
        }

        private void btnDSPhongBan_Click(object sender, EventArgs e)
        {
            FormDSPhongBan dsPB = new FormDSPhongBan();
            dsPB.ShowDialog();
        }
    }
}
