namespace QLNS_ADO.NET
{
    partial class FormLuong
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
            this.lblTitleLG = new System.Windows.Forms.Label();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.lblLuongCung = new System.Windows.Forms.Label();
            this.lblMaNVLg = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.txtLuongCung = new System.Windows.Forms.TextBox();
            this.txtMaNVLg = new System.Windows.Forms.TextBox();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.lblNgayNghi = new System.Windows.Forms.Label();
            this.btnLuuLuong = new System.Windows.Forms.Button();
            this.btnSuaLuong = new System.Windows.Forms.Button();
            this.txtNgayNghi = new System.Windows.Forms.TextBox();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleLG
            // 
            this.lblTitleLG.AutoSize = true;
            this.lblTitleLG.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLG.Location = new System.Drawing.Point(309, 18);
            this.lblTitleLG.Name = "lblTitleLG";
            this.lblTitleLG.Size = new System.Drawing.Size(309, 38);
            this.lblTitleLG.TabIndex = 42;
            this.lblTitleLG.Text = "Bảng Lương Tháng";
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuCap.Location = new System.Drawing.Point(65, 243);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(91, 25);
            this.lblPhuCap.TabIndex = 38;
            this.lblPhuCap.Text = "Phụ cấp";
            // 
            // lblLuongCung
            // 
            this.lblLuongCung.AutoSize = true;
            this.lblLuongCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuongCung.Location = new System.Drawing.Point(477, 96);
            this.lblLuongCung.Name = "lblLuongCung";
            this.lblLuongCung.Size = new System.Drawing.Size(125, 25);
            this.lblLuongCung.TabIndex = 35;
            this.lblLuongCung.Text = "Lương cứng";
            // 
            // lblMaNVLg
            // 
            this.lblMaNVLg.AutoSize = true;
            this.lblMaNVLg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNVLg.Location = new System.Drawing.Point(74, 96);
            this.lblMaNVLg.Name = "lblMaNVLg";
            this.lblMaNVLg.Size = new System.Drawing.Size(78, 25);
            this.lblMaNVLg.TabIndex = 34;
            this.lblMaNVLg.Text = "Mã NV";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuCap.Location = new System.Drawing.Point(168, 240);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(205, 30);
            this.txtPhuCap.TabIndex = 28;
            // 
            // txtLuongCung
            // 
            this.txtLuongCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCung.Location = new System.Drawing.Point(624, 91);
            this.txtLuongCung.Name = "txtLuongCung";
            this.txtLuongCung.Size = new System.Drawing.Size(205, 30);
            this.txtLuongCung.TabIndex = 26;
            // 
            // txtMaNVLg
            // 
            this.txtMaNVLg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVLg.Location = new System.Drawing.Point(168, 91);
            this.txtMaNVLg.Name = "txtMaNVLg";
            this.txtMaNVLg.Size = new System.Drawing.Size(205, 30);
            this.txtMaNVLg.TabIndex = 25;
            // 
            // dgvLuong
            // 
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLuong.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLuong.Location = new System.Drawing.Point(35, 328);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(1203, 488);
            this.dgvLuong.TabIndex = 43;
            this.dgvLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CellClick);
            this.dgvLuong.SelectionChanged += new System.EventHandler(this.dgvLuong_SelectionChanged);
            // 
            // lblNgayNghi
            // 
            this.lblNgayNghi.AutoSize = true;
            this.lblNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNghi.Location = new System.Drawing.Point(463, 243);
            this.lblNgayNghi.Name = "lblNgayNghi";
            this.lblNgayNghi.Size = new System.Drawing.Size(139, 25);
            this.lblNgayNghi.TabIndex = 44;
            this.lblNgayNghi.Text = "Số ngày nghỉ";
            // 
            // btnLuuLuong
            // 
            this.btnLuuLuong.BackColor = System.Drawing.Color.Lime;
            this.btnLuuLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLuong.Location = new System.Drawing.Point(1017, 239);
            this.btnLuuLuong.Name = "btnLuuLuong";
            this.btnLuuLuong.Size = new System.Drawing.Size(146, 37);
            this.btnLuuLuong.TabIndex = 45;
            this.btnLuuLuong.TabStop = false;
            this.btnLuuLuong.Text = "Lưu";
            this.btnLuuLuong.UseVisualStyleBackColor = false;
            this.btnLuuLuong.Click += new System.EventHandler(this.btnLuuLuong_Click);
            // 
            // btnSuaLuong
            // 
            this.btnSuaLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLuong.Location = new System.Drawing.Point(1017, 154);
            this.btnSuaLuong.Name = "btnSuaLuong";
            this.btnSuaLuong.Size = new System.Drawing.Size(146, 33);
            this.btnSuaLuong.TabIndex = 47;
            this.btnSuaLuong.TabStop = false;
            this.btnSuaLuong.Text = "Sửa";
            this.btnSuaLuong.UseVisualStyleBackColor = false;
            this.btnSuaLuong.Click += new System.EventHandler(this.btnSuaLuong_Click);
            // 
            // txtNgayNghi
            // 
            this.txtNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNghi.Location = new System.Drawing.Point(624, 243);
            this.txtNgayNghi.Name = "txtNgayNghi";
            this.txtNgayNghi.Size = new System.Drawing.Size(205, 30);
            this.txtNgayNghi.TabIndex = 28;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.Location = new System.Drawing.Point(1017, 69);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(146, 37);
            this.btnTinhLuong.TabIndex = 45;
            this.btnTinhLuong.TabStop = false;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // FormLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 828);
            this.Controls.Add(this.btnSuaLuong);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnLuuLuong);
            this.Controls.Add(this.lblNgayNghi);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.lblTitleLG);
            this.Controls.Add(this.lblPhuCap);
            this.Controls.Add(this.lblLuongCung);
            this.Controls.Add(this.lblMaNVLg);
            this.Controls.Add(this.txtNgayNghi);
            this.Controls.Add(this.txtPhuCap);
            this.Controls.Add(this.txtLuongCung);
            this.Controls.Add(this.txtMaNVLg);
            this.Name = "FormLuong";
            this.Text = "Lương Nhân Viên";
            this.Load += new System.EventHandler(this.FormLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleLG;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.Label lblLuongCung;
        private System.Windows.Forms.Label lblMaNVLg;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtLuongCung;
        private System.Windows.Forms.TextBox txtMaNVLg;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Label lblNgayNghi;
        private System.Windows.Forms.Button btnLuuLuong;
        private System.Windows.Forms.Button btnSuaLuong;
        private System.Windows.Forms.TextBox txtNgayNghi;
        private System.Windows.Forms.Button btnTinhLuong;
    }
}