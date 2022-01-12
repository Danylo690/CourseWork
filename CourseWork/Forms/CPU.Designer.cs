
namespace CourseWork.Forms
{
    partial class CPU
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTemperature = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelUsageName = new System.Windows.Forms.Label();
            this.labelCPUName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTemperatureName = new System.Windows.Forms.Label();
            this.chartUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelVirtualization = new System.Windows.Forms.Label();
            this.labelSockets = new System.Windows.Forms.Label();
            this.labelNumberLogicalProcessor = new System.Windows.Forms.Label();
            this.labelNumberCores = new System.Windows.Forms.Label();
            this.labelCacheL1 = new System.Windows.Forms.Label();
            this.labelCacheL3 = new System.Windows.Forms.Label();
            this.labelUsage = new System.Windows.Forms.Label();
            this.labelCacheL2 = new System.Windows.Forms.Label();
            this.labelThreads = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelProcesses = new System.Windows.Forms.Label();
            this.labelBaseSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.panelTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperature.Location = new System.Drawing.Point(7, 289);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(122, 26);
            this.labelTemperature.TabIndex = 0;
            this.labelTemperature.Text = "Calculating";
            // 
            // chartTemperature
            // 
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 85F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.Y = 15F;
            this.chartTemperature.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend1);
            this.chartTemperature.Location = new System.Drawing.Point(12, 30);
            this.chartTemperature.Name = "chartTemperature";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPU temperature";
            this.chartTemperature.Series.Add(series1);
            this.chartTemperature.Size = new System.Drawing.Size(383, 236);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "chart1";
            // 
            // panelTemperature
            // 
            this.panelTemperature.Controls.Add(this.label12);
            this.panelTemperature.Controls.Add(this.label10);
            this.panelTemperature.Controls.Add(this.label8);
            this.panelTemperature.Controls.Add(this.label5);
            this.panelTemperature.Controls.Add(this.label18);
            this.panelTemperature.Controls.Add(this.labelUsageName);
            this.panelTemperature.Controls.Add(this.labelCPUName);
            this.panelTemperature.Controls.Add(this.label17);
            this.panelTemperature.Controls.Add(this.label6);
            this.panelTemperature.Controls.Add(this.label16);
            this.panelTemperature.Controls.Add(this.label4);
            this.panelTemperature.Controls.Add(this.label11);
            this.panelTemperature.Controls.Add(this.label7);
            this.panelTemperature.Controls.Add(this.labelTemperatureName);
            this.panelTemperature.Controls.Add(this.chartUsage);
            this.panelTemperature.Controls.Add(this.chartTemperature);
            this.panelTemperature.Controls.Add(this.labelVirtualization);
            this.panelTemperature.Controls.Add(this.labelSockets);
            this.panelTemperature.Controls.Add(this.labelNumberLogicalProcessor);
            this.panelTemperature.Controls.Add(this.labelNumberCores);
            this.panelTemperature.Controls.Add(this.labelCacheL1);
            this.panelTemperature.Controls.Add(this.labelCacheL3);
            this.panelTemperature.Controls.Add(this.labelUsage);
            this.panelTemperature.Controls.Add(this.labelCacheL2);
            this.panelTemperature.Controls.Add(this.labelThreads);
            this.panelTemperature.Controls.Add(this.labelSpeed);
            this.panelTemperature.Controls.Add(this.labelProcesses);
            this.panelTemperature.Controls.Add(this.labelBaseSpeed);
            this.panelTemperature.Controls.Add(this.labelTemperature);
            this.panelTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemperature.Location = new System.Drawing.Point(0, 0);
            this.panelTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.panelTemperature.Name = "panelTemperature";
            this.panelTemperature.Size = new System.Drawing.Size(784, 480);
            this.panelTemperature.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Virtualization";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sockets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(185, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Number of logical processors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of cores";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(623, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 22);
            this.label18.TabIndex = 2;
            this.label18.Text = "Cache L1";
            // 
            // labelUsageName
            // 
            this.labelUsageName.AutoSize = true;
            this.labelUsageName.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsageName.Location = new System.Drawing.Point(385, 267);
            this.labelUsageName.Name = "labelUsageName";
            this.labelUsageName.Size = new System.Drawing.Size(57, 22);
            this.labelUsageName.TabIndex = 2;
            this.labelUsageName.Text = "Usage";
            // 
            // labelCPUName
            // 
            this.labelCPUName.AutoSize = true;
            this.labelCPUName.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUName.Location = new System.Drawing.Point(8, 10);
            this.labelCPUName.Name = "labelCPUName";
            this.labelCPUName.Size = new System.Drawing.Size(0, 22);
            this.labelCPUName.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(623, 401);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 2;
            this.label17.Text = "Cache L3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Speed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(623, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 22);
            this.label16.TabIndex = 2;
            this.label16.Text = "Cache L2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Base speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Threads";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Processes";
            // 
            // labelTemperatureName
            // 
            this.labelTemperatureName.AutoSize = true;
            this.labelTemperatureName.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureName.Location = new System.Drawing.Point(8, 267);
            this.labelTemperatureName.Name = "labelTemperatureName";
            this.labelTemperatureName.Size = new System.Drawing.Size(108, 22);
            this.labelTemperatureName.TabIndex = 2;
            this.labelTemperatureName.Text = "Temperature";
            // 
            // chartUsage
            // 
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 85F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.Y = 15F;
            this.chartUsage.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartUsage.Legends.Add(legend2);
            this.chartUsage.Location = new System.Drawing.Point(389, 30);
            this.chartUsage.Name = "chartUsage";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "CPU usage";
            this.chartUsage.Series.Add(series2);
            this.chartUsage.Size = new System.Drawing.Size(383, 236);
            this.chartUsage.TabIndex = 1;
            this.chartUsage.Text = "chart1";
            // 
            // labelVirtualization
            // 
            this.labelVirtualization.AutoSize = true;
            this.labelVirtualization.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVirtualization.Location = new System.Drawing.Point(184, 430);
            this.labelVirtualization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVirtualization.Name = "labelVirtualization";
            this.labelVirtualization.Size = new System.Drawing.Size(89, 19);
            this.labelVirtualization.TabIndex = 0;
            this.labelVirtualization.Text = "Calculating";
            // 
            // labelSockets
            // 
            this.labelSockets.AutoSize = true;
            this.labelSockets.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSockets.Location = new System.Drawing.Point(184, 385);
            this.labelSockets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSockets.Name = "labelSockets";
            this.labelSockets.Size = new System.Drawing.Size(89, 19);
            this.labelSockets.TabIndex = 0;
            this.labelSockets.Text = "Calculating";
            // 
            // labelNumberLogicalProcessor
            // 
            this.labelNumberLogicalProcessor.AutoSize = true;
            this.labelNumberLogicalProcessor.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberLogicalProcessor.Location = new System.Drawing.Point(184, 337);
            this.labelNumberLogicalProcessor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberLogicalProcessor.Name = "labelNumberLogicalProcessor";
            this.labelNumberLogicalProcessor.Size = new System.Drawing.Size(89, 19);
            this.labelNumberLogicalProcessor.TabIndex = 0;
            this.labelNumberLogicalProcessor.Text = "Calculating";
            // 
            // labelNumberCores
            // 
            this.labelNumberCores.AutoSize = true;
            this.labelNumberCores.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberCores.Location = new System.Drawing.Point(184, 291);
            this.labelNumberCores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberCores.Name = "labelNumberCores";
            this.labelNumberCores.Size = new System.Drawing.Size(89, 19);
            this.labelNumberCores.TabIndex = 0;
            this.labelNumberCores.Text = "Calculating";
            // 
            // labelCacheL1
            // 
            this.labelCacheL1.AutoSize = true;
            this.labelCacheL1.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCacheL1.Location = new System.Drawing.Point(622, 291);
            this.labelCacheL1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCacheL1.Name = "labelCacheL1";
            this.labelCacheL1.Size = new System.Drawing.Size(122, 26);
            this.labelCacheL1.TabIndex = 0;
            this.labelCacheL1.Text = "Calculating";
            // 
            // labelCacheL3
            // 
            this.labelCacheL3.AutoSize = true;
            this.labelCacheL3.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCacheL3.Location = new System.Drawing.Point(622, 423);
            this.labelCacheL3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCacheL3.Name = "labelCacheL3";
            this.labelCacheL3.Size = new System.Drawing.Size(122, 26);
            this.labelCacheL3.TabIndex = 0;
            this.labelCacheL3.Text = "Calculating";
            // 
            // labelUsage
            // 
            this.labelUsage.AutoSize = true;
            this.labelUsage.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsage.Location = new System.Drawing.Point(384, 289);
            this.labelUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsage.Name = "labelUsage";
            this.labelUsage.Size = new System.Drawing.Size(122, 26);
            this.labelUsage.TabIndex = 0;
            this.labelUsage.Text = "Calculating";
            // 
            // labelCacheL2
            // 
            this.labelCacheL2.AutoSize = true;
            this.labelCacheL2.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCacheL2.Location = new System.Drawing.Point(622, 356);
            this.labelCacheL2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCacheL2.Name = "labelCacheL2";
            this.labelCacheL2.Size = new System.Drawing.Size(122, 26);
            this.labelCacheL2.TabIndex = 0;
            this.labelCacheL2.Text = "Calculating";
            // 
            // labelThreads
            // 
            this.labelThreads.AutoSize = true;
            this.labelThreads.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThreads.Location = new System.Drawing.Point(7, 425);
            this.labelThreads.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThreads.Name = "labelThreads";
            this.labelThreads.Size = new System.Drawing.Size(122, 26);
            this.labelThreads.TabIndex = 0;
            this.labelThreads.Text = "Calculating";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(384, 421);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(122, 26);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Calculating";
            // 
            // labelProcesses
            // 
            this.labelProcesses.AutoSize = true;
            this.labelProcesses.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcesses.Location = new System.Drawing.Point(7, 354);
            this.labelProcesses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProcesses.Name = "labelProcesses";
            this.labelProcesses.Size = new System.Drawing.Size(122, 26);
            this.labelProcesses.TabIndex = 0;
            this.labelProcesses.Text = "Calculating";
            // 
            // labelBaseSpeed
            // 
            this.labelBaseSpeed.AutoSize = true;
            this.labelBaseSpeed.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseSpeed.Location = new System.Drawing.Point(384, 354);
            this.labelBaseSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaseSpeed.Name = "labelBaseSpeed";
            this.labelBaseSpeed.Size = new System.Drawing.Size(122, 26);
            this.labelBaseSpeed.TabIndex = 0;
            this.labelBaseSpeed.Text = "Calculating";
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(101F, 101F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.panelTemperature);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CPU";
            this.Text = "CPU";
            this.Shown += new System.EventHandler(this.CPU_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.panelTemperature.ResumeLayout(false);
            this.panelTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Panel panelTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsage;
        private System.Windows.Forms.Label labelTemperatureName;
        private System.Windows.Forms.Label labelUsageName;
        private System.Windows.Forms.Label labelUsage;
        private System.Windows.Forms.Label labelCPUName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelBaseSpeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelVirtualization;
        private System.Windows.Forms.Label labelSockets;
        private System.Windows.Forms.Label labelNumberLogicalProcessor;
        private System.Windows.Forms.Label labelNumberCores;
        private System.Windows.Forms.Label labelCacheL1;
        private System.Windows.Forms.Label labelCacheL3;
        private System.Windows.Forms.Label labelCacheL2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelThreads;
        private System.Windows.Forms.Label labelProcesses;
    }
}