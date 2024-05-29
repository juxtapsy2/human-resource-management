namespace QLNS_EntityFramework.Forms.Report
{
    partial class FormReportLuong
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lUONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_QLNS = new QLNS_EntityFramework.DataSet_QLNS();
            this.lUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lUONGTableAdapter = new QLNS_EntityFramework.DataSet_QLNSTableAdapters.LUONGTableAdapter();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.lUONGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QLNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lUONGBindingSource1
            // 
            this.lUONGBindingSource1.DataMember = "LUONG";
            this.lUONGBindingSource1.DataSource = this.dataSet_QLNS;
            // 
            // dataSet_QLNS
            // 
            this.dataSet_QLNS.DataSetName = "DataSet_QLNS";
            this.dataSet_QLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lUONGBindingSource
            // 
            this.lUONGBindingSource.DataMember = "LUONG";
            this.lUONGBindingSource.DataSource = this.dataSet_QLNS;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource4.Name = "DataSet_QLNS";
            reportDataSource4.Value = this.lUONGBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS_EntityFramework.Reports.ReportLuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1035, 664);
            this.reportViewer1.TabIndex = 0;
            // 
            // lUONGTableAdapter
            // 
            this.lUONGTableAdapter.ClearBeforeFill = true;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(241, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 35);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(122, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(339, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatistic.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.Location = new System.Drawing.Point(596, 19);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(81, 35);
            this.btnStatistic.TabIndex = 1;
            this.btnStatistic.Text = "Biểu đồ";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // lUONGBindingSource2
            // 
            this.lUONGBindingSource2.DataMember = "LUONG";
            this.lUONGBindingSource2.DataSource = this.dataSet_QLNS;
            // 
            // FormReportLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1040, 736);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportLuong";
            this.Text = "Bảng tính lương";
            this.Load += new System.EventHandler(this.FormReportLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QLNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_QLNS dataSet_QLNS;
        private DataSet_QLNSTableAdapters.LUONGTableAdapter lUONGTableAdapter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.BindingSource lUONGBindingSource;
        private System.Windows.Forms.BindingSource lUONGBindingSource1;
        private System.Windows.Forms.BindingSource lUONGBindingSource2;
    }
}