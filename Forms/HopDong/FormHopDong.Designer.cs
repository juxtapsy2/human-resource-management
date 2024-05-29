namespace QLNS_EntityFramework.Forms.HopDong
{
    partial class FormHopDong
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
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgvHOPDONG = new System.Windows.Forms.DataGridView();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnXuatExcelHD = new System.Windows.Forms.Button();
            this.cmbViTri = new System.Windows.Forms.ComboBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.richtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOPDONG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleDA
            // 
            this.lblTitleDA.AutoSize = true;
            this.lblTitleDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDA.Location = new System.Drawing.Point(328, 20);
            this.lblTitleDA.Name = "lblTitleDA";
            this.lblTitleDA.Size = new System.Drawing.Size(336, 38);
            this.lblTitleDA.TabIndex = 42;
            this.lblTitleDA.Text = "Danh sách hợp đồng";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTri.Location = new System.Drawing.Point(83, 245);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(56, 25);
            this.lblViTri.TabIndex = 38;
            this.lblViTri.Text = "Vị trí";
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHan.Location = new System.Drawing.Point(505, 98);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(97, 25);
            this.lblThoiHan.TabIndex = 35;
            this.lblThoiHan.Text = "Thời hạn";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(74, 96);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(78, 25);
            this.lblMaHD.TabIndex = 34;
            this.lblMaHD.Text = "Mã HD";
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiHan.Location = new System.Drawing.Point(620, 93);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(129, 30);
            this.txtThoiHan.TabIndex = 26;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(168, 93);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(205, 30);
            this.txtMaHD.TabIndex = 25;
            // 
            // dgvHOPDONG
            // 
            this.dgvHOPDONG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHOPDONG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHOPDONG.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvHOPDONG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHOPDONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOPDONG.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHOPDONG.Location = new System.Drawing.Point(35, 328);
            this.dgvHOPDONG.Name = "dgvHOPDONG";
            this.dgvHOPDONG.ReadOnly = true;
            this.dgvHOPDONG.RowHeadersWidth = 51;
            this.dgvHOPDONG.RowTemplate.Height = 24;
            this.dgvHOPDONG.Size = new System.Drawing.Size(1203, 488);
            this.dgvHOPDONG.TabIndex = 43;
            this.dgvHOPDONG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHOPDONG_CellClick);
            this.dgvHOPDONG.SelectionChanged += new System.EventHandler(this.dgvHOPDONG_SelectionChanged);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackColor = System.Drawing.Color.Lime;
            this.btnLuuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.Location = new System.Drawing.Point(1017, 261);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(146, 37);
            this.btnLuuHD.TabIndex = 45;
            this.btnLuuHD.TabStop = false;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.UseVisualStyleBackColor = false;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHD.Location = new System.Drawing.Point(1017, 173);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(146, 33);
            this.btnSuaHD.TabIndex = 47;
            this.btnSuaHD.TabStop = false;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = false;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnXuatExcelHD
            // 
            this.btnXuatExcelHD.BackColor = System.Drawing.Color.Green;
            this.btnXuatExcelHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcelHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelHD.Location = new System.Drawing.Point(1017, 86);
            this.btnXuatExcelHD.Name = "btnXuatExcelHD";
            this.btnXuatExcelHD.Size = new System.Drawing.Size(146, 35);
            this.btnXuatExcelHD.TabIndex = 50;
            this.btnXuatExcelHD.Text = "Xuất Excel";
            this.btnXuatExcelHD.UseVisualStyleBackColor = false;
            this.btnXuatExcelHD.Click += new System.EventHandler(this.btnXuatExcelHD_Click);
            // 
            // cmbViTri
            // 
            this.cmbViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViTri.FormattingEnabled = true;
            this.cmbViTri.Location = new System.Drawing.Point(168, 237);
            this.cmbViTri.Name = "cmbViTri";
            this.cmbViTri.Size = new System.Drawing.Size(205, 33);
            this.cmbViTri.TabIndex = 51;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.Location = new System.Drawing.Point(772, 96);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(53, 25);
            this.lblDonVi.TabIndex = 35;
            this.lblDonVi.Text = "năm";
            // 
            // richtxtMoTa
            // 
            this.richtxtMoTa.Location = new System.Drawing.Point(577, 179);
            this.richtxtMoTa.Name = "richtxtMoTa";
            this.richtxtMoTa.Size = new System.Drawing.Size(292, 119);
            this.richtxtMoTa.TabIndex = 52;
            this.richtxtMoTa.Text = "";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(490, 240);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(66, 25);
            this.lblMoTa.TabIndex = 38;
            this.lblMoTa.Text = "Mô tả";
            // 
            // FormHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 828);
            this.Controls.Add(this.richtxtMoTa);
            this.Controls.Add(this.cmbViTri);
            this.Controls.Add(this.btnXuatExcelHD);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.dgvHOPDONG);
            this.Controls.Add(this.lblTitleDA);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.lblThoiHan);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.txtThoiHan);
            this.Controls.Add(this.txtMaHD);
            this.Name = "FormHopDong";
            this.Text = "Danh Sách Hợp Đồng";
            this.Load += new System.EventHandler(this.FormHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOPDONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleDA;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvHOPDONG;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnXuatExcelHD;
        private System.Windows.Forms.ComboBox cmbViTri;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.RichTextBox richtxtMoTa;
        private System.Windows.Forms.Label lblMoTa;
    }
}