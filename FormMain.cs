using QLNS_ADO.NET.DB_Layer;
using QLNS_ADO.NET.Forms.About;
using QLNS_ADO.NET.Forms.HopDong;
using QLNS_ADO.NET.Forms.PhongBan;
using QLNS_ADO.NET.Forms.ThoiViec;
using QLNS_ADO.NET.Forms.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLNS_ADO.NET
{
    public partial class FormMain : Form
    {
        public FormMain(string Tendangnhap)
        {
            InitializeComponent();
            lableXinChao.Text = "Xin chào " + Tendangnhap + "!";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelcountNhanvien.Text = CountRecords("NHANVIEN").ToString();
            labelCountPhongBan.Text = CountRecords("PHONGBAN").ToString();
            labelcountDuAn.Text = CountRecords("DUAN").ToString();
            // Get the current date and format it as a string
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

            btnPhongBan.TabStop = false;
            btnPhongBan.FlatStyle = FlatStyle.Flat;
            btnPhongBan.FlatAppearance.BorderSize = 0;

            btnThanhNhan.TabStop = false;
            btnThanhNhan.FlatStyle = FlatStyle.Flat;
            btnThanhNhan.FlatAppearance.BorderSize = 0;

            btnTinhLuong.TabStop = false;
            btnTinhLuong.FlatStyle = FlatStyle.Flat;
            btnTinhLuong.FlatAppearance.BorderSize = 0;

            btnThongKe.TabStop = false;
            btnThongKe.FlatStyle = FlatStyle.Flat;
           btnThongKe.FlatAppearance.BorderSize = 0;

            btnTongQuan.TabStop = false;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.FlatAppearance.BorderSize = 0;
        }

    
        private int CountRecords(string tableName)
        {
            string strSQL = $"SELECT COUNT(*) FROM {tableName}";
            SqlParameter[] parameters = null;
            CommandType ct = CommandType.Text;
            string error = string.Empty;
            int count = 0;

            DBMain db = new DBMain();

            DataSet ds = db.ExecuteQueryDataSet(strSQL, ct, parameters);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }


            return count;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaiKhoan taikhoan = new FormTaiKhoan(lableXinChao.Text.ToString(), this);

            taikhoan.ShowDialog();
       
        }
        private void btnNhanVienMoi_Click(object sender, EventArgs e)
        {
            FormThemNhanVien taikhoan = new FormThemNhanVien();

            taikhoan.ShowDialog();
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

        private void btnDuAnMoi_Click(object sender, EventArgs e)
        {
            FormThemDuAn formThemDuAn = new FormThemDuAn();
            formThemDuAn.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            FormTimKiem timkiem= new FormTimKiem();

            timkiem.ShowDialog();
        }

        private void btnThanhNhan_Click(object sender, EventArgs e)
        {
            FormThanNhan thannhan = new FormThanNhan();
            thannhan.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe formTK = new FormThongKe();
            formTK.ShowDialog();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            FormLuong formLuong = new FormLuong();
            formLuong.ShowDialog();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            FormReportTongQuanNV formReportTongQuanNV = new FormReportTongQuanNV();
            formReportTongQuanNV.ShowDialog();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            FormHopDong formHopDong = new FormHopDong();
            formHopDong.ShowDialog();
        }

        private void btnThoiViec_Click(object sender, EventArgs e)
        {
            FormThoiViec thoiViec = new FormThoiViec(); 
            thoiViec.ShowDialog();
        }

        private void btnGioithieu_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            FormThemPhongBan phongBan = new FormThemPhongBan();
            phongBan.ShowDialog();
        }

        private void btnDSPhongBan_Click(object sender, EventArgs e)
        {
            FormDSPhongBan phongBan = new FormDSPhongBan();
            phongBan.ShowDialog();
        }
    }
}
