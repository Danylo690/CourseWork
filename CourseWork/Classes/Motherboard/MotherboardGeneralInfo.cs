using System.Management;

namespace CourseWork.Classes.Motherboard
{
    public class MotherboardGeneralInfo
    {
        public ManagementObjectCollection MotherboardManager { get; set; }

        public ManagementObjectCollection BiosManager { get; set; }

        public void GetGeneralInfo()
        {
            ManagementObjectSearcher motherboardManager = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            MotherboardManager = motherboardManager.Get();

            ManagementObjectSearcher biosManager = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            BiosManager = biosManager.Get();
        }
    }
}
