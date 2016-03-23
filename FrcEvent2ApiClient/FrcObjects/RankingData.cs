using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects.RankingAPI
{
    [DataContract]
    public class Ranking
    {
        [DataMember]
        public int dq { get; set; }
        [DataMember]
        public int losses { get; set; }
        [DataMember]
        public int matchesPlayed { get; set; }
        [DataMember]
        public double qualAverage { get; set; }
        [DataMember]
        public int rank { get; set; }
        [DataMember]
        public int teamNumber { get; set; }
        [DataMember]
        public int ties { get; set; }
        [DataMember]
        public int wins { get; set; }
        [DataMember]
        public int sortOrder1 { get; set; }
        [DataMember]
        public int sortOrder2 { get; set; }
        [DataMember]
        public int sortOrder3 { get; set; }
        [DataMember]
        public int sortOrder4 { get; set; }
        [DataMember]
        public int sortOrder5 { get; set; }
        [DataMember]
        public int sortOrder6 { get; set; }
    }

    [DataContract]
    public class RankingData
    {
        [DataMember]
        public List<Ranking> Rankings { get; set; }
    }
}
