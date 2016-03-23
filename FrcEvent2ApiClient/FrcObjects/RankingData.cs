using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects.RankingAPI
{
    public class Ranking
    {
        public int dq { get; set; }
        public int losses { get; set; }
        public int matchesPlayed { get; set; }
        public double qualAverage { get; set; }
        public int rank { get; set; }
        public int teamNumber { get; set; }
        public int ties { get; set; }
        public int wins { get; set; }
        public int sortOrder1 { get; set; }
        public int sortOrder2 { get; set; }
        public int sortOrder3 { get; set; }
        public int sortOrder4 { get; set; }
        public int sortOrder5 { get; set; }
        public int sortOrder6 { get; set; }
    }

    class RankingData
    {
        public List<Ranking> Rankings { get; set; }
    }
}
