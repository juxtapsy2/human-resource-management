namespace QLNS_LinQ.Forms.PhongBan
{
    partial class FormDSPhongBan
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
            this.cmbTrPhong = new System.Windows.Forms.ComboBox();
            this.btnXuatExcelPB = new System.Windows.Forms.Button();
            this.btnSuaPB = new System.Windows.Forms.Button();
            this.btnXoaPB = new System.Windows.Forms.Button();
            this.btnLuuPB = new System.Windows.Forms.Button();
            this.lblPhongDA = new System.Windows.Forms.Label();
            this.dgvPHONGBAN = new System.Windows.Forms.DataGridView();
            this.lblTitleDA = new System.Windows.Forms.Label();
            this.lblDiaDiemDA = new System.Windows.Forms.Label();
            this.lblTenDA = new System.Windows.Forms.Label();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.dtpNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiadiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONGBAN)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTrPhong
            // 
            this.cmbTrPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrPhong.FormattingEnabled = true;
            this.cmbTrPhong.Location = new System.Drawing.Point(193, 231);
            this.cmbTrPhong.Name = "cmbTrPhong";
            this.cmbTrPhong.Size = new System.Drawing.Size(153, 33);
            this.cmbTrPhong.TabIndex = 65;
            // 
            // btnXuatExcelPB
            // 
            this.btnXuatExcelPB.BackColor = System.Drawing.Color.Green;
            this.btnXuatExcelPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcelPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelPB.Location = new System.Drawing.Point(920, 27);
            this.btnXuatExcelPB.Name = "btnXuatExcelPB";
            this.btnXuatExcelPB.Size = new System.Drawing.Size(126, 45);
            this.btnXuatExcelPB.TabIndex = 64;
            this.btnXuatExcelPB.Text = "Xuất Excel";
            this.btnXuatExcelPB.UseVisualStyleBackColor = false;
            this.btnXuatExcelPB.Click += new System.EventHandler(this.btnXuatExcelPB_Click);
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPB.Location = new System.Drawing.Point(920, 97);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(126, 35);
            this.btnSuaPB.TabIndex = 63;
            this.btnSuaPB.TabStop = false;
            this.btnSuaPB.Text = "Sửa";
            this.btnSuaPB.UseVisualStyleBackColor = false;
            this.btnSuaPB.Click += new System.EventHandler(this.btnSuaPB_Click);
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPB.Location = new System.Drawing.Point(920, 234);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(126, 42);
            this.btnXoaPB.TabIndex = 62;
            this.btnXoaPB.TabStop = false;
            this.btnXoaPB.Text = "Xóa";
            this.btnXoaPB.UseVisualStyleBackColor = false;
            this.btnXoaPB.Click += new System.EventHandler(this.btnXoaPB_Click);
            // 
            // btnLuuPB
            // 
            this.btnLuuPB.BackColor = System.Drawing.Color.Lime;
            this.btnLuuPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPB.Location = new System.Drawing.Point(920, 168);
            this.btnLuuPB.Name = "btnLuuPB";
            this.btnLuuPB.Size = new System.Drawing.Size(126, 45);
            this.btnLuuPB.TabIndex = 61;
            this.btnLuuPB.TabStop = false;
            this.btnLuuPB.Text = "Lưu";
            this.btnLuuPB.UseVisualStyleBackColor = false;
            this.btnLuuPB.Click += new System.EventHandler(this.btnLuuPB_Click);
            // 
            // lblPhongDA
            // 
            this.lblPhongDA.AutoSize = true;
            this.lblPhongDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongDA.Location = new System.Drawing.Point(368, 82);
            this.lblPhongDA.Name = "lblPhongDA";
            this.lblPhongDA.Size = new System.Drawing.Size(168, 25);
            this.lblPhongDA.TabIndex = 60;
            this.lblPhongDA.Text = "Ngày nhận chức";
            // 
            // dgvPHONGBAN
            // 
            this.dgvPHONGBAN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPHONGBAN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPHONGBAN.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPHONGBAN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPHONGBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHONGBAN.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPHONGBAN.Location = new System.Drawing.Point(35, 310);
            this.dgvPHONGBAN.Name = "dgvPHONGBAN";
            this.dgvPHONGBAN.ReadOnly = true;
            this.dgvPHONGBAN.RowHeadersWidth = 51;
            this.dgvPHONGBAN.RowTemplate.Height = 24;
            this.dgvPHONGBAN.Size = new System.Drawing.Size(1064, 379);
            this.dgvPHONGBAN.TabIndex = 59;
            this.dgvPHONGBAN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPHONGBAN_CellClick);
            this.dgvPHONGBAN.SelectionChanged += new System.EventHandler(this.dgvPHONGBAN_SelectionChanged);
            // 
            // lblTitleDA
            // 
            this.lblTitleDA.AutoSize = true;
            this.lblTitleDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDA.Location = new System.Drawing.Point(353, 9);
            this.lblTitleDA.Name = "lblTitleDA";
            this.lblTitleDA.Size = new System.Drawing.Size(333, 38);
            this.lblTitleDA.TabIndex = 58;
            this.lblTitleDA.Text = "Thông tin phòng ban";
            // 
            // lblDiaDiemDA
            // 
            this.lblDiaDiemDA.AutoSize = true;
            this.lblDiaDiemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiemDA.Location = new System.Drawing.Point(21, 151);
            this.lblDiaDiemDA.Name = "lblDiaDiemDA";
            this.lblDiaDiemDA.Size = new System.Drawing.Size(84, 25);
            this.lblDiaDiemDA.TabIndex = 57;
            this.lblDiaDiemDA.Text = "Tên PB";
            // 
            // lblTenDA
            // 
            this.lblTenDA.AutoSize = true;
            this.lblTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDA.Location = new System.Drawing.Point(29, 234);
            this.lblTenDA.Name = "lblTenDA";
            this.lblTenDA.Size = new System.Drawing.Size(149, 25);
            this.lblTenDA.TabIndex = 56;
            this.lblTenDA.Text = "Trưởng Phòng";
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDA.Location = new System.Drawing.Point(29, 88);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(76, 25);
            this.lblMaDA.TabIndex = 55;
            this.lblMaDA.Text = "Mã PB";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPB.Location = new System.Drawing.Point(120, 146);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(226, 30);
            this.txtTenPB.TabIndex = 54;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPB.Location = new System.Drawing.Point(111, 82);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(235, 30);
            this.txtMaPB.TabIndex = 52;
            // 
            // dtpNgayNhanChuc
            // 
            this.dtpNgayNhanChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhanChuc.Location = new System.Drawing.Point(553, 79);
            this.dtpNgayNhanChuc.Name = "dtpNgayNhanChuc";
            this.dtpNgayNhanChuc.Size = new System.Drawing.Size(200, 28);
            this.dtpNgayNhanChuc.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Địa điểm";
            // 
            // txtDiadiem
            // 
            this.txtDiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiadiem.Location = new System.Drawing.Point(553, 151);
            this.txtDiadiem.Name = "txtDiadiem";
            this.txtDiadiem.Size = new System.Drawing.Size(226, 30);
            this.txtDiadiem.TabIndex = 68;
            // 
            // FormDSPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 711);
            this.Controls.Add(this.txtDiadiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayNhanChuc);
            this.Controls.Add(this.cmbTrPhong);
            this.Controls.Add(this.btnXuatExcelPB);
            this.Controls.Add(this.btnSuaPB);
            this.Controls.Add(this.btnXoaPB);
            this.Controls.Add(this.btnLuuPB);
            this.Controls.Add(this.lblPhongDA);
            this.Controls.Add(this.dgvPHONGBAN);
            this.Controls.Add(this.lblTitleDA);
            this.Controls.Add(this.lblDiaDiemDA);
            this.Controls.Add(this.lblTenDA);
            this.Controls.Add(this.lblMaDA);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Name = "FormDSPhongBan";
            this.Text = "FormDSPhongBan";
            this.Load += new System.EventHandler(this.FormDSPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHONGBAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTrPhong;
        private System.Windows.Forms.Button btnXuatExcelPB;
        private System.Windows.Forms.Button btnSuaPB;
        private System.Windows.Forms.Button btnXoaPB;
        private System.Windows.Forms.Button btnLuuPB;
        private System.Windows.Forms.Label lblPhongDA;
        private System.Windows.Forms.DataGridView dgvPHONGBAN;
        private System.Windows.Forms.Label lblTitleDA;
        private System.Windows.Forms.Label lblDiaDiemDA;
        private System.Windows.Forms.Label lblTenDA;
        private System.Windows.Forms.Label lblMaDA;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanChuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiadiem;
    }
}