namespace QLNS_EntityFramework.Forms.ThoiViec
{
    partial class FormThoiViec
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
            this.dgvTHOIVIEC = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblDiaDiemDA = new System.Windows.Forms.Label();
            this.lblTenDA = new System.Windows.Forms.Label();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayThoiViec = new System.Windows.Forms.DateTimePicker();
            this.richtxtThoiViec = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHOIVIEC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTHOIVIEC
            // 
            this.dgvTHOIVIEC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTHOIVIEC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTHOIVIEC.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvTHOIVIEC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTHOIVIEC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHOIVIEC.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTHOIVIEC.Location = new System.Drawing.Point(28, 323);
            this.dgvTHOIVIEC.Name = "dgvTHOIVIEC";
            this.dgvTHOIVIEC.ReadOnly = true;
            this.dgvTHOIVIEC.RowHeadersWidth = 51;
            this.dgvTHOIVIEC.RowTemplate.Height = 24;
            this.dgvTHOIVIEC.Size = new System.Drawing.Size(1042, 385);
            this.dgvTHOIVIEC.TabIndex = 45;
            this.dgvTHOIVIEC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTHOIVIEC_CellClick);
            this.dgvTHOIVIEC.SelectionChanged += new System.EventHandler(this.dgvTHOIVIEC_SelectionChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(407, 273);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 35);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblDiaDiemDA
            // 
            this.lblDiaDiemDA.AutoSize = true;
            this.lblDiaDiemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiemDA.Location = new System.Drawing.Point(18, 152);
            this.lblDiaDiemDA.Name = "lblDiaDiemDA";
            this.lblDiaDiemDA.Size = new System.Drawing.Size(138, 25);
            this.lblDiaDiemDA.TabIndex = 63;
            this.lblDiaDiemDA.Text = "Mã hợp đồng";
            // 
            // lblTenDA
            // 
            this.lblTenDA.AutoSize = true;
            this.lblTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDA.Location = new System.Drawing.Point(450, 73);
            this.lblTenDA.Name = "lblTenDA";
            this.lblTenDA.Size = new System.Drawing.Size(148, 25);
            this.lblTenDA.TabIndex = 62;
            this.lblTenDA.Text = "Ngày thôi việc";
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDA.Location = new System.Drawing.Point(36, 68);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(142, 25);
            this.lblMaDA.TabIndex = 61;
            this.lblMaDA.Text = "Mã nhân viên";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(184, 154);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(205, 30);
            this.txtMaHD.TabIndex = 60;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(184, 68);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(205, 30);
            this.txtMaNV.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Lý do thôi việc";
            // 
            // dtpNgayThoiViec
            // 
            this.dtpNgayThoiViec.Location = new System.Drawing.Point(641, 73);
            this.dtpNgayThoiViec.Name = "dtpNgayThoiViec";
            this.dtpNgayThoiViec.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayThoiViec.TabIndex = 67;
            // 
            // richtxtThoiViec
            // 
            this.richtxtThoiViec.Location = new System.Drawing.Point(641, 156);
            this.richtxtThoiViec.Name = "richtxtThoiViec";
            this.richtxtThoiViec.Size = new System.Drawing.Size(292, 119);
            this.richtxtThoiViec.TabIndex = 68;
            this.richtxtThoiViec.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN ĐÃ THÔI VIỆC";
            // 
            // FormThoiViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richtxtThoiViec);
            this.Controls.Add(this.dtpNgayThoiViec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblDiaDiemDA);
            this.Controls.Add(this.lblTenDA);
            this.Controls.Add(this.lblMaDA);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.dgvTHOIVIEC);
            this.Name = "FormThoiViec";
            this.Text = "FormThoiViec";
            this.Load += new System.EventHandler(this.FormThoiViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHOIVIEC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTHOIVIEC;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblDiaDiemDA;
        private System.Windows.Forms.Label lblTenDA;
        private System.Windows.Forms.Label lblMaDA;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayThoiViec;
        private System.Windows.Forms.RichTextBox richtxtThoiViec;
        private System.Windows.Forms.Label label2;
    }
}