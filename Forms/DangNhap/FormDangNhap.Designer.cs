namespace QLNS_ADO.NET
{
    partial class FormDangNhap
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
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lablename = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(443, 229);
            this.txtTenDangNhap.MaximumSize = new System.Drawing.Size(227, 38);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(227, 38);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(447, 299);
            this.txtMatKhau.MaximumSize = new System.Drawing.Size(227, 38);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(227, 38);
            this.txtMatKhau.TabIndex = 1;
            // 
            // lablename
            // 
            this.lablename.AutoSize = true;
            this.lablename.BackColor = System.Drawing.Color.Transparent;
            this.lablename.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablename.ForeColor = System.Drawing.Color.Red;
            this.lablename.Location = new System.Drawing.Point(193, 131);
            this.lablename.Name = "lablename";
            this.lablename.Size = new System.Drawing.Size(666, 54);
            this.lablename.TabIndex = 2;
            this.lablename.Text = "QUẢN LÝ NHÂN SỰ CÔNG TY - ADO";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangNhap.Location = new System.Drawing.Point(473, 394);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(159, 43);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTenDangNhap.Location = new System.Drawing.Point(262, 238);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(158, 25);
            this.lblTenDangNhap.TabIndex = 4;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMatKhau.Location = new System.Drawing.Point(319, 308);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(101, 25);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // checkHide
            // 
            this.checkHide.AutoSize = true;
            this.checkHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHide.Location = new System.Drawing.Point(472, 353);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(160, 26);
            this.checkHide.TabIndex = 6;
            this.checkHide.Text = "Hiện mật khẩu";
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckStateChanged += new System.EventHandler(this.checkHide_CheckStateChanged);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLNS_ADO.NET.Properties.Resources.bg_company;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 680);
            this.Controls.Add(this.checkHide);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lablename);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.MaximumSize = new System.Drawing.Size(1136, 727);
            this.MinimumSize = new System.Drawing.Size(1136, 727);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lablename;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.CheckBox checkHide;
    }
}