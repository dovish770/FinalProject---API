using PojectFinal___API.Modles;

namespace PojectFinal___API.Services
{
    public class TimeDistanceService
    {
        //חישוב מרחק בין סוכן למטרה
        public static double Distance(Dictionary<string, int> dic1, Dictionary<string, int> dic2)
        {
            int x1 = dic1["x"];
            int y1 = dic1["y"];

            int x2 = dic2["x"];
            int y2 = dic2["y"];

            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }

        //חישוב ועידכון זמן שנותר 
        public Mission UpdateTimeLeft(Mission mission)
        {
            if (mission.Status.ToString() != "Actice")
            {
                return mission;
            }

            var distance = Distance(mission.Agent.Pin, mission.Target.Pin);
            mission.TimLeft = (distance/5).ToString();

            return mission;
        }

        //חישוב ועידכון משך המשימה
        public Mission UpdateDuration(Mission mission)
        {
            if (mission.Status.ToString() != "Actice")
            {
                return mission;
            }

            var distance = Distance(mission.Agent.Pin, mission.Target.Pin);
            var time = (distance/5);
            mission.Duration += time;
            return mission;
        }
    }
}
