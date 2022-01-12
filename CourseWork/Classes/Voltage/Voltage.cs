using HardwareProviders.CPU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CourseWork.Classes.Voltage
{
    public class Voltage
    {
        private readonly VoltageGeneralInfo _voltageGeneralInfo;
        public double BatteryVoltage { get; set; }
        public List<double> CPUCoresVoltage { get; set; }
        public double CPUPower { get; set; }
        public List<double> CPUCoresPower { get; set; }
        public double GPUPower { get; set; }

        public Voltage()
        {
            CPUCoresVoltage = new List<double>();
            CPUCoresPower = new List<double>();
            _voltageGeneralInfo = new VoltageGeneralInfo();
            _voltageGeneralInfo.GetGeneralInfo();
        }

        public void GetVoltageInfo()
        {
            //Battery voltage
            foreach (var item in _voltageGeneralInfo.BatteryVoltageManager)
            {
                BatteryVoltage = Convert.ToDouble(item["DesignVoltage"])/1000.0f;
            }

            //CPU cores voltage
            var cpu = Cpu.Discover();
            foreach (var item in cpu[0].CoreVoltages)
            {
                CPUCoresVoltage.Add(Convert.ToDouble(item.Value));
            }

            //CPU power
            _voltageGeneralInfo.CPUCoresPower.Update();
            var sensorsCPUPower = _voltageGeneralInfo.CPUCoresPower.Sensors
                .Where(x => x.Name == "CPU Package" && x.SensorType == OpenHardwareMonitor.Hardware.SensorType.Power);
            var sensorsCPUCorePowers = _voltageGeneralInfo.CPUCoresPower.Sensors
                .Where(x => x.Name.StartsWith("CPU Core #") && x.SensorType == OpenHardwareMonitor.Hardware.SensorType.Power);
            foreach (var item in sensorsCPUPower)
            {
                CPUPower = Math.Round(Convert.ToDouble(item.Value),3);
            }
            CPUCoresPower.Clear();
            foreach (var item in sensorsCPUCorePowers)
            {
                CPUCoresPower.Add(Math.Round(Convert.ToDouble(item.Value), 3));
            }
            Thread.Sleep(1000);
        }
    }
}
