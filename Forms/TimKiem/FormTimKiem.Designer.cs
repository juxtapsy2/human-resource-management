namespace QLNS_ADO.NET
{
    partial class FormTimKiem
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.checkBoxDA = new System.Windows.Forms.CheckBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.checkBoxPB = new System.Windows.Forms.CheckBox();
            this.checkBoxNV = new System.Windows.Forms.CheckBox();
            this.labelNHANVIEN = new System.Windows.Forms.Label();
            this.labelPhongNV = new System.Windows.Forms.Label();
            this.labelMaNQL = new System.Windows.Forms.Label();
            this.labelPhai = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelHoTenNV = new System.Windows.Forms.Label();
            this.labelMaHDNV = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.picChanDung = new System.Windows.Forms.PictureBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.cmbPhong = new System.Windows.Forms.TextBox();
            this.txtMaNQL = new System.Windows.Forms.TextBox();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.txtDchi = new System.Windows.Forms.TextBox();
            this.txtHotenNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.labelPHONGBAN = new System.Windows.Forms.Label();
            this.labelMaPB = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.labelTenPB = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.labelTrP = new System.Windows.Forms.Label();
            this.txtTrP = new System.Windows.Forms.TextBox();
            this.labelNgNhanChuc = new System.Windows.Forms.Label();
            this.dtpNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.labelDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.labelDUAN = new System.Windows.Forms.Label();
            this.labelMaDA = new System.Windows.Forms.Label();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.labelTenDA = new System.Windows.Forms.Label();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.labelDiaDiemDA = new System.Windows.Forms.Label();
            this.txtDiaDiemDA = new System.Windows.Forms.TextBox();
            this.labelPhongDA = new System.Windows.Forms.Label();
            this.txtPhongDA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 375);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1268, 463);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.checkBoxDA);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.checkBoxPB);
            this.panel1.Controls.Add(this.checkBoxNV);
            this.panel1.Location = new System.Drawing.Point(53, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 154);
            this.panel1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(58, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 22);
            this.label14.TabIndex = 50;
            this.label14.Text = "Tìm theo:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(149, 99);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(106, 33);
            this.comboBoxType.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(877, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(143, 42);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // checkBoxDA
            // 
            this.checkBoxDA.AutoSize = true;
            this.checkBoxDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDA.Location = new System.Drawing.Point(702, 60);
            this.checkBoxDA.Name = "checkBoxDA";
            this.checkBoxDA.Size = new System.Drawing.Size(83, 24);
            this.checkBoxDA.TabIndex = 2;
            this.checkBoxDA.Text = "Dự Án";
            this.checkBoxDA.UseVisualStyleBackColor = true;
            this.checkBoxDA.CheckedChanged += new System.EventHandler(this.checkBoxDA_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(261, 90);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(594, 42);
            this.txtInput.TabIndex = 2;
            // 
            // checkBoxPB
            // 
            this.checkBoxPB.AutoSize = true;
            this.checkBoxPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPB.Location = new System.Drawing.Point(505, 60);
            this.checkBoxPB.Name = "checkBoxPB";
            this.checkBoxPB.Size = new System.Drawing.Size(122, 24);
            this.checkBoxPB.TabIndex = 1;
            this.checkBoxPB.Text = "Phòng Ban";
            this.checkBoxPB.UseVisualStyleBackColor = true;
            this.checkBoxPB.CheckedChanged += new System.EventHandler(this.checkBoxPB_CheckedChanged);
            // 
            // checkBoxNV
            // 
            this.checkBoxNV.AutoSize = true;
            this.checkBoxNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNV.Location = new System.Drawing.Point(351, 60);
            this.checkBoxNV.Name = "checkBoxNV";
            this.checkBoxNV.Size = new System.Drawing.Size(117, 24);
            this.checkBoxNV.TabIndex = 0;
            this.checkBoxNV.Text = "Nhân Viên";
            this.checkBoxNV.UseVisualStyleBackColor = true;
            this.checkBoxNV.CheckedChanged += new System.EventHandler(this.checkBoxNV_CheckedChanged);
            // 
            // labelNHANVIEN
            // 
            this.labelNHANVIEN.AutoSize = true;
            this.labelNHANVIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNHANVIEN.Location = new System.Drawing.Point(423, 9);
            this.labelNHANVIEN.Name = "labelNHANVIEN";
            this.labelNHANVIEN.Size = new System.Drawing.Size(321, 38);
            this.labelNHANVIEN.TabIndex = 46;
            this.labelNHANVIEN.Text = "Thông tin nhân viên";
            this.labelNHANVIEN.Visible = false;
            // 
            // labelPhongNV
            // 
            this.labelPhongNV.AutoSize = true;
            this.labelPhongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhongNV.Location = new System.Drawing.Point(681, 113);
            this.labelPhongNV.Name = "labelPhongNV";
            this.labelPhongNV.Size = new System.Drawing.Size(74, 25);
            this.labelPhongNV.TabIndex = 45;
            this.labelPhongNV.Text = "Phòng";
            this.labelPhongNV.Visible = false;
            // 
            // labelMaNQL
            // 
            this.labelMaNQL.AutoSize = true;
            this.labelMaNQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNQL.Location = new System.Drawing.Point(681, 78);
            this.labelMaNQL.Name = "labelMaNQL";
            this.labelMaNQL.Size = new System.Drawing.Size(86, 25);
            this.labelMaNQL.TabIndex = 44;
            this.labelMaNQL.Text = "MaNQL";
            this.labelMaNQL.Visible = false;
            // 
            // labelPhai
            // 
            this.labelPhai.AutoSize = true;
            this.labelPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhai.Location = new System.Drawing.Point(360, 160);
            this.labelPhai.Name = "labelPhai";
            this.labelPhai.Size = new System.Drawing.Size(55, 25);
            this.labelPhai.TabIndex = 42;
            this.labelPhai.Text = "Phái";
            this.labelPhai.Visible = false;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.Location = new System.Drawing.Point(360, 113);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(78, 25);
            this.labelDiaChi.TabIndex = 41;
            this.labelDiaChi.Text = "Địa chỉ";
            this.labelDiaChi.Visible = false;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(360, 67);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(108, 25);
            this.labelNgaySinh.TabIndex = 40;
            this.labelNgaySinh.Text = "Ngày sinh";
            this.labelNgaySinh.Visible = false;
            // 
            // labelHoTenNV
            // 
            this.labelHoTenNV.AutoSize = true;
            this.labelHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTenNV.Location = new System.Drawing.Point(59, 165);
            this.labelHoTenNV.Name = "labelHoTenNV";
            this.labelHoTenNV.Size = new System.Drawing.Size(83, 25);
            this.labelHoTenNV.TabIndex = 39;
            this.labelHoTenNV.Text = "Họ Tên";
            this.labelHoTenNV.Visible = false;
            // 
            // labelMaHDNV
            // 
            this.labelMaHDNV.AutoSize = true;
            this.labelMaHDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaHDNV.Location = new System.Drawing.Point(65, 113);
            this.labelMaHDNV.Name = "labelMaHDNV";
            this.labelMaHDNV.Size = new System.Drawing.Size(78, 25);
            this.labelMaHDNV.TabIndex = 38;
            this.labelMaHDNV.Text = "Mã HD";
            this.labelMaHDNV.Visible = false;
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.Location = new System.Drawing.Point(64, 62);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(78, 25);
            this.labelMaNV.TabIndex = 37;
            this.labelMaNV.Text = "Mã NV";
            this.labelMaNV.Visible = false;
            // 
            // picChanDung
            // 
            this.picChanDung.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.H0;
            this.picChanDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChanDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picChanDung.Location = new System.Drawing.Point(1076, 12);
            this.picChanDung.Name = "picChanDung";
            this.picChanDung.Size = new System.Drawing.Size(182, 251);
            this.picChanDung.TabIndex = 35;
            this.picChanDung.TabStop = false;
            this.picChanDung.Visible = false;
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Enabled = false;
            this.dtpNgSinh.Location = new System.Drawing.Point(475, 70);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgSinh.TabIndex = 34;
            this.dtpNgSinh.Visible = false;
            // 
            // cmbPhong
            // 
            this.cmbPhong.Enabled = false;
            this.cmbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhong.Location = new System.Drawing.Point(773, 114);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(205, 30);
            this.cmbPhong.TabIndex = 33;
            this.cmbPhong.Visible = false;
            // 
            // txtMaNQL
            // 
            this.txtMaNQL.Enabled = false;
            this.txtMaNQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNQL.Location = new System.Drawing.Point(773, 78);
            this.txtMaNQL.Name = "txtMaNQL";
            this.txtMaNQL.Size = new System.Drawing.Size(205, 30);
            this.txtMaNQL.TabIndex = 32;
            this.txtMaNQL.Visible = false;
            // 
            // txtPhai
            // 
            this.txtPhai.Enabled = false;
            this.txtPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhai.Location = new System.Drawing.Point(470, 162);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(205, 30);
            this.txtPhai.TabIndex = 30;
            this.txtPhai.Visible = false;
            // 
            // txtDchi
            // 
            this.txtDchi.Enabled = false;
            this.txtDchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDchi.Location = new System.Drawing.Point(470, 103);
            this.txtDchi.Name = "txtDchi";
            this.txtDchi.Size = new System.Drawing.Size(205, 30);
            this.txtDchi.TabIndex = 29;
            this.txtDchi.Visible = false;
            // 
            // txtHotenNV
            // 
            this.txtHotenNV.Enabled = false;
            this.txtHotenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotenNV.Location = new System.Drawing.Point(149, 160);
            this.txtHotenNV.Name = "txtHotenNV";
            this.txtHotenNV.Size = new System.Drawing.Size(205, 30);
            this.txtHotenNV.TabIndex = 28;
            this.txtHotenNV.Visible = false;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(149, 108);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(205, 30);
            this.txtMaHD.TabIndex = 27;
            this.txtMaHD.Visible = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(149, 62);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(205, 30);
            this.txtMaNV.TabIndex = 26;
            this.txtMaNV.Visible = false;
            // 
            // labelPHONGBAN
            // 
            this.labelPHONGBAN.AutoSize = true;
            this.labelPHONGBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPHONGBAN.Location = new System.Drawing.Point(411, 9);
            this.labelPHONGBAN.Name = "labelPHONGBAN";
            this.labelPHONGBAN.Size = new System.Drawing.Size(333, 38);
            this.labelPHONGBAN.TabIndex = 47;
            this.labelPHONGBAN.Text = "Thông tin phòng ban";
            this.labelPHONGBAN.Visible = false;
            // 
            // labelMaPB
            // 
            this.labelMaPB.AutoSize = true;
            this.labelMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaPB.Location = new System.Drawing.Point(64, 66);
            this.labelMaPB.Name = "labelMaPB";
            this.labelMaPB.Size = new System.Drawing.Size(76, 25);
            this.labelMaPB.TabIndex = 48;
            this.labelMaPB.Text = "Mã PB";
            this.labelMaPB.Visible = false;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Enabled = false;
            this.txtMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPB.Location = new System.Drawing.Point(149, 64);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(205, 30);
            this.txtMaPB.TabIndex = 49;
            this.txtMaPB.Visible = false;
            // 
            // labelTenPB
            // 
            this.labelTenPB.AutoSize = true;
            this.labelTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPB.Location = new System.Drawing.Point(62, 111);
            this.labelTenPB.Name = "labelTenPB";
            this.labelTenPB.Size = new System.Drawing.Size(84, 25);
            this.labelTenPB.TabIndex = 50;
            this.labelTenPB.Text = "Tên PB";
            this.labelTenPB.Visible = false;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Enabled = false;
            this.txtTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPB.Location = new System.Drawing.Point(149, 108);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(205, 30);
            this.txtTenPB.TabIndex = 51;
            this.txtTenPB.Visible = false;
            // 
            // labelTrP
            // 
            this.labelTrP.AutoSize = true;
            this.labelTrP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrP.Location = new System.Drawing.Point(-7, 160);
            this.labelTrP.Name = "labelTrP";
            this.labelTrP.Size = new System.Drawing.Size(149, 25);
            this.labelTrP.TabIndex = 51;
            this.labelTrP.Text = "Trưởng Phòng";
            this.labelTrP.Visible = false;
            // 
            // txtTrP
            // 
            this.txtTrP.Enabled = false;
            this.txtTrP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrP.Location = new System.Drawing.Point(148, 160);
            this.txtTrP.Name = "txtTrP";
            this.txtTrP.Size = new System.Drawing.Size(205, 30);
            this.txtTrP.TabIndex = 51;
            this.txtTrP.Visible = false;
            // 
            // labelNgNhanChuc
            // 
            this.labelNgNhanChuc.AutoSize = true;
            this.labelNgNhanChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgNhanChuc.Location = new System.Drawing.Point(360, 69);
            this.labelNgNhanChuc.Name = "labelNgNhanChuc";
            this.labelNgNhanChuc.Size = new System.Drawing.Size(168, 25);
            this.labelNgNhanChuc.TabIndex = 52;
            this.labelNgNhanChuc.Text = "Ngày nhân chức";
            this.labelNgNhanChuc.Visible = false;
            // 
            // dtpNgayNhanChuc
            // 
            this.dtpNgayNhanChuc.Enabled = false;
            this.dtpNgayNhanChuc.Location = new System.Drawing.Point(539, 72);
            this.dtpNgayNhanChuc.Name = "dtpNgayNhanChuc";
            this.dtpNgayNhanChuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayNhanChuc.TabIndex = 53;
            this.dtpNgayNhanChuc.Visible = false;
            // 
            // labelDiaDiem
            // 
            this.labelDiaDiem.AutoSize = true;
            this.labelDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaDiem.Location = new System.Drawing.Point(364, 113);
            this.labelDiaDiem.Name = "labelDiaDiem";
            this.labelDiaDiem.Size = new System.Drawing.Size(96, 25);
            this.labelDiaDiem.TabIndex = 54;
            this.labelDiaDiem.Text = "Địa điểm";
            this.labelDiaDiem.Visible = false;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Enabled = false;
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(539, 106);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(205, 30);
            this.txtDiaDiem.TabIndex = 55;
            this.txtDiaDiem.Visible = false;
            // 
            // labelDUAN
            // 
            this.labelDUAN.AutoSize = true;
            this.labelDUAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDUAN.Location = new System.Drawing.Point(411, 9);
            this.labelDUAN.Name = "labelDUAN";
            this.labelDUAN.Size = new System.Drawing.Size(257, 38);
            this.labelDUAN.TabIndex = 56;
            this.labelDUAN.Text = "Thông tin dự án";
            this.labelDUAN.Visible = false;
            // 
            // labelMaDA
            // 
            this.labelMaDA.AutoSize = true;
            this.labelMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaDA.Location = new System.Drawing.Point(59, 67);
            this.labelMaDA.Name = "labelMaDA";
            this.labelMaDA.Size = new System.Drawing.Size(78, 25);
            this.labelMaDA.TabIndex = 57;
            this.labelMaDA.Text = "Mã DA";
            this.labelMaDA.Visible = false;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Enabled = false;
            this.txtMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDA.Location = new System.Drawing.Point(149, 62);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(205, 30);
            this.txtMaDA.TabIndex = 58;
            this.txtMaDA.Visible = false;
            // 
            // labelTenDA
            // 
            this.labelTenDA.AutoSize = true;
            this.labelTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenDA.Location = new System.Drawing.Point(56, 111);
            this.labelTenDA.Name = "labelTenDA";
            this.labelTenDA.Size = new System.Drawing.Size(84, 25);
            this.labelTenDA.TabIndex = 59;
            this.labelTenDA.Text = "Tên PB";
            this.labelTenDA.Visible = false;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Enabled = false;
            this.txtTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDA.Location = new System.Drawing.Point(149, 108);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(205, 30);
            this.txtTenDA.TabIndex = 52;
            this.txtTenDA.Visible = false;
            // 
            // labelDiaDiemDA
            // 
            this.labelDiaDiemDA.AutoSize = true;
            this.labelDiaDiemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaDiemDA.Location = new System.Drawing.Point(41, 163);
            this.labelDiaDiemDA.Name = "labelDiaDiemDA";
            this.labelDiaDiemDA.Size = new System.Drawing.Size(96, 25);
            this.labelDiaDiemDA.TabIndex = 60;
            this.labelDiaDiemDA.Text = "Địa điểm";
            this.labelDiaDiemDA.Visible = false;
            // 
            // txtDiaDiemDA
            // 
            this.txtDiaDiemDA.Enabled = false;
            this.txtDiaDiemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiemDA.Location = new System.Drawing.Point(148, 159);
            this.txtDiaDiemDA.Name = "txtDiaDiemDA";
            this.txtDiaDiemDA.Size = new System.Drawing.Size(205, 30);
            this.txtDiaDiemDA.TabIndex = 52;
            this.txtDiaDiemDA.Visible = false;
            // 
            // labelPhongDA
            // 
            this.labelPhongDA.AutoSize = true;
            this.labelPhongDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhongDA.Location = new System.Drawing.Point(364, 72);
            this.labelPhongDA.Name = "labelPhongDA";
            this.labelPhongDA.Size = new System.Drawing.Size(74, 25);
            this.labelPhongDA.TabIndex = 61;
            this.labelPhongDA.Text = "Phòng";
            this.labelPhongDA.Visible = false;
            // 
            // txtPhongDA
            // 
            this.txtPhongDA.Enabled = false;
            this.txtPhongDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongDA.Location = new System.Drawing.Point(470, 69);
            this.txtPhongDA.Name = "txtPhongDA";
            this.txtPhongDA.Size = new System.Drawing.Size(205, 30);
            this.txtPhongDA.TabIndex = 62;
            this.txtPhongDA.Visible = false;
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 850);
            this.Controls.Add(this.txtPhongDA);
            this.Controls.Add(this.labelPhongDA);
            this.Controls.Add(this.txtDiaDiemDA);
            this.Controls.Add(this.labelDiaDiemDA);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.labelTenDA);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.labelMaDA);
            this.Controls.Add(this.labelDUAN);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.labelDiaDiem);
            this.Controls.Add(this.dtpNgayNhanChuc);
            this.Controls.Add(this.labelNgNhanChuc);
            this.Controls.Add(this.txtTrP);
            this.Controls.Add(this.labelTrP);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.labelTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.labelMaPB);
            this.Controls.Add(this.labelPHONGBAN);
            this.Controls.Add(this.labelNHANVIEN);
            this.Controls.Add(this.labelPhongNV);
            this.Controls.Add(this.labelMaNQL);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtDchi);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelPhai);
            this.Controls.Add(this.dtpNgSinh);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.txtHotenNV);
            this.Controls.Add(this.labelHoTenNV);
            this.Controls.Add(this.labelMaHDNV);
            this.Controls.Add(this.txtPhai);
            this.Controls.Add(this.labelMaNV);
            this.Controls.Add(this.txtMaNQL);
            this.Controls.Add(this.picChanDung);
            this.Controls.Add(this.cmbPhong);
            this.Controls.Add(this.panel1);
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.Load += new System.EventHandler(this.FormTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxDA;
        private System.Windows.Forms.CheckBox checkBoxPB;
        private System.Windows.Forms.CheckBox checkBoxNV;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label labelNHANVIEN;
        private System.Windows.Forms.Label labelPhongNV;
        private System.Windows.Forms.Label labelMaNQL;
        private System.Windows.Forms.Label labelPhai;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelHoTenNV;
        private System.Windows.Forms.Label labelMaHDNV;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.PictureBox picChanDung;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.TextBox cmbPhong;
        private System.Windows.Forms.TextBox txtMaNQL;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.TextBox txtDchi;
        private System.Windows.Forms.TextBox txtHotenNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelPHONGBAN;
        private System.Windows.Forms.Label labelMaPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label labelTenPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label labelTrP;
        private System.Windows.Forms.TextBox txtTrP;
        private System.Windows.Forms.Label labelNgNhanChuc;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanChuc;
        private System.Windows.Forms.Label labelDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label labelDUAN;
        private System.Windows.Forms.Label labelMaDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label labelTenDA;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.Label labelDiaDiemDA;
        private System.Windows.Forms.TextBox txtDiaDiemDA;
        private System.Windows.Forms.Label labelPhongDA;
        private System.Windows.Forms.TextBox txtPhongDA;
    }
}