namespace QLNS_EntityFramework.Forms.PhongBan
{
    partial class FormThemPhongBan
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
            this.btnThemPB = new System.Windows.Forms.Button();
            this.txtDiaDiemM = new System.Windows.Forms.TextBox();
            this.txtTenPBM = new System.Windows.Forms.TextBox();
            this.txtMaPBM = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblNgNhanChuc = new System.Windows.Forms.Label();
            this.lblTrPhong = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblTTNhanvien = new System.Windows.Forms.Label();
            this.dtpNgNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.cmbTrPhong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnThemPB
            // 
            this.btnThemPB.BackColor = System.Drawing.Color.Lime;
            this.btnThemPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPB.Location = new System.Drawing.Point(361, 400);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(152, 39);
            this.btnThemPB.TabIndex = 48;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.UseVisualStyleBackColor = false;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // txtDiaDiemM
            // 
            this.txtDiaDiemM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiemM.Location = new System.Drawing.Point(347, 306);
            this.txtDiaDiemM.Name = "txtDiaDiemM";
            this.txtDiaDiemM.Size = new System.Drawing.Size(306, 30);
            this.txtDiaDiemM.TabIndex = 47;
            // 
            // txtTenPBM
            // 
            this.txtTenPBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPBM.Location = new System.Drawing.Point(177, 207);
            this.txtTenPBM.Name = "txtTenPBM";
            this.txtTenPBM.Size = new System.Drawing.Size(215, 30);
            this.txtTenPBM.TabIndex = 45;
            // 
            // txtMaPBM
            // 
            this.txtMaPBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPBM.Location = new System.Drawing.Point(177, 109);
            this.txtMaPBM.Name = "txtMaPBM";
            this.txtMaPBM.Size = new System.Drawing.Size(215, 30);
            this.txtMaPBM.TabIndex = 43;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiem.Location = new System.Drawing.Point(250, 311);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(91, 25);
            this.lblDiaDiem.TabIndex = 42;
            this.lblDiaDiem.Text = "Địa Điểm";
            // 
            // lblNgNhanChuc
            // 
            this.lblNgNhanChuc.AutoSize = true;
            this.lblNgNhanChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgNhanChuc.Location = new System.Drawing.Point(479, 214);
            this.lblNgNhanChuc.Name = "lblNgNhanChuc";
            this.lblNgNhanChuc.Size = new System.Drawing.Size(131, 25);
            this.lblNgNhanChuc.TabIndex = 41;
            this.lblNgNhanChuc.Text = "NgNhanChuc";
            // 
            // lblTrPhong
            // 
            this.lblTrPhong.AutoSize = true;
            this.lblTrPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrPhong.Location = new System.Drawing.Point(497, 111);
            this.lblTrPhong.Name = "lblTrPhong";
            this.lblTrPhong.Size = new System.Drawing.Size(88, 25);
            this.lblTrPhong.TabIndex = 40;
            this.lblTrPhong.Text = "TrPhong";
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPB.Location = new System.Drawing.Point(49, 211);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(78, 25);
            this.lblTenPB.TabIndex = 39;
            this.lblTenPB.Text = "Tên PB";
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPB.Location = new System.Drawing.Point(49, 114);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(71, 25);
            this.lblMaPB.TabIndex = 38;
            this.lblMaPB.Text = "Mã PB";
            // 
            // lblTTNhanvien
            // 
            this.lblTTNhanvien.AutoSize = true;
            this.lblTTNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTNhanvien.Location = new System.Drawing.Point(297, 17);
            this.lblTTNhanvien.Name = "lblTTNhanvien";
            this.lblTTNhanvien.Size = new System.Drawing.Size(333, 38);
            this.lblTTNhanvien.TabIndex = 37;
            this.lblTTNhanvien.Text = "Thông tin phòng ban";
            // 
            // dtpNgNhanChuc
            // 
            this.dtpNgNhanChuc.Location = new System.Drawing.Point(652, 214);
            this.dtpNgNhanChuc.Name = "dtpNgNhanChuc";
            this.dtpNgNhanChuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgNhanChuc.TabIndex = 49;
            // 
            // cmbTrPhong
            // 
            this.cmbTrPhong.FormattingEnabled = true;
            this.cmbTrPhong.Location = new System.Drawing.Point(652, 114);
            this.cmbTrPhong.Name = "cmbTrPhong";
            this.cmbTrPhong.Size = new System.Drawing.Size(121, 24);
            this.cmbTrPhong.TabIndex = 50;
            // 
            // FormThemPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 480);
            this.Controls.Add(this.cmbTrPhong);
            this.Controls.Add(this.dtpNgNhanChuc);
            this.Controls.Add(this.btnThemPB);
            this.Controls.Add(this.txtDiaDiemM);
            this.Controls.Add(this.txtTenPBM);
            this.Controls.Add(this.txtMaPBM);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.lblNgNhanChuc);
            this.Controls.Add(this.lblTrPhong);
            this.Controls.Add(this.lblTenPB);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.lblTTNhanvien);
            this.Name = "FormThemPhongBan";
            this.Text = "FormThemPhongBan";
            this.Load += new System.EventHandler(this.FormThemPhongBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.TextBox txtDiaDiemM;
        private System.Windows.Forms.TextBox txtTenPBM;
        private System.Windows.Forms.TextBox txtMaPBM;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblNgNhanChuc;
        private System.Windows.Forms.Label lblTrPhong;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblTTNhanvien;
        private System.Windows.Forms.DateTimePicker dtpNgNhanChuc;
        private System.Windows.Forms.ComboBox cmbTrPhong;
    }
}