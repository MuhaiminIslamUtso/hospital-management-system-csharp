namespace Hospital_Management_System
{
    partial class AmountBarChart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbBAck = new System.Windows.Forms.Button();
            this.btnExportChart = new System.Windows.Forms.Button();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.chartAmount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbBAck);
            this.panel1.Controls.Add(this.btnExportChart);
            this.panel1.Controls.Add(this.cmbChartType);
            this.panel1.Controls.Add(this.lblProfit);
            this.panel1.Controls.Add(this.chartAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 677);
            this.panel1.TabIndex = 0;
            // 
            // btnAbBAck
            // 
            this.btnAbBAck.BackColor = System.Drawing.Color.Thistle;
            this.btnAbBAck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbBAck.Location = new System.Drawing.Point(858, 89);
            this.btnAbBAck.Name = "btnAbBAck";
            this.btnAbBAck.Size = new System.Drawing.Size(95, 50);
            this.btnAbBAck.TabIndex = 4;
            this.btnAbBAck.Text = "Back";
            this.btnAbBAck.UseVisualStyleBackColor = false;
            this.btnAbBAck.Click += new System.EventHandler(this.btnAbBAck_Click);
            // 
            // btnExportChart
            // 
            this.btnExportChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportChart.ForeColor = System.Drawing.Color.Coral;
            this.btnExportChart.Location = new System.Drawing.Point(520, 99);
            this.btnExportChart.Name = "btnExportChart";
            this.btnExportChart.Size = new System.Drawing.Size(234, 40);
            this.btnExportChart.TabIndex = 3;
            this.btnExportChart.Text = "SAVE AS IMAGE";
            this.btnExportChart.UseVisualStyleBackColor = true;
            this.btnExportChart.Click += new System.EventHandler(this.btnExportChart_Click_1);
            // 
            // cmbChartType
            // 
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Location = new System.Drawing.Point(12, 22);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(109, 28);
            this.cmbChartType.TabIndex = 2;
            this.cmbChartType.SelectedIndexChanged += new System.EventHandler(this.cmbCharType_SelectedIndexChanged);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(194, 50);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(123, 49);
            this.lblProfit.TabIndex = 1;
            this.lblProfit.Text = "label1";
            this.lblProfit.Click += new System.EventHandler(this.lblProfit_Click);
            // 
            // chartAmount
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAmount.ChartAreas.Add(chartArea1);
            this.chartAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartAmount.Legends.Add(legend1);
            this.chartAmount.Location = new System.Drawing.Point(0, 145);
            this.chartAmount.Name = "chartAmount";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAmount.Series.Add(series1);
            this.chartAmount.Size = new System.Drawing.Size(965, 532);
            this.chartAmount.TabIndex = 0;
            this.chartAmount.Text = "chart1";
            // 
            // AmountBarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 677);
            this.Controls.Add(this.panel1);
            this.Name = "AmountBarChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AmountBarChart";
            this.Load += new System.EventHandler(this.AmountBarChart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmount;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Button btnExportChart;
        private System.Windows.Forms.Button btnAbBAck;
    }
}