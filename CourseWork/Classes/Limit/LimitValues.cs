namespace CourseWork.Classes.Limit
{
    public static class LimitValues
    {
        public static double LimitTemperatureCPU { get; set; }

        public static double LimitCPUUsage { get; set; }

        public static double LimitMemoryUsage { get; set; }

        public static int CountCPUTemperatureHits { get; set; }

        public static int CountCPUUsageHits { get; set; }

        public static int CountMemoryUsageHits { get; set; }

        static LimitValues()
        {
            LimitTemperatureCPU = 60;
            LimitCPUUsage = 10;
            LimitMemoryUsage = 10;
            CountCPUTemperatureHits = 0;
            CountCPUUsageHits = 0;
            CountMemoryUsageHits = 0;
        }
    }
}
