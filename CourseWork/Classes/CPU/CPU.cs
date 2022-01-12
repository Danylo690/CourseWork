using CourseWork.Classes.Limit;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace CourseWork.Classes.CPU
{
    public class CPU
    {
        private readonly CPUGeneralInfo _cpuGeneralInfo;
        public string Name { get; set; }

        public double Usage { get; set; }

        public double Temperature { get; set; }

        public double Frequency { get; set; }

        public double MaxFrequency { get; set; }

        public uint L1Size { get; set; }

        public uint L2Size { get; set; }

        public uint L3Size { get; set; }

        public int Cores { get; set; }

        public int LogProc { get; set; }

        public bool Virtulalication { get; set; }

        public int SocketCount { get; set; }

        public int ProcessesCount { get; set; }

        public int ThreadsCount { get; set; }

        public List<CPULog> CPULogs { get; set; }

        public CPU()
        {
            CPULogs = new List<CPULog>();
            var json = new DataContractJsonSerializer(CPULogs.GetType());
            try
            {
                using (FileStream file = new FileStream("CPU.json", FileMode.Open))
                {
                    CPULogs = (List<CPULog>)json.ReadObject(file);
                }
            }
            catch (FileNotFoundException)
            {

            }

            _cpuGeneralInfo = new CPUGeneralInfo();
            _cpuGeneralInfo.GetGeneralInfo();

            //Name, number of cores, number of logical processors, virtualization
            foreach (ManagementObject item in _cpuGeneralInfo.ProcessorManager)
            {
                Name = item["Name"].ToString();
                Cores = Convert.ToInt32(item["NumberOfCores"]);
                LogProc = Convert.ToInt32(item["NumberOfLogicalProcessors"]);
                Virtulalication = Convert.ToBoolean(item["VirtualizationFirmwareEnabled"]);
            }

            //Base frequency
            MaxFrequency = Math.Round((_cpuGeneralInfo.CpuBaseSpeed.NextValue() / 1000), 2);

            //Cache levels size
            List<uint> cacheSizes = new List<uint>(_cpuGeneralInfo.CacheManager.Count);
            cacheSizes.AddRange(_cpuGeneralInfo.CacheManager
              .Cast<ManagementObject>()
              .Select(p => (uint)(p.Properties["MaxCacheSize"].Value)));
            L1Size = cacheSizes[0];
            L2Size = cacheSizes[1];
            L3Size = cacheSizes[2];

            //Socket count
            SocketCount = _cpuGeneralInfo.ProcessorManager
                .Cast<ManagementObject>()
                .Select(p => p.Properties["SocketDesignation"].Value)
                .Count();
        }

        public void GetCpuInfo()
        {
            //Temperature
            _cpuGeneralInfo.CPUTemperature.Update();
            foreach (ISensor item in _cpuGeneralInfo.CPUTemperature.Sensors)
            {
                if (item.SensorType == SensorType.Temperature)
                {
                    Temperature = Math.Round(Convert.ToDouble(item.Value), 1);
                    break;
                }
            }

            //Usage
            Usage = Math.Round((100 - _cpuGeneralInfo.UsageCounter.NextValue()), 1);

            //Frequency
            Frequency = Math.Round(((_cpuGeneralInfo.CpuSpeed.NextValue() * MaxFrequency) / 100), 2);

            //Processes
            ProcessesCount = _cpuGeneralInfo.CpuProcesses.GetInstanceNames().Count();

            //Threads
            ThreadsCount = _cpuGeneralInfo.CpuThreads.GetInstanceNames().Count();

            if (Temperature > LimitValues.LimitTemperatureCPU - 5)
            {
                if (LimitValues.CountCPUTemperatureHits < 5)
                {
                    LimitValues.CountCPUTemperatureHits++;
                }
            }
            else if (LimitValues.CountCPUTemperatureHits > 0)
            {
                LimitValues.CountCPUTemperatureHits--;
            }

            if (Usage > LimitValues.LimitCPUUsage - 5)
            {
                if (LimitValues.CountCPUUsageHits < 5)
                {
                    LimitValues.CountCPUUsageHits++;
                }
            }
            else if (LimitValues.CountCPUUsageHits > 0)
            {
                LimitValues.CountCPUUsageHits--;
            }

            CPULogs.Add(new CPULog() { Date = DateTime.Now, Temperature = Temperature, Usage = Usage });
            var json = new DataContractJsonSerializer(CPULogs.GetType());
            using (FileStream file = new FileStream("CPU.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(file, CPULogs);
            }

            Thread.Sleep(1000);
        }
    }
}
