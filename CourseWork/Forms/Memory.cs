using CourseWork.Classes.Limit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork.Forms
{
    public partial class Memory : Form
    {
        #region Fields
        public Classes.Memory.Memory MemoryInfo { get; set; }

        private int _currentIndex = 0;

        public bool IsClosed { get; set; }
        #endregion

        #region Contructor
        public Memory()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void ChartCustomization(Chart chart)
        {
            Color axisColor = Color.FromArgb(100, 100, 100);
            Color gridColor = Color.FromArgb(200, 200, 200);
            Color lineColor = Color.FromArgb(150, 255, 152, 0);

            chart.Series[0].Color = lineColor;

            chart.ChartAreas[0].BorderWidth = 1;
            chart.ChartAreas[0].BorderColor = axisColor;
            chart.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;

            chart.ChartAreas[0].AxisX.LineColor = axisColor;
            chart.ChartAreas[0].AxisY.LineColor = axisColor;

            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = gridColor;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = gridColor;

            chart.ChartAreas[0].AxisX.MajorGrid.Interval = 10;
            chart.ChartAreas[0].AxisY.MajorGrid.Interval = 10;

            // 60 seconds interval.
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 60;

            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = MemoryInfo.MemoryVisibleCapacity;

            chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            chart.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;

            for (int i = 0; i < 60; i++)
            {
                chart.Series[0].Points.AddY(0);
            }
        }

        private async void Memory_Shown(object sender, EventArgs e)
        {
            ChartCustomization(chartUsage);
            while (!IsClosed)
            {
                await Task.Run(() => MemoryInfo.GetMemoryInfo());

                if (LimitValues.CountMemoryUsageHits >= 5)
                {
                    labelUsageName.Text = "Used memory (Critical)";
                    labelUsageName.ForeColor = Color.Red;
                    labelUsed.ForeColor = Color.Red;
                }
                else
                {
                    labelUsageName.Text = "Used memory";
                    labelUsageName.ForeColor = Color.Black;
                    labelUsed.ForeColor = Color.Black;
                }

                labelUsed.Text = MemoryInfo.MemoryUsage.ToString() + " Gb";
                labelFree.Text = MemoryInfo.FreeMemory.ToString() + " Gb";
                labelTotal.Text = MemoryInfo.MemoryCapacity.ToString() + " / " + MemoryInfo.MemoryVisibleCapacity.ToString() + " Gb";
                labelSpeed.Text = MemoryInfo.MemorySpeed.ToString() + " MGz";

                labelUsedVirtual.Text = MemoryInfo.UsedVirtualMemory.ToString() + " Gb";
                labelFreeVirtual.Text = MemoryInfo.FreeVirtualMemory.ToString() + " Gb";
                labelTotalVirtual.Text = MemoryInfo.VirtualMemoryCapacity.ToString() + " Gb";

                var tempString = "";
                foreach (var item in MemoryInfo.MemoryManufacturers)
                {
                    tempString += $"{item}\n";
                }
                labelManufacturer.Text = tempString;

                if (!IsClosed)
                {
                    //For memory usage
                    chartUsage.Series[0].Points.AddY(MemoryInfo.MemoryUsage);
                    chartUsage.Series[0].Points.RemoveAt(0);
                    chartUsage.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -_currentIndex;

                    _currentIndex++;
                    _currentIndex %= (int)chartUsage.ChartAreas[0].AxisX.MajorGrid.Interval;
                }
            }
        }
        #endregion
    }
}
