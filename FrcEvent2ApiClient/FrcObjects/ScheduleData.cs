using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects.ScheduleAPI
{
    [DataContract]
    public class Team
    {
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public string station { get; set; }
        [DataMember]
        public bool surrogate { get; set; }
    }

    [DataContract]
    public class Schedule
    {
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string field { get; set; }
        [DataMember]
        public int matchNumber { get; set; }
        [DataMember]
        public string startTime { get; set; }
        [DataMember]
        public string tournamentLevel { get; set; }
        [DataMember]
        public List<Team> Teams { get; set; }
    }

    [DataContract]
    public class ScheduleData
    {
        [DataMember]
        public List<Schedule> Schedule { get; set; }
    }
}
