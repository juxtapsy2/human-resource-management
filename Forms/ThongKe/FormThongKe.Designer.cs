namespace QLNS_EntityFramework.Forms.ThongKe
{
    partial class FormThongKe
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
            this.btnThongKeLuong = new System.Windows.Forms.Button();
            this.btnThongKeNhanLuc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKeLuong
            // 
            this.btnThongKeLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThongKeLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeLuong.Location = new System.Drawing.Point(133, 387);
            this.btnThongKeLuong.Name = "btnThongKeLuong";
            this.btnThongKeLuong.Size = new System.Drawing.Size(303, 46);
            this.btnThongKeLuong.TabIndex = 2;
            this.btnThongKeLuong.Text = "THỐNG KÊ THU NHẬP";
            this.btnThongKeLuong.UseVisualStyleBackColor = false;
            this.btnThongKeLuong.Click += new System.EventHandler(this.btnThongKeLuong_Click);
            // 
            // btnThongKeNhanLuc
            // 
            this.btnThongKeNhanLuc.BackColor = System.Drawing.Color.Lime;
            this.btnThongKeNhanLuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeNhanLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNhanLuc.Location = new System.Drawing.Point(478, 387);
            this.btnThongKeNhanLuc.Name = "btnThongKeNhanLuc";
            this.btnThongKeNhanLuc.Size = new System.Drawing.Size(324, 46);
            this.btnThongKeNhanLuc.TabIndex = 3;
            this.btnThongKeNhanLuc.Text = "THỐNG KÊ NHÂN LỰC";
            this.btnThongKeNhanLuc.UseVisualStyleBackColor = false;
            this.btnThongKeNhanLuc.Click += new System.EventHandler(this.btnThongKeNhanLuc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLNS_EntityFramework.Properties.Resources.img_bieudo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(312, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 280);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 529);
            this.Controls.Add(this.btnThongKeNhanLuc);
            this.Controls.Add(this.btnThongKeLuong);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThongKeLuong;
        private System.Windows.Forms.Button btnThongKeNhanLuc;
    }
}