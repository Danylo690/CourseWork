using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Management;

namespace CourseWork.Classes.CPU
{
    public class CPUGeneralInfo
    {
        private Computer ThisComputer { get; set; }

        public IHardware CPUTemperature { get; set; }

        public PerformanceCounter UsageCounter { get; set; }

        public PerformanceCounter CpuBaseSpeed { get; set; }

        public PerformanceCounter CpuSpeed { get; set; }

        public PerformanceCounterCategory CpuProcesses { get; set; }

        public PerformanceCounterCategory CpuThreads { get; set; }

        public ManagementObjectCollection CacheManager { get; set; }

        public ManagementObjectCollection ProcessorManager { get; set; }

        public void GetGeneralInfo()
        {
            ThisComputer = new Computer();
            ThisComputer.CPUEnabled = true;
            ThisComputer.Open();
            CPUTemperature = ThisComputer.Hardware[0];

            UsageCounter = new PerformanceCounter("Processor", "% Idle Time", @"_Total");

            CpuBaseSpeed = new PerformanceCounter("Processor Information", "Processor Frequency", "_Total");

            CpuSpeed = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");

            CpuProcesses = new PerformanceCounterCategory("Process");

            CpuThreads = new PerformanceCounterCategory("Thread");

            ManagementObjectSearcher cpuManager = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            ProcessorManager = cpuManager.Get();

            ManagementObjectSearcher cacheManager = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CacheMemory");
            CacheManager = cacheManager.Get();
        }
    }
}
