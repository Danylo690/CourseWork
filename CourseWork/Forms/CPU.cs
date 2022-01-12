using CourseWork.Classes.Limit;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork.Forms
{
    public partial class CPU : Form
    {
        #region Fields
        public Classes.CPU.CPU CPUInfo { get; set; }

        private int _currentIndex = 0;

        public bool IsClosed { get; set; }
        #endregion

        #region Constructor
        public CPU()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void ChartCustomization(Chart chart)
        {
            Color axisColor = Color.FromArgb(100, 100, 100);
            Color gridColor = Color.FromArgb(200, 200, 200);
            Color lineColor = Color.FromArgb(150, 33, 150, 243);

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
            chart.ChartAreas[0].AxisY.Maximum = 100;

            chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            chart.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;

            for (int i = 0; i < 60; i++)
            {
                chart.Series[0].Points.AddY(0);
            }
        }

        private async void CPU_Shown(object sender, System.EventArgs e)
        {
            ChartCustomization(chartTemperature);
            ChartCustomization(chartUsage);
            while (!IsClosed)
            {
                await Task.Run(() => CPUInfo.GetCpuInfo());

                if (LimitValues.CountCPUTemperatureHits >= 5)
                {
                    labelTemperatureName.ForeColor = Color.Red;
                    labelTemperatureName.Text = "Temperature (Critical)";
                    labelTemperature.ForeColor = Color.Red;
                }
                else
                {
                    labelTemperatureName.ForeColor = Color.Black;
                    labelTemperature.ForeColor = Color.Black;
                }

                if (LimitValues.CountCPUUsageHits >= 5)
                {
                    labelUsageName.ForeColor = Color.Red;
                    labelUsageName.Text = "Usage (Critical)";
                    labelUsage.ForeColor = Color.Red;
                }
                else
                {
                    labelUsageName.ForeColor = Color.Black;
                    labelUsage.ForeColor = Color.Black;
                }

                labelCPUName.Text = CPUInfo.Name;
                labelTemperature.Text = CPUInfo.Temperature.ToString() + "°C";
                labelUsage.Text = CPUInfo.Usage.ToString() + "%";
                labelBaseSpeed.Text = CPUInfo.MaxFrequency.ToString() + " GGz";
                labelSpeed.Text = CPUInfo.Frequency.ToString() + " GGz";
                labelCacheL1.Text = CPUInfo.L1Size.ToString() + " Kb";
                labelCacheL2.Text = CPUInfo.L2Size.ToString() + " Kb";
                labelCacheL3.Text = CPUInfo.L3Size.ToString() + " Kb";
                labelNumberCores.Text = CPUInfo.Cores.ToString();
                labelNumberLogicalProcessor.Text = CPUInfo.LogProc.ToString();
                labelVirtualization.Text = CPUInfo.Virtulalication.ToString();
                labelSockets.Text = CPUInfo.SocketCount.ToString();
                labelProcesses.Text = CPUInfo.ProcessesCount.ToString();
                labelThreads.Text = CPUInfo.ThreadsCount.ToString();

                if (!IsClosed)
                {
                    //For temperature
                    chartTemperature.Series[0].Points.AddY(CPUInfo.Temperature);
                    chartTemperature.Series[0].Points.RemoveAt(0);
                    chartTemperature.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -_currentIndex;

                    //For usage
                    chartUsage.Series[0].Points.AddY(CPUInfo.Usage);
                    chartUsage.Series[0].Points.RemoveAt(0);
                    chartUsage.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -_currentIndex;

                    _currentIndex++;
                    _currentIndex %= (int)chartTemperature.ChartAreas[0].AxisX.MajorGrid.Interval;
                }
            }
        }
        #endregion
    }
}
