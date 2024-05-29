namespace QLNS_EntityFramework.Forms.ThongKe
{
    partial class FormThongKeNhanLuc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "2,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "1,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, "2,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, "2,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, "2,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, "1,0,0,0");
            this.chartNhanLuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChuThich = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanLuc)).BeginInit();
            this.SuspendLayout();
            // 
            // chartNhanLuc
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNhanLuc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNhanLuc.Legends.Add(legend1);
            this.chartNhanLuc.Location = new System.Drawing.Point(2, 3);
            this.chartNhanLuc.Name = "chartNhanLuc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Nhân lực";
            dataPoint1.AxisLabel = "DA01";
            dataPoint2.AxisLabel = "DA02";
            dataPoint3.AxisLabel = "DA03";
            dataPoint4.AxisLabel = "DA04";
            dataPoint5.AxisLabel = "DA05";
            dataPoint6.AxisLabel = "DA06";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.YValuesPerPoint = 4;
            this.chartNhanLuc.Series.Add(series1);
            this.chartNhanLuc.Size = new System.Drawing.Size(949, 480);
            this.chartNhanLuc.TabIndex = 0;
            this.chartNhanLuc.Text = "Nhân Lực";
            // 
            // lblChuThich
            // 
            this.lblChuThich.AutoSize = true;
            this.lblChuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuThich.Location = new System.Drawing.Point(780, 147);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(130, 16);
            this.lblChuThich.TabIndex = 1;
            this.lblChuThich.Text = "Chú thích: DA - Dự án";
            this.lblChuThich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThongKeNhanLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 485);
            this.Controls.Add(this.lblChuThich);
            this.Controls.Add(this.chartNhanLuc);
            this.Name = "FormThongKeNhanLuc";
            this.Text = "Thống Kê Nhân Lực Công Ty";
            this.Load += new System.EventHandler(this.FormThongKeNhanLuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanLuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhanLuc;
        private System.Windows.Forms.Label lblChuThich;
    }
}