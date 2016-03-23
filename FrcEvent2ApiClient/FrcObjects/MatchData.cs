using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects.MatchAPI
{
    [DataContract]
    public class Team
    {
        [DataMember]
        public int teamNumber { get; set; }
        [DataMember]
        public string station { get; set; }
        [DataMember]
        public bool dq { get; set; }
    }

    [DataContract]
    public class Match
    {
        [DataMember]
        public string actualStartTime { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public string postResultTime { get; set; }
        [DataMember]
        public int scoreRedFinal { get; set; }
        [DataMember]
        public int scoreRedFoul { get; set; }
        [DataMember]
        public int scoreRedAuto { get; set; }
        [DataMember]
        public int scoreBlueFinal { get; set; }
        [DataMember]
        public int scoreBlueFoul { get; set; }
        [DataMember]
        public int scoreBlueAuto { get; set; }
        [DataMember]
        public string tournamentLevel { get; set; }
        [DataMember]
        public List<Team> Teams { get; set; }
    }

    [DataContract]
    public class MatchData
    {
        [DataMember]
        public List<Match> Matches { get; set; }
    }
}
