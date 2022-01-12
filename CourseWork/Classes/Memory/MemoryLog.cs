using System;
using System.Runtime.Serialization;

namespace CourseWork.Classes.Memory
{
    [DataContract]
    public class MemoryLog
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public double Usage { get; set; }

        [DataMember]
        public double VirtualMemoryUsage { get; set; }
    }
}
