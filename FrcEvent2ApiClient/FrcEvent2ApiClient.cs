using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace FrcEvent2ApiClient
{
    public static class FrcEvent2ApiClient
    {
        const string uriBase = "http://";

        public static void GetTeamData()
        {
            var teamNumber = "2147";
            var url = uriBase + "";

            var client = new HttpClient();
        }

        public static void GetEventRankings()
        {

        }

        public static void GetMatchesForTeam()
        {
            var teamNumber = "2147";

        }

        public static void GetMatchesForEvent()
        {
            var e = "WAELL"; // Washington Ellensburg
        }
    }
}
