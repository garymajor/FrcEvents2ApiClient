using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects.MatchAPI
{

    public class Team
    {
        public int teamNumber { get; set; }
        public string station { get; set; }
        public bool dq { get; set; }
    }

    public class Match
    {
        public string actualStartTime { get; set; }
        public string description { get; set; }
        public int number { get; set; }
        public string postResultTime { get; set; }
        public int scoreRedFinal { get; set; }
        public int scoreRedFoul { get; set; }
        public int scoreRedAuto { get; set; }
        public int scoreBlueFinal { get; set; }
        public int scoreBlueFoul { get; set; }
        public int scoreBlueAuto { get; set; }
        public string tournamentLevel { get; set; }
        public List<Team> Teams { get; set; }
    }

    class MatchData
    {
        public List<Match> Matches { get; set; }

    }
}
