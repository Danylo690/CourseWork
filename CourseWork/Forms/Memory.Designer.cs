
namespace CourseWork.Forms
{
    partial class Memory
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.chartUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelUsageName = new System.Windows.Forms.Label();
            this.labelUsed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFree = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFreeVirtual = new System.Windows.Forms.Label();
            this.labelTotalVirtual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelUsedVirtual = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(547, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed ";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(546, 283);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(92, 20);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Calculating";
            // 
            // chartUsage
            // 
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 85F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.Y = 15F;
            this.chartUsage.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUsage.Legends.Add(legend1);
            this.chartUsage.Location = new System.Drawing.Point(12, 12);
            this.chartUsage.Name = "chartUsage";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Memory usage";
            this.chartUsage.Series.Add(series1);
            this.chartUsage.Size = new System.Drawing.Size(760, 236);
            this.chartUsage.TabIndex = 2;
            this.chartUsage.Text = "chart1";
            // 
            // labelUsageName
            // 
            this.labelUsageName.AutoSize = true;
            this.labelUsageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsageName.Location = new System.Drawing.Point(12, 263);
            this.labelUsageName.Name = "labelUsageName";
            this.labelUsageName.Size = new System.Drawing.Size(113, 20);
            this.labelUsageName.TabIndex = 0;
            this.labelUsageName.Text = "Used memory";
            // 
            // labelUsed
            // 
            this.labelUsed.AutoSize = true;
            this.labelUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsed.Location = new System.Drawing.Point(11, 283);
            this.labelUsed.Name = "labelUsed";
            this.labelUsed.Size = new System.Drawing.Size(132, 29);
            this.labelUsed.TabIndex = 1;
            this.labelUsed.Text = "Calculating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Free memory";
            // 
            // labelFree
            // 
            this.labelFree.AutoSize = true;
            this.labelFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFree.Location = new System.Drawing.Point(11, 354);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(132, 29);
            this.labelFree.TabIndex = 1;
            this.labelFree.Text = "Calculating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total memory";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(12, 425);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(132, 29);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Calculating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(255, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Free virtual memory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(256, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total virtual memory";
            // 
            // labelFreeVirtual
            // 
            this.labelFreeVirtual.AutoSize = true;
            this.labelFreeVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFreeVirtual.Location = new System.Drawing.Point(254, 354);
            this.labelFreeVirtual.Name = "labelFreeVirtual";
            this.labelFreeVirtual.Size = new System.Drawing.Size(132, 29);
            this.labelFreeVirtual.TabIndex = 1;
            this.labelFreeVirtual.Text = "Calculating";
            // 
            // labelTotalVirtual
            // 
            this.labelTotalVirtual.AutoSize = true;
            this.labelTotalVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalVirtual.Location = new System.Drawing.Point(255, 425);
            this.labelTotalVirtual.Name = "labelTotalVirtual";
            this.labelTotalVirtual.Size = new System.Drawing.Size(132, 29);
            this.labelTotalVirtual.TabIndex = 1;
            this.labelTotalVirtual.Text = "Calculating";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(256, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Used virtual memory";
            // 
            // labelUsedVirtual
            // 
            this.labelUsedVirtual.AutoSize = true;
            this.labelUsedVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsedVirtual.Location = new System.Drawing.Point(255, 283);
            this.labelUsedVirtual.Name = "labelUsedVirtual";
            this.labelUsedVirtual.Size = new System.Drawing.Size(132, 29);
            this.labelUsedVirtual.TabIndex = 1;
            this.labelUsedVirtual.Text = "Calculating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(547, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manufacturer of memories";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(546, 333);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(92, 20);
            this.labelManufacturer.TabIndex = 1;
            this.labelManufacturer.Text = "Calculating";
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(101F, 101F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.chartUsage);
            this.Controls.Add(this.labelTotalVirtual);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelFreeVirtual);
            this.Controls.Add(this.labelFree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelUsedVirtual);
            this.Controls.Add(this.labelUsed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelUsageName);
            this.Controls.Add(this.label1);
            this.Name = "Memory";
            this.Text = "Memory";
            this.Shown += new System.EventHandler(this.Memory_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsage;
        private System.Windows.Forms.Label labelUsageName;
        private System.Windows.Forms.Label labelUsed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFreeVirtual;
        private System.Windows.Forms.Label labelTotalVirtual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelUsedVirtual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelManufacturer;
    }
}