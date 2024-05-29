using System.Reflection.Emit;
using System.Windows.Forms;
using System;
namespace QLNS_ADO.NET
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTool1 = new System.Windows.Forms.Panel();
            this.panelTool2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThoiViec = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGioithieu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThanhNhan = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDuAnMoi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhanVienMoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lableXinChao = new System.Windows.Forms.Label();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDSPhongBan = new System.Windows.Forms.Button();
            this.btnDSDuAn = new System.Windows.Forms.Button();
            this.btnDSNhanVien = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCountPhongBan = new System.Windows.Forms.Label();
            this.labelcountDuAn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcountNhanvien = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelTool2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTool1
            // 
            this.panelTool1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTool1.BackColor = System.Drawing.Color.DarkGray;
            this.panelTool1.Location = new System.Drawing.Point(2, -1);
            this.panelTool1.Name = "panelTool1";
            this.panelTool1.Size = new System.Drawing.Size(1354, 32);
            this.panelTool1.TabIndex = 0;
            // 
            // panelTool2
            // 
            this.panelTool2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTool2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTool2.Controls.Add(this.tableLayoutPanel2);
            this.panelTool2.Controls.Add(this.tableLayoutPanel1);
            this.panelTool2.Location = new System.Drawing.Point(2, 29);
            this.panelTool2.Name = "panelTool2";
            this.panelTool2.Size = new System.Drawing.Size(1354, 205);
            this.panelTool2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel13, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 101);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label15);
            this.panel12.Controls.Add(this.btnThoiViec);
            this.panel12.Location = new System.Drawing.Point(4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(118, 93);
            this.panel12.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Thôi việc";
            // 
            // btnThoiViec
            // 
            this.btnThoiViec.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_thoiviec;
            this.btnThoiViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoiViec.Location = new System.Drawing.Point(22, 3);
            this.btnThoiViec.Name = "btnThoiViec";
            this.btnThoiViec.Size = new System.Drawing.Size(67, 68);
            this.btnThoiViec.TabIndex = 3;
            this.btnThoiViec.UseVisualStyleBackColor = true;
            this.btnThoiViec.Click += new System.EventHandler(this.btnThoiViec_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label16);
            this.panel13.Controls.Add(this.btnGioithieu);
            this.panel13.Location = new System.Drawing.Point(129, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(118, 93);
            this.panel13.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 18);
            this.label16.TabIndex = 13;
            this.label16.Text = "About";
            // 
            // btnGioithieu
            // 
            this.btnGioithieu.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_about;
            this.btnGioithieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGioithieu.Location = new System.Drawing.Point(22, 3);
            this.btnGioithieu.Name = "btnGioithieu";
            this.btnGioithieu.Size = new System.Drawing.Size(67, 68);
            this.btnGioithieu.TabIndex = 12;
            this.btnGioithieu.UseVisualStyleBackColor = true;
            this.btnGioithieu.Click += new System.EventHandler(this.btnGioithieu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.Controls.Add(this.panel11, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 9, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1347, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.btnTongQuan);
            this.panel11.Location = new System.Drawing.Point(1091, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(121, 92);
            this.panel11.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tổng quan";
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_tongquanNV;
            this.btnTongQuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTongQuan.Location = new System.Drawing.Point(26, 1);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(67, 68);
            this.btnTongQuan.TabIndex = 0;
            this.btnTongQuan.UseVisualStyleBackColor = true;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.btnTinhLuong);
            this.panel9.Location = new System.Drawing.Point(963, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(121, 92);
            this.panel9.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lương bổng";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_baocao;
            this.btnTinhLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinhLuong.Location = new System.Drawing.Point(26, 1);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(67, 68);
            this.btnTinhLuong.TabIndex = 0;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.btnThanhNhan);
            this.panel8.Location = new System.Drawing.Point(835, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(121, 92);
            this.panel8.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Thân nhân";
            // 
            // btnThanhNhan
            // 
            this.btnThanhNhan.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_thannhan;
            this.btnThanhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhNhan.Location = new System.Drawing.Point(26, 1);
            this.btnThanhNhan.Name = "btnThanhNhan";
            this.btnThanhNhan.Size = new System.Drawing.Size(67, 68);
            this.btnThanhNhan.TabIndex = 0;
            this.btnThanhNhan.UseVisualStyleBackColor = true;
            this.btnThanhNhan.Click += new System.EventHandler(this.btnThanhNhan_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.btnHopDong);
            this.panel7.Location = new System.Drawing.Point(707, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(121, 92);
            this.panel7.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hợp đồng";
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_hopdong;
            this.btnHopDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHopDong.Location = new System.Drawing.Point(26, 1);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(67, 68);
            this.btnHopDong.TabIndex = 0;
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.btnPhongBan);
            this.panel6.Location = new System.Drawing.Point(579, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 92);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phòng ban mới";
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_PhongBan;
            this.btnPhongBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhongBan.Location = new System.Drawing.Point(26, 1);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(67, 68);
            this.btnPhongBan.TabIndex = 0;
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnDuAnMoi);
            this.panel5.Location = new System.Drawing.Point(451, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 92);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dự án mới";
            // 
            // btnDuAnMoi
            // 
            this.btnDuAnMoi.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_duan;
            this.btnDuAnMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuAnMoi.Location = new System.Drawing.Point(26, 1);
            this.btnDuAnMoi.Name = "btnDuAnMoi";
            this.btnDuAnMoi.Size = new System.Drawing.Size(67, 68);
            this.btnDuAnMoi.TabIndex = 0;
            this.btnDuAnMoi.UseVisualStyleBackColor = true;
            this.btnDuAnMoi.Click += new System.EventHandler(this.btnDuAnMoi_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnNhanVienMoi);
            this.panel4.Location = new System.Drawing.Point(323, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 92);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên mới";
            // 
            // btnNhanVienMoi
            // 
            this.btnNhanVienMoi.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_nhanvien;
            this.btnNhanVienMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanVienMoi.Location = new System.Drawing.Point(26, 1);
            this.btnNhanVienMoi.Name = "btnNhanVienMoi";
            this.btnNhanVienMoi.Size = new System.Drawing.Size(67, 68);
            this.btnNhanVienMoi.TabIndex = 0;
            this.btnNhanVienMoi.UseVisualStyleBackColor = true;
            this.btnNhanVienMoi.Click += new System.EventHandler(this.btnNhanVienMoi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Location = new System.Drawing.Point(195, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 92);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_search;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Location = new System.Drawing.Point(26, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(67, 68);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lableXinChao);
            this.panel3.Controls.Add(this.btnTaiKhoan);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 92);
            this.panel3.TabIndex = 2;
            // 
            // lableXinChao
            // 
            this.lableXinChao.AutoSize = true;
            this.lableXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableXinChao.Location = new System.Drawing.Point(3, 70);
            this.lableXinChao.Name = "lableXinChao";
            this.lableXinChao.Size = new System.Drawing.Size(67, 15);
            this.lableXinChao.TabIndex = 4;
            this.lableXinChao.Text = "Xin chào ";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_taikhoan;
            this.btnTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaiKhoan.Location = new System.Drawing.Point(63, 1);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(67, 68);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.btnThongKe);
            this.panel10.Location = new System.Drawing.Point(1219, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(121, 92);
            this.panel10.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Thống kê";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.img_thongke;
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.Location = new System.Drawing.Point(26, 1);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(67, 68);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Window;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.label17);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Location = new System.Drawing.Point(2, 234);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1354, 567);
            this.panelMain.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(424, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 29);
            this.label17.TabIndex = 12;
            this.label17.Text = "label17";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(370, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(590, 81);
            this.label9.TabIndex = 11;
            this.label9.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 38);
            this.label7.TabIndex = 10;
            this.label7.Text = "TỔNG QUAN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDSPhongBan);
            this.panel1.Controls.Add(this.btnDSDuAn);
            this.panel1.Controls.Add(this.btnDSNhanVien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelCountPhongBan);
            this.panel1.Controls.Add(this.labelcountDuAn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelcountNhanvien);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(4, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 267);
            this.panel1.TabIndex = 9;
            // 
            // btnDSPhongBan
            // 
            this.btnDSPhongBan.BackColor = System.Drawing.Color.Red;
            this.btnDSPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSPhongBan.Location = new System.Drawing.Point(1002, 223);
            this.btnDSPhongBan.Name = "btnDSPhongBan";
            this.btnDSPhongBan.Size = new System.Drawing.Size(294, 32);
            this.btnDSPhongBan.TabIndex = 13;
            this.btnDSPhongBan.Text = "Xem danh sách phòng ban";
            this.btnDSPhongBan.UseVisualStyleBackColor = false;
            this.btnDSPhongBan.Click += new System.EventHandler(this.btnDSPhongBan_Click);
            // 
            // btnDSDuAn
            // 
            this.btnDSDuAn.BackColor = System.Drawing.Color.Lime;
            this.btnDSDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSDuAn.Location = new System.Drawing.Point(542, 223);
            this.btnDSDuAn.Name = "btnDSDuAn";
            this.btnDSDuAn.Size = new System.Drawing.Size(272, 32);
            this.btnDSDuAn.TabIndex = 12;
            this.btnDSDuAn.Text = "Xem danh sách dự án";
            this.btnDSDuAn.UseVisualStyleBackColor = false;
            this.btnDSDuAn.Click += new System.EventHandler(this.btnDSDuAn_Click);
            // 
            // btnDSNhanVien
            // 
            this.btnDSNhanVien.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDSNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNhanVien.Location = new System.Drawing.Point(50, 223);
            this.btnDSNhanVien.Name = "btnDSNhanVien";
            this.btnDSNhanVien.Size = new System.Drawing.Size(274, 32);
            this.btnDSNhanVien.TabIndex = 11;
            this.btnDSNhanVien.Text = "Xem danh sách nhân viên";
            this.btnDSNhanVien.UseVisualStyleBackColor = false;
            this.btnDSNhanVien.Click += new System.EventHandler(this.btnDSNhanVien_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(983, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dự án";
            // 
            // labelCountPhongBan
            // 
            this.labelCountPhongBan.AutoSize = true;
            this.labelCountPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.labelCountPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountPhongBan.Location = new System.Drawing.Point(980, 59);
            this.labelCountPhongBan.Name = "labelCountPhongBan";
            this.labelCountPhongBan.Size = new System.Drawing.Size(40, 42);
            this.labelCountPhongBan.TabIndex = 8;
            this.labelCountPhongBan.Text = "0";
            // 
            // labelcountDuAn
            // 
            this.labelcountDuAn.AutoSize = true;
            this.labelcountDuAn.BackColor = System.Drawing.Color.Transparent;
            this.labelcountDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountDuAn.Location = new System.Drawing.Point(515, 59);
            this.labelcountDuAn.Name = "labelcountDuAn";
            this.labelcountDuAn.Size = new System.Drawing.Size(40, 42);
            this.labelcountDuAn.TabIndex = 7;
            this.labelcountDuAn.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân vien";
            // 
            // labelcountNhanvien
            // 
            this.labelcountNhanvien.AutoSize = true;
            this.labelcountNhanvien.BackColor = System.Drawing.Color.White;
            this.labelcountNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcountNhanvien.Location = new System.Drawing.Point(43, 57);
            this.labelcountNhanvien.Name = "labelcountNhanvien";
            this.labelcountNhanvien.Size = new System.Drawing.Size(40, 42);
            this.labelcountNhanvien.TabIndex = 1;
            this.labelcountNhanvien.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.bg_nhanvien;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 212);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.bg_duan;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(497, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 212);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.bg_phongban;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(968, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(349, 212);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 794);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTool2);
            this.Controls.Add(this.panelTool1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1372, 841);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTool2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTool1;
        private Panel panelTool2;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Button btnDSPhongBan;
        private Button btnDSDuAn;
        private Button btnDSNhanVien;
        public System.Windows.Forms.Label labelcountNhanvien;
        public System.Windows.Forms.Label labelCountPhongBan;
        public System.Windows.Forms.Label labelcountDuAn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private System.Windows.Forms.Label label8;
        private Button btnTimkiem;
        private Panel panel3;
        private System.Windows.Forms.Label lableXinChao;
        private Button btnTaiKhoan;
        private System.Windows.Forms.Label label9;
        private Panel panel4;
        private System.Windows.Forms.Label label1;
        private Button btnNhanVienMoi;
        private Panel panel5;
        private System.Windows.Forms.Label label3;
        private Button btnDuAnMoi;
        private Panel panel7;
        private System.Windows.Forms.Label label10;
        private Button btnHopDong;
        private Panel panel6;
        private System.Windows.Forms.Label label4;
        private Button btnPhongBan;
        private Panel panel11;
        private System.Windows.Forms.Label label14;
        private Button btnTongQuan;
        private Panel panel10;
        private System.Windows.Forms.Label label13;
        private Button btnThongKe;
        private Panel panel9;
        private System.Windows.Forms.Label label12;
        private Button btnTinhLuong;
        private Panel panel8;
        private System.Windows.Forms.Label label11;
        private Button btnThanhNhan;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel12;
        private Button btnThoiViec;
        private System.Windows.Forms.Label label15;
        private Panel panel13;
        private System.Windows.Forms.Label label16;
        private Button btnGioithieu;
        private System.Windows.Forms.Label label17;
    }
}

