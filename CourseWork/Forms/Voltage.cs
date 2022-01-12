using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class Voltage : Form
    {
        #region Fields
        public Classes.Voltage.Voltage VoltageInfo { get; set; }
        public bool IsClosed { get; set; }

        #endregion

        #region Constructor
        public Voltage()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private async void Voltage_Shown(object sender, EventArgs e)
        {
            while (!IsClosed)
            {
                await Task.Run(() => VoltageInfo.GetVoltageInfo());
                labelBatteryVoltage.Text = VoltageInfo.BatteryVoltage.ToString() + " V";

                var tempString = "";
                for (int i = 0; i < VoltageInfo.CPUCoresVoltage.Count(); i++)
                {
                    tempString += ($"Core #{i + 1}: {Math.Round(VoltageInfo.CPUCoresVoltage[i], 3)} V\n");
                }
                labelCoresVoltage.Text = tempString;
                if (VoltageInfo.CPUCoresVoltage.Count() == 0)
                {
                    labelCoresVoltage.Text = "Data not found";
                }
                VoltageInfo.CPUCoresVoltage.Clear();

                labelCPUPower.Text = VoltageInfo.CPUPower.ToString() + " W";
                if (VoltageInfo.CPUPower == 0)
                {
                    labelCPUPower.Text = "Data not found";
                }

                tempString = "";
                for (int i = 0; i < VoltageInfo.CPUCoresPower.Count(); i++)
                {
                    tempString += ($"Core #{i + 1}: {Math.Round(VoltageInfo.CPUCoresPower[i], 1)} W\n");
                }
                labelCPUCorePower.Text = tempString;
                if (VoltageInfo.CPUCoresPower.Count() == 0)
                {
                    labelCoresVoltage.Text = "Data not found";
                }
            }
        }
        #endregion
    }
}
