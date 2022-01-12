using System.Management;

namespace CourseWork.Classes.Memory
{
    public class MemoryGeneralInfo
    {
        public ManagementObjectSearcher PhysicalMemoryManage { get; set; }
        public ManagementObjectSearcher OperatingSystemManage { get; set; }

        public void GetGeneralInfo()
        {
            PhysicalMemoryManage = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

            OperatingSystemManage = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
        }
    }
}
