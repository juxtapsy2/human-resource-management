namespace QLNS_EntityFramework.Forms.ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, "6,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "8,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, "7,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, "9,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, "6,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, "10,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, "10,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, "12,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, "15,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, "12,0");
            this.chartLuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDonViLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLuong
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLuong.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLuong.Legends.Add(legend1);
            this.chartLuong.Location = new System.Drawing.Point(4, 1);
            this.chartLuong.Name = "chartLuong";
            this.chartLuong.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Thu nhập NV";
            dataPoint1.AxisLabel = "NV01";
            dataPoint2.AxisLabel = "NV02";
            dataPoint3.AxisLabel = "NV03";
            dataPoint4.AxisLabel = "NV04";
            dataPoint5.AxisLabel = "NV05";
            dataPoint6.AxisLabel = "NV06";
            dataPoint7.AxisLabel = "NV07";
            dataPoint8.AxisLabel = "NV08";
            dataPoint9.AxisLabel = "NV09";
            dataPoint10.AxisLabel = "NV10";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.YValuesPerPoint = 2;
            this.chartLuong.Series.Add(series1);
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