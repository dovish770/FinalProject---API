using PojectFinal___API.Enums;

namespace PojectFinal___API.Modles
{
    public class Mission
    {
        public int AgentId { get; set; }

        public int TargetId { get; set; }

        public string TimeLeft { get; set; }

        public StatusMission Status { get; set; }
    }
}
