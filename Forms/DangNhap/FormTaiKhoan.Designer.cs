namespace QLNS_LinQ
{
    partial class FormTaiKhoan
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoimatkhau = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.textOldPass = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(304, 585);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(187, 35);
            this.btnDangXuat.TabIndex = 21;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.BackColor = System.Drawing.Color.Lime;
            this.btnDoimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoimatkhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoimatkhau.Location = new System.Drawing.Point(304, 530);
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.Size = new System.Drawing.Size(187, 35);
            this.btnDoimatkhau.TabIndex = 20;
            this.btnDoimatkhau.Text = "Đổi mật khẩu";
            this.btnDoimatkhau.UseVisualStyleBackColor = false;
            this.btnDoimatkhau.Click += new System.EventHandler(this.btnDoimatkhau_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mật khẩu mới";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu cũ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên đăng nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(304, 436);
            this.txtNewPass.MaximumSize = new System.Drawing.Size(227, 38);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(227, 38);
            this.txtNewPass.TabIndex = 16;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // textOldPass
            // 
            this.textOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOldPass.Location = new System.Drawing.Point(304, 370);
            this.textOldPass.MaximumSize = new System.Drawing.Size(227, 38);
            this.textOldPass.Name = "textOldPass";
            this.textOldPass.PasswordChar = '*';
            this.textOldPass.Size = new System.Drawing.Size(227, 38);
            this.textOldPass.TabIndex = 15;
            this.textOldPass.TextChanged += new System.EventHandler(this.textOldPass_TextChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(304, 301);
            this.txtTenDangNhap.MaximumSize = new System.Drawing.Size(227, 38);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(227, 38);
            this.txtTenDangNhap.TabIndex = 14;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đổi mật khẩu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(299, 209);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 25);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "label1";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNS_LinQ.Properties.Resources.img_account;
            this.pictureBox1.Location = new System.Drawing.Point(326, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 689);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDoimatkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.textOldPass);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelName);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoimatkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox textOldPass;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
    }
}