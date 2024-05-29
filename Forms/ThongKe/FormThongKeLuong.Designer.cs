namespace QLNS_ADO.NET
{
    partial class FormThongKeLuong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "6,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "8,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 9D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 12D);
            this.chartLuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDonViLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLuong
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLuong.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLuong.Legends.Add(legend2);
            this.chartLuong.Location = new System.Drawing.Point(4, 1);
            this.chartLuong.Name = "chartLuong";
            this.chartLuong.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Thu nhập NV";
            dataPoint11.AxisLabel = "NV01";
            dataPoint12.AxisLabel = "NV02";
            dataPoint13.AxisLabel = "NV03";
            dataPoint14.AxisLabel = "NV04";
            dataPoint15.AxisLabel = "NV05";
            dataPoint16.AxisLabel = "NV06";
            dataPoint17.AxisLabel = "NV07";
            dataPoint18.AxisLabel = "NV08";
            dataPoint19.AxisLabel = "NV09";
            dataPoint20.AxisLabel = "NV10";
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            series2.Points.Add(dataPoint19);
            series2.Points.Add(dataPoint20);
            series2.YValuesPerPoint = 2;
            this.chartLuong.Series.Add(series2);
            this.chartLuong.Size = new System.Drawing.Size(790, 448);
            this.chartLuong.TabIndex = 0;
            this.chartLuong.Text = "Lương NV";
            // 
            // lblDonViLuong
            // 
            this.lblDonViLuong.AutoSize = true;
            this.lblDonViLuong.Location = new System.Drawing.Point(639, 52);
            this.lblDonViLuong.Name = "lblDonViLuong";
            this.lblDonViLuong.Size = new System.Drawing.Size(115, 16);
            this.lblDonViLuong.TabIndex = 1;
            this.lblDonViLuong.Text = "Đơn vị: Triệu đồng";
            // 
            // FormThongKeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDonViLuong);
            this.Controls.Add(this.chartLuong);
            this.Name = "FormThongKeLuong";
            this.Text = "Thống Kê Thu Nhập Cơ Bản";
            this.Load += new System.EventHandler(this.FormThongKeLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLuong;
        private System.Windows.Forms.Label lblDonViLuong;
    }
}