namespace QLNS_ADO.NET
{
    partial class FormDSDuAn
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
            this.lblTitleDA = new System.Windows.Forms.Label();
            this.lblDiaDiemDA = new System.Windows.Forms.Label();
            this.lblTenDA = new System.Windows.Forms.Label();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.txtDiaDiemDA = new System.Windows.Forms.TextBox();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.dgvDUAN = new System.Windows.Forms.DataGridView();
            this.lblPhongDA = new System.Windows.Forms.Label();
            this.btnLuuDA = new System.Windows.Forms.Button();
            this.btnXoaDA = new System.Windows.Forms.Button();
            this.btnSuaDA = new System.Windows.Forms.Button();
            this.btnXuatExcelDA = new System.Windows.Forms.Button();
            this.cmbPhongDA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDUAN)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleDA
            // 
            this.lblTitleDA.AutoSize = true;
            this.lblTitleDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDA.Location = new System.Drawing.Point(328, 20);
            this.lblTitleDA.Name = "lblTitleDA";
            this.lblTitleDA.Size = new System.Drawing.Size(257, 38);
            this.lblTitleDA.TabIndex = 42;
            this.lblTitleDA.Text = "Thông tin dự án";
            // 
            // lblDiaDiemDA
            // 
            this.lblDiaDiemDA.AutoSize = true;
            this.lblDiaDiemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiemDA.Location = new System.Drawing.Point(65, 243);
            this.lblDiaDiemDA.Name = "lblDiaDiemDA";
            this.lblDiaDiemDA.Size = new System.Drawing.Size(96, 25);
            this.lblDiaDiemDA.TabIndex = 38;
            this.lblDiaDiemDA.Text = "Địa điểm";
            // 
            // lblTenDA
            // 
            this.lblTenDA.AutoSize = true;
            this.lblTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDA.Location = new System.Drawing.Point(528, 98);
            this.lblTenDA.Name = "lblTenDA";
            this.lblTenDA.Size = new System.Drawing.Size(86, 25);
            this.lblTenDA.TabIndex = 35;
            this.lblTenDA.Text = "Tên DA";
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDA.Location = new System.Drawing.Point(74, 96);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(78, 25);
            this.lblMaDA.TabIndex = 34;
            this.lblMaDA.Text = "Mã DA";
            // 
            // txtDiaDiemDA
            // 
            this.txtDiaDiemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiemDA.Location = new System.Drawing.Point(168, 240);
            this.txtDiaDiemDA.Name = "txtDiaDiemDA";
            this.txtDiaDiemDA.Size = new System.Drawing.Size(205, 30);
            this.txtDiaDiemDA.TabIndex = 28;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDA.Location = new System.Drawing.Point(620, 93);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(205, 30);
            this.txtTenDA.TabIndex = 26;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDA.Location = new System.Drawing.Point(168, 91);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(205, 30);
            this.txtMaDA.TabIndex = 25;
            // 
            // dgvDUAN
            // 
            this.dgvDUAN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDUAN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDUAN.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDUAN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDUAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDUAN.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDUAN.Location = new System.Drawing.Point(35, 328);
            this.dgvDUAN.Name = "dgvDUAN";
            this.dgvDUAN.ReadOnly = true;
            this.dgvDUAN.RowHeadersWidth = 51;
            this.dgvDUAN.RowTemplate.Height = 24;
            this.dgvDUAN.Size = new System.Drawing.Size(1203, 488);
            this.dgvDUAN.TabIndex = 43;
            this.dgvDUAN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDUAN_CellClick);
            this.dgvDUAN.SelectionChanged += new System.EventHandler(this.dgvDUAN_SelectionChanged);
            // 
            // lblPhongDA
            // 
            this.lblPhongDA.AutoSize = true;
            this.lblPhongDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongDA.Location = new System.Drawing.Point(528, 245);
            this.lblPhongDA.Name = "lblPhongDA";
            this.lblPhongDA.Size = new System.Drawing.Size(74, 25);
            this.lblPhongDA.TabIndex = 44;
            this.lblPhongDA.Text = "Phòng";
            // 
            // btnLuuDA
            // 
            this.btnLuuDA.BackColor = System.Drawing.Color.Lime;
            this.btnLuuDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDA.Location = new System.Drawing.Point(1017, 179);
            this.btnLuuDA.Name = "btnLuuDA";
            this.btnLuuDA.Size = new System.Drawing.Size(146, 37);
            this.btnLuuDA.TabIndex = 45;
            this.btnLuuDA.TabStop = false;
            this.btnLuuDA.Text = "Lưu";
            this.btnLuuDA.UseVisualStyleBackColor = false;
            this.btnLuuDA.Click += new System.EventHandler(this.btnLuuDA_Click);
            // 
            // btnXoaDA
            // 
            this.btnXoaDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDA.Location = new System.Drawing.Point(1017, 245);
            this.btnXoaDA.Name = "btnXoaDA";
            this.btnXoaDA.Size = new System.Drawing.Size(146, 42);
            this.btnXoaDA.TabIndex = 46;
            this.btnXoaDA.TabStop = false;
            this.btnXoaDA.Text = "Xóa";
            this.btnXoaDA.UseVisualStyleBackColor = false;
            this.btnXoaDA.Click += new System.EventHandler(this.btnXoaDA_Click);
            // 
            // btnSuaDA
            // 
            this.btnSuaDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDA.Location = new System.Drawing.Point(1017, 108);
            this.btnSuaDA.Name = "btnSuaDA";
            this.btnSuaDA.Size = new System.Drawing.Size(146, 33);
            this.btnSuaDA.TabIndex = 47;
            this.btnSuaDA.TabStop = false;
            this.btnSuaDA.Text = "Sửa";
            this.btnSuaDA.UseVisualStyleBackColor = false;
            this.btnSuaDA.Click += new System.EventHandler(this.btnSuaDA_Click);
            // 
            // btnXuatExcelDA
            // 
            this.btnXuatExcelDA.BackColor = System.Drawing.Color.Green;
            this.btnXuatExcelDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcelDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelDA.Location = new System.Drawing.Point(1017, 38);
            this.btnXuatExcelDA.Name = "btnXuatExcelDA";
            this.btnXuatExcelDA.Size = new System.Drawing.Size(146, 35);
            this.btnXuatExcelDA.TabIndex = 50;
            this.btnXuatExcelDA.Text = "Xuất Excel";
            this.btnXuatExcelDA.UseVisualStyleBackColor = false;
            this.btnXuatExcelDA.Click += new System.EventHandler(this.btnXuatExcelDA_Click);
            // 
            // cmbPhongDA
            // 
            this.cmbPhongDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhongDA.FormattingEnabled = true;
            this.cmbPhongDA.Location = new System.Drawing.Point(620, 242);
            this.cmbPhongDA.Name = "cmbPhongDA";
            this.cmbPhongDA.Size = new System.Drawing.Size(205, 33);
            this.cmbPhongDA.TabIndex = 51;
            // 
            // FormDSDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 828);
            this.Controls.Add(this.cmbPhongDA);
            this.Controls.Add(this.btnXuatExcelDA);
            this.Controls.Add(this.btnSuaDA);
            this.Controls.Add(this.btnXoaDA);
            this.Controls.Add(this.btnLuuDA);
            this.Controls.Add(this.lblPhongDA);
            this.Controls.Add(this.dgvDUAN);
            this.Controls.Add(this.lblTitleDA);
            this.Controls.Add(this.lblDiaDiemDA);
            this.Controls.Add(this.lblTenDA);
            this.Controls.Add(this.lblMaDA);
            this.Controls.Add(this.txtDiaDiemDA);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.txtMaDA);
            this.Name = "FormDSDuAn";
            this.Text = "Danh Sách Dự Án";
            this.Load += new System.EventHandler(this.FormDanhSachDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDUAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleDA;
        private System.Windows.Forms.Label lblDiaDiemDA;
        private System.Windows.Forms.Label lblTenDA;
        private System.Windows.Forms.Label lblMaDA;
        private System.Windows.Forms.TextBox txtDiaDiemDA;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.DataGridView dgvDUAN;
        private System.Windows.Forms.Label lblPhongDA;
        private System.Windows.Forms.Button btnLuuDA;
        private System.Windows.Forms.Button btnXoaDA;
        private System.Windows.Forms.Button btnSuaDA;
        private System.Windows.Forms.Button btnXuatExcelDA;
        private System.Windows.Forms.ComboBox cmbPhongDA;
    }
}