using OpenHardwareMonitor.Hardware;
using System.Management;

namespace CourseWork.Classes.Voltage
{
    public class VoltageGeneralInfo
    {
        private Computer ThisComputer;
        public IHardware CPUCoresPower { get; set; }
        public ManagementObjectCollection BatteryVoltageManager { get; set; }

        public void GetGeneralInfo()
        {
            ManagementObjectSearcher batteryVoltageManager = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Battery  ");
            BatteryVoltageManager = batteryVoltageManager.Get();
            ThisComputer = new Computer();
            ThisComputer.CPUEnabled = true;
            ThisComputer.Open();
            CPUCoresPower = ThisComputer.Hardware[0];
        }
    }
}
