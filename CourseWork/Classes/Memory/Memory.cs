using CourseWork.Classes.Limit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CourseWork.Classes.Memory
{
    public class Memory
    {
        private MemoryGeneralInfo _memoryGeneralInfo;

        public double MemoryUsage { get; set; }

        public double MemoryCapacity { get; set; }

        public double MemoryVisibleCapacity { get; set; }

        public double FreeMemory { get; set; }

        public double MemorySpeed { get; set; }

        public double VirtualMemoryCapacity { get; set; }

        public double FreeVirtualMemory { get; set; }

        public double UsedVirtualMemory { get; set; }

        public List<string> MemoryManufacturers { get; set; }

        public List<MemoryLog> MemoryLogs { get; set; }

        public Memory()
        {
            MemoryLogs = new List<MemoryLog>();
            _memoryGeneralInfo = new MemoryGeneralInfo();
            var json = new DataContractJsonSerializer(MemoryLogs.GetType());
            try
            {
                using (FileStream file = new FileStream("Memory.json", FileMode.Open))
                {
                    MemoryLogs = (List<MemoryLog>)json.ReadObject(file);
                }
            }
            catch (FileNotFoundException)
            {

            }

            _memoryGeneralInfo.GetGeneralInfo();
            MemoryManufacturers = new List<string>();

            foreach (var item in _memoryGeneralInfo.PhysicalMemoryManage.Get())
            {
                MemoryCapacity += Convert.ToDouble(item["Capacity"]) / 1024.0f / 1024.0f / 1024.0f;
                MemorySpeed = Convert.ToDouble(item["ConfiguredClockSpeed"]);
                MemoryManufacturers.Add(item["Manufacturer"].ToString());
            }

            foreach (var item in _memoryGeneralInfo.OperatingSystemManage.Get())
            {
                MemoryVisibleCapacity = Math.Round(Convert.ToDouble(item["TotalVisibleMemorySize"]) / 1024.0f / 1024.0f, 1);
                VirtualMemoryCapacity = Math.Round(Convert.ToDouble(item["TotalVirtualMemorySize"]) / 1024.0f / 1024.0f, 1);
            }
        }

        public void GetMemoryInfo()
        {
            foreach (var item in _memoryGeneralInfo.OperatingSystemManage.Get())
            {
                FreeMemory = Math.Round(Convert.ToDouble(item["FreePhysicalMemory"]) / 1024.0f / 1024.0f,1);
                FreeVirtualMemory = Math.Round(Convert.ToDouble(item["FreeVirtualMemory"]) / 1024.0f / 1024.0f, 1);
            }
            MemoryUsage = MemoryVisibleCapacity - FreeMemory;
            UsedVirtualMemory = VirtualMemoryCapacity - FreeVirtualMemory;

            var percentUsage = (MemoryUsage * 100) / MemoryVisibleCapacity;
            if (percentUsage > LimitValues.LimitMemoryUsage - 5)
            {
                if (LimitValues.CountMemoryUsageHits < 5)
                {
                    LimitValues.CountMemoryUsageHits++;
                }
            }
            else if (LimitValues.CountMemoryUsageHits > 0)
            {
                LimitValues.CountMemoryUsageHits--;
            }

            MemoryLogs.Add(new MemoryLog() 
            { 
                Date = DateTime.Now, 
                Usage = MemoryUsage,
                VirtualMemoryUsage = UsedVirtualMemory
            });
            var json = new DataContractJsonSerializer(MemoryLogs.GetType());
            using (FileStream file = new FileStream("Memory.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(file, MemoryLogs);
            }

            Thread.Sleep(1000);
        }
    }
}
