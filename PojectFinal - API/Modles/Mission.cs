using PojectFinal___API.Enums;
using System.ComponentModel.DataAnnotations;

namespace PojectFinal___API.Modles
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        public Agent Agent { get; set; }

        public Target Target { get; set; }
      
        public double? Duration { get; set; }
        
        public string? TimLeft { get; set; }

        public StatusMission? Status { get; set; }

        //חישוב מרחק בין סוכן למטרה
        private static double Distance(Dictionary<string, int> dic1, Dictionary<string, int> dic2)
        {
            int x1 = dic1["x"];
            int y1 = dic1["y"];

            int x2 = dic2["x"];
            int y2 = dic2["y"];

            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }

        //חישוב ועידכון זמן שנותר 
        public void UpdateTimeLeft()
        {   
            if (this.Status.ToString() != "Completed")
            {
                return;
            }

            var distance = Distance(Agent.Pin, Target.Pin);            
            this.TimLeft = (distance/5).ToString();                     
        }
        
        //חישוב ועידכון משך המשימה
        public void UpdateDuration()
        {
            var distance = Distance(Agent.Pin, Target.Pin);
            var time = (distance/5);
            this.Duration += time;
        }
    }
}
