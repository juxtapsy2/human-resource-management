namespace QLNS_LinQ
{
    partial class FormThanNhan
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTHANNHAN = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANNHAN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Chartreuse;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(850, 162);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 34);
            this.btnLuu.TabIndex = 64;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(850, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 34);
            this.btnSua.TabIndex = 63;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(850, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 34);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 61;
            this.label5.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 60;
            this.label4.Text = "Vai trò";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 59;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã NV";
            // 
            // dgvTHANNHAN
            // 
            this.dgvTHANNHAN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTHANNHAN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTHANNHAN.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvTHANNHAN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTHANNHAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHANNHAN.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTHANNHAN.Location = new System.Drawing.Point(49, 224);
            this.dgvTHANNHAN.Name = "dgvTHANNHAN";
            this.dgvTHANNHAN.ReadOnly = true;
            this.dgvTHANNHAN.RowHeadersWidth = 51;
            this.dgvTHANNHAN.RowTemplate.Height = 24;
            this.dgvTHANNHAN.Size = new System.Drawing.Size(1025, 486);
            this.dgvTHANNHAN.TabIndex = 57;
            this.dgvTHANNHAN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTHANNHAN_CellClick);
            this.dgvTHANNHAN.SelectionChanged += new System.EventHandler(this.dgvTHANNHAN_SelectionChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(521, 141);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(213, 30);
            this.txtSDT.TabIndex = 56;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaiTro.Location = new System.Drawing.Point(521, 74);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(213, 30);
            this.txtVaiTro.TabIndex = 55;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(161, 142);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(228, 30);
            this.txtHoTen.TabIndex = 54;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(161, 70);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(153, 33);
            this.cmbMaNV.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "Thông tin thân nhân";
            // 
            // FormThanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 725);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTHANNHAN);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtVaiTro);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cmbMaNV);
            this.Controls.Add(this.label1);
            this.Name = "FormThanNhan";
            this.Text = "FormThanNhan";
            this.Load += new System.EventHandler(this.FormThanNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANNHAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTHANNHAN;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label label1;
    }
}