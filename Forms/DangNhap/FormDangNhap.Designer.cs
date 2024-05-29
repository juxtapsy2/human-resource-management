namespace QLNS_LinQ
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
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lablename = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(348, 205);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(252, 38);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(348, 280);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(252, 38);
            this.txtMatKhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(381, 362);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(175, 39);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lablename
            // 
            this.lablename.AutoSize = true;
            this.lablename.BackColor = System.Drawing.Color.Transparent;
            this.lablename.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablename.ForeColor = System.Drawing.Color.Red;
            this.lablename.Location = new System.Drawing.Point(139, 109);
            this.lablename.Name = "lablename";
            this.lablename.Size = new System.Drawing.Size(675, 54);
            this.lablename.TabIndex = 3;
            this.lablename.Text = "QUẢN LÝ NHÂN SỰ CÔNG TY  - LinQ";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTenDangNhap.Location = new System.Drawing.Point(166, 218);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(158, 25);
            this.lblTenDangNhap.TabIndex = 5;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMatKhau.Location = new System.Drawing.Point(191, 280);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(101, 25);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // checkHide
            // 
            this.checkHide.AutoSize = true;
            this.checkHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHide.Location = new System.Drawing.Point(384, 328);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(160, 26);
            this.checkHide.TabIndex = 7;
            this.checkHide.Text = "Hiện mật khẩu";
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckStateChanged += new System.EventHandler(this.checkHide_CheckStateChanged);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLNS_LinQ.Properties.Resources.bg_company;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 598);
            this.Controls.Add(this.checkHide);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lablename);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lablename;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.CheckBox checkHide;
    }
}