using System;
using System.Runtime.Serialization;

namespace CourseWork.Classes.CPU
{
    [DataContract]
    public class CPULog
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public double Temperature { get; set; }

        [DataMember]
        public double Usage { get; set; }
    }
}
