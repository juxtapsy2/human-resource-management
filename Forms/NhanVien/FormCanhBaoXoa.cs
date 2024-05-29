﻿using QLNS_ADO.NET.BS_Layer;
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
    public partial class FormCanhBaoXoa : Form
    {
        private FormDSNhanVien ds;
        private string MaNV;
        private string MaHD;
        public FormCanhBaoXoa(string MaNV, string MaHD)
        {
            InitializeComponent();
            ds = (FormDSNhanVien)Application.OpenForms["FormDSNhanVien"];
            this.MaHD = MaHD;
            this.MaNV = MaNV;
            lblCanhBao.Text = "+ Khi xóa nhân viên thì xem như nhân viên đã thôi việc." +
                " \n+ Toàn bộ thông tin của nhân viên (Dự án, Lương, Thân nhân,...) cũng sẽ bị xóa." +
                "\n+ Nhân viên sẽ được thêm vào danh sách thôi việc.";
                 
                
        }

        private void FormCanhBaoXoa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            BL_ThoiViec thoiViec = new BL_ThoiViec();
            BL_NhanVien nhanVien = new BL_NhanVien();
            if (nhanVien.XoaNhanVien(MaNV))
            {
                if (thoiViec.ThemThoiViec(MaNV, MaHD, DateTime.Now, txtLyDoThoiViec.Text))
                {
                    MessageBox.Show("Đã xóa và thêm nhân viên vào bảng Thôi việc thành công !");
                    this.Close();
                }
                ds.LoadData();
            }
            else
            {
                MessageBox.Show("Bị lỗi !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
