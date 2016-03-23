using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects.ScheduleAPI
{
    public class Team
    {
        public int number { get; set; }
        public string station { get; set; }
        public bool surrogate { get; set; }
    }

    public class Schedule
    {
        public string description { get; set; }
        public string field { get; set; }
        public int matchNumber { get; set; }
        public string startTime { get; set; }
        public string tournamentLevel { get; set; }
        public List<Team> Teams { get; set; }
    }

    class ScheduleData
    {
        public List<Schedule> Schedule { get; set; }
    }
}
