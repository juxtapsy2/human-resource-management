namespace QLNS_ADO.NET
{
    partial class FormReportTongQuanNV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tONGQUANNVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_QLNS = new QLNS_ADO.NET.DataSet_QLNS();
            this.tONGQUANNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tONGQUANNVTableAdapter = new QLNS_ADO.NET.DataSet_QLNSTableAdapters.TONGQUANNVTableAdapter();
            this.txtTongQuanMaNV = new System.Windows.Forms.TextBox();
            this.btnFindTQMaNV = new System.Windows.Forms.Button();
            this.btnBackTQNV = new System.Windows.Forms.Button();
            this.btnThongKeNhanLuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tONGQUANNVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QLNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGQUANNVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tONGQUANNVBindingSource1
            // 
            this.tONGQUANNVBindingSource1.DataMember = "TONGQUANNV";
            this.tONGQUANNVBindingSource1.DataSource = this.dataSet_QLNS;
            // 
            // dataSet_QLNS
            // 
            this.dataSet_QLNS.DataSetName = "DataSet_QLNS";
            this.dataSet_QLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tONGQUANNVBindingSource
            // 
            this.tONGQUANNVBindingSource.DataMember = "TONGQUANNV";
            this.tONGQUANNVBindingSource.DataSource = this.dataSet_QLNS;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet_QLNS";
            reportDataSource2.Value = this.tONGQUANNVBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS_ADO.NET.Reports.ReportTongQuanNV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1129, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // tONGQUANNVTableAdapter
            // 
            this.tONGQUANNVTableAdapter.ClearBeforeFill = true;
            // 
            // txtTongQuanMaNV
            // 
            this.txtTongQuanMaNV.Location = new System.Drawing.Point(139, 21);
            this.txtTongQuanMaNV.Name = "txtTongQuanMaNV";
            this.txtTongQuanMaNV.Size = new System.Drawing.Size(147, 22);
            this.txtTongQuanMaNV.TabIndex = 1;
            // 
            // btnFindTQMaNV
            // 
            this.btnFindTQMaNV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFindTQMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindTQMaNV.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindTQMaNV.Location = new System.Drawing.Point(301, 14);
            this.btnFindTQMaNV.Name = "btnFindTQMaNV";
            this.btnFindTQMaNV.Size = new System.Drawing.Size(81, 36);
            this.btnFindTQMaNV.TabIndex = 2;
            this.btnFindTQMaNV.Text = "Tìm";
            this.btnFindTQMaNV.UseVisualStyleBackColor = false;
            this.btnFindTQMaNV.Click += new System.EventHandler(this.btnFindTQMaNV_Click);
            // 
            // btnBackTQNV
            // 
            this.btnBackTQNV.BackColor = System.Drawing.Color.LightCoral;
            this.btnBackTQNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackTQNV.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTQNV.Location = new System.Drawing.Point(402, 14);
            this.btnBackTQNV.Name = "btnBackTQNV";
            this.btnBackTQNV.Size = new System.Drawing.Size(112, 36);
            this.btnBackTQNV.TabIndex = 2;
            this.btnBackTQNV.Text = "Quay lại";
            this.btnBackTQNV.UseVisualStyleBackColor = false;
            this.btnBackTQNV.Click += new System.EventHandler(this.btnBackTQNV_Click);
            // 
            // btnThongKeNhanLuc
            // 
            this.btnThongKeNhanLuc.BackColor = System.Drawing.Color.Yellow;
            this.btnThongKeNhanLuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKeNhanLuc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNhanLuc.Location = new System.Drawing.Point(747, 14);
            this.btnThongKeNhanLuc.Name = "btnThongKeNhanLuc";
            this.btnThongKeNhanLuc.Size = new System.Drawing.Size(180, 36);
            this.btnThongKeNhanLuc.TabIndex = 2;
            this.btnThongKeNhanLuc.Text = "Thống kê nhân lực";
            this.btnThongKeNhanLuc.UseVisualStyleBackColor = false;
            this.btnThongKeNhanLuc.Click += new System.EventHandler(this.btnThongKeNhanLuc_Click);
            // 
            // FormReportTongQuanNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1131, 600);
            this.Controls.Add(this.btnBackTQNV);
            this.Controls.Add(this.btnThongKeNhanLuc);
            this.Controls.Add(this.btnFindTQMaNV);
            this.Controls.Add(this.txtTongQuanMaNV);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportTongQuanNV";
            this.Text = "Tổng Quan Nhân Sự";
            this.Load += new System.EventHandler(this.FormReportTongQuanNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tONGQUANNVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QLNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGQUANNVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_QLNS dataSet_QLNS;
        private System.Windows.Forms.BindingSource tONGQUANNVBindingSource;
        private DataSet_QLNSTableAdapters.TONGQUANNVTableAdapter tONGQUANNVTableAdapter;
        private System.Windows.Forms.TextBox txtTongQuanMaNV;
        private System.Windows.Forms.Button btnFindTQMaNV;
        private System.Windows.Forms.Button btnBackTQNV;
        private System.Windows.Forms.BindingSource tONGQUANNVBindingSource1;
        private System.Windows.Forms.Button btnThongKeNhanLuc;
    }
}