namespace QLNS_ADO.NET
{
    partial class FormDSNhanVien
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
            this.picChanDung = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.txtDchi = new System.Windows.Forms.TextBox();
            this.txtHotenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dgvNHANVIEN = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.cmbMaHD = new System.Windows.Forms.ComboBox();
            this.cmbMaNQL = new System.Windows.Forms.ComboBox();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHANVIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // picChanDung
            // 
            this.picChanDung.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.H0;
            this.picChanDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChanDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picChanDung.Location = new System.Drawing.Point(961, 21);
            this.picChanDung.Name = "picChanDung";
            this.picChanDung.Size = new System.Drawing.Size(171, 236);
            this.picChanDung.TabIndex = 0;
            this.picChanDung.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(259, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(321, 38);
            this.label10.TabIndex = 42;
            this.label10.Text = "Thông tin nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "MaNQL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Phái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã HD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã NV";
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Location = new System.Drawing.Point(164, 220);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgSinh.TabIndex = 33;
            // 
            // txtDchi
            // 
            this.txtDchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDchi.Location = new System.Drawing.Point(159, 269);
            this.txtDchi.Name = "txtDchi";
            this.txtDchi.Size = new System.Drawing.Size(205, 30);
            this.txtDchi.TabIndex = 28;
            // 
            // txtHotenNV
            // 
            this.txtHotenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotenNV.Location = new System.Drawing.Point(159, 175);
            this.txtHotenNV.Name = "txtHotenNV";
            this.txtHotenNV.Size = new System.Drawing.Size(205, 30);
            this.txtHotenNV.TabIndex = 27;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(159, 75);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(205, 30);
            this.txtMaNV.TabIndex = 25;
            // 
            // dgvNHANVIEN
            // 
            this.dgvNHANVIEN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNHANVIEN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvNHANVIEN.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvNHANVIEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNHANVIEN.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNHANVIEN.Location = new System.Drawing.Point(35, 328);
            this.dgvNHANVIEN.Name = "dgvNHANVIEN";
            this.dgvNHANVIEN.ReadOnly = true;
            this.dgvNHANVIEN.RowHeadersWidth = 51;
            this.dgvNHANVIEN.RowTemplate.Height = 24;
            this.dgvNHANVIEN.Size = new System.Drawing.Size(1203, 488);
            this.dgvNHANVIEN.TabIndex = 43;
            this.dgvNHANVIEN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNHANVIEN_CellClick);
            this.dgvNHANVIEN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNHANVIEN_CellContentClick);
            this.dgvNHANVIEN.SelectionChanged += new System.EventHandler(this.dgvNHANVIEN_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Phòng";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(733, 174);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 37);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(733, 223);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 42);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(733, 122);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 33);
            this.btnSua.TabIndex = 47;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Location = new System.Drawing.Point(991, 269);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(114, 45);
            this.btnChonAnh.TabIndex = 48;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Visible = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.Green;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(733, 70);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(146, 35);
            this.btnXuatExcel.TabIndex = 49;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // cmbMaHD
            // 
            this.cmbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaHD.FormattingEnabled = true;
            this.cmbMaHD.Location = new System.Drawing.Point(164, 129);
            this.cmbMaHD.Name = "cmbMaHD";
            this.cmbMaHD.Size = new System.Drawing.Size(200, 30);
            this.cmbMaHD.TabIndex = 50;
            // 
            // cmbMaNQL
            // 
            this.cmbMaNQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaNQL.FormattingEnabled = true;
            this.cmbMaNQL.Location = new System.Drawing.Point(465, 129);
            this.cmbMaNQL.Name = "cmbMaNQL";
            this.cmbMaNQL.Size = new System.Drawing.Size(208, 33);
            this.cmbMaNQL.TabIndex = 51;
            // 
            // cmbPhong
            // 
            this.cmbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(465, 186);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(208, 33);
            this.cmbPhong.TabIndex = 52;
            // 
            // cmbPhai
            // 
            this.cmbPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Location = new System.Drawing.Point(465, 79);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(121, 28);
            this.cmbPhai.TabIndex = 82;
            // 
            // FormDSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 828);
            this.Controls.Add(this.cmbPhai);
            this.Controls.Add(this.cmbPhong);
            this.Controls.Add(this.cmbMaNQL);
            this.Controls.Add(this.cmbMaHD);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvNHANVIEN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgSinh);
            this.Controls.Add(this.txtDchi);
            this.Controls.Add(this.txtHotenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.picChanDung);
            this.Name = "FormDSNhanVien";
            this.Text = "DanhSachNhanVien";
            this.Load += new System.EventHandler(this.FormDSNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHANVIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChanDung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.TextBox txtDchi;
        private System.Windows.Forms.TextBox txtHotenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridView dgvNHANVIEN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.ComboBox cmbMaHD;
        private System.Windows.Forms.ComboBox cmbMaNQL;
        private System.Windows.Forms.ComboBox cmbPhong;
        public System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.ComboBox cmbPhai;
    }
}