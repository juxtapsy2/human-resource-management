namespace QLNS_LinQ
{
    partial class FormCanhBaoXoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.txtLyDoThoiViec = new System.Windows.Forms.TextBox();
            this.lblCanhBao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập lý do thôi việc";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(392, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.BackColor = System.Drawing.Color.Lime;
            this.btnChapNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChapNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChapNhan.ForeColor = System.Drawing.Color.Black;
            this.btnChapNhan.Location = new System.Drawing.Point(182, 643);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(150, 40);
            this.btnChapNhan.TabIndex = 9;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.UseVisualStyleBackColor = false;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // txtLyDoThoiViec
            // 
            this.txtLyDoThoiViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDoThoiViec.Location = new System.Drawing.Point(55, 294);
            this.txtLyDoThoiViec.Multiline = true;
            this.txtLyDoThoiViec.Name = "txtLyDoThoiViec";
            this.txtLyDoThoiViec.Size = new System.Drawing.Size(618, 322);
            this.txtLyDoThoiViec.TabIndex = 8;
            // 
            // lblCanhBao
            // 
            this.lblCanhBao.AutoSize = true;
            this.lblCanhBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhBao.Location = new System.Drawing.Point(50, 100);
            this.lblCanhBao.Name = "lblCanhBao";
            this.lblCanhBao.Size = new System.Drawing.Size(98, 20);
            this.lblCanhBao.TabIndex = 7;
            this.lblCanhBao.Text = "labelcontext";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chú ý !";
            // 
            // FormCanhBaoXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 724);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtLyDoThoiViec);
            this.Controls.Add(this.lblCanhBao);
            this.Controls.Add(this.label1);
            this.Name = "FormCanhBaoXoa";
            this.Text = "FormCanhBaoXoa";
            this.Load += new System.EventHandler(this.FormCanhBaoXoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChapNhan;
        private System.Windows.Forms.TextBox txtLyDoThoiViec;
        private System.Windows.Forms.Label lblCanhBao;
        private System.Windows.Forms.Label label1;
    }
}