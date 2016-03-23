using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects.TeamAPI
{
    [DataContract]
    public class Team
    {
        [DataMember]
        public int teamNumber { get; set; }
        [DataMember]
        public string nameFull { get; set; }
        [DataMember]
        public string nameShort { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string stateProv { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public int rookieYear { get; set; }
        [DataMember]
        public string robotName { get; set; }
        [DataMember]
        public object districtCode { get; set; }
        [DataMember]
        public object website { get; set; }
    }

    [DataContract]
    public class TeamData
    {
        [DataMember]
        public List<Team> teams { get; set; }
        [DataMember]
        public int teamCountTotal { get; set; }
        [DataMember]
        public int teamCountPage { get; set; }
        [DataMember]
        public int pageCurrent { get; set; }
        [DataMember]
        public int pageTotal { get; set; }
    }
}
