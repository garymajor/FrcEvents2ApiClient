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
//        const string BaseUrl = "https://frc-api.firstinspires.org/v2.0/";  // Production URL for APIs
        const string BaseUrl = "https://frc-staging-api.firstinspires.org/v2.0/"; // Staging URL for APIs
        const string Season = "2016";
        const string Token = "";
        const string TeamNumberDefault = "2147";

        public static async Task<string> GetTeamData(string teamNumber)
        {
            int i = 0;
            if (teamNumber.CompareTo("") == 0 || !Int32.TryParse(teamNumber, out i))
            {
                teamNumber = "2147";
            }

            return await GetAsyncFromFirst(new Uri(BaseUrl + Season + "/teams?teamNumber=" + teamNumber));
        }

        public static async Task<string> GetEventMatchesForTeam(string eventCode, string teamNumber)
        {
            if (eventCode.CompareTo("") == 0)
            {
                eventCode = "WAELL";
            }
            var schedule = await GetAsyncFromFirst(new Uri(BaseUrl + Season + "/schedule/" + eventCode + "?teamNumber=" + teamNumber));
            var results = await GetAsyncFromFirst(new Uri(BaseUrl + Season + "/matches/" + eventCode + "?teamNumber=" + teamNumber));
            return schedule;
        }

        public static async Task<string> GetEventMatches(string eventCode)
        {
            if (eventCode.CompareTo("") == 0)
            {
                eventCode = "WAELL";
            }
            var schedule = await GetAsyncFromFirst(new Uri(BaseUrl + Season + "/schedule/" + eventCode));
            var results = await GetAsyncFromFirst(new Uri(BaseUrl + Season + "/matches/" + eventCode));
            return schedule;
        }

        public static async Task<string> GetEventRankingList(string eventCode)
        {
            if (eventCode.CompareTo("") == 0)
            {
                eventCode = "WAELL";
            }

            return await GetAsyncFromFirst(new Uri(BaseUrl + Season + "/ranking/" + eventCode));
        }

        public static async Task<string> GetEventRankingForTeam(string eventCode, string teamNumber)
        {
            int i = 0;
            if (teamNumber.CompareTo("") == 0 || !Int32.TryParse(teamNumber, out i))
            {
                teamNumber = "2147";
            }

            if (eventCode.CompareTo("") == 0)
            {
                eventCode = "WAELL";
            }

            return await GetAsyncFromFirst(new Uri(BaseUrl + Season + "/ranking/" + eventCode + "?teamNumber=" + teamNumber));
        }

        private static async Task<string> GetAsyncFromFirst(Uri uri)
        {
            string responseData = "";
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.TryAppendWithoutValidation("accept", "application/json");
                httpClient.DefaultRequestHeaders.TryAppendWithoutValidation("authorization", "Basic " + Token);
                using (var response = await httpClient.GetAsync(uri))
                {
                    responseData = await response.Content.ReadAsStringAsync();
                }
            }
            return responseData;
        }
    }
}
