using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrcEvent2ApiClient.FrcObjects
{

    public class Team
    {
        public int teamNumber { get; set; }
        public string nameFull { get; set; }
        public string nameShort { get; set; }
        public string city { get; set; }
        public string stateProv { get; set; }
        public string country { get; set; }
        public int rookieYear { get; set; }
        public string robotName { get; set; }
        public object districtCode { get; set; }
        public object website { get; set; }
    }

    class TeamData
    {
        public List<Team> teams { get; set; }
        public int teamCountTotal { get; set; }
        public int teamCountPage { get; set; }
        public int pageCurrent { get; set; }
        public int pageTotal { get; set; }
    }
}
