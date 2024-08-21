using PojectFinal___API.Enums;
using System.ComponentModel.DataAnnotations;

namespace PojectFinal___API.Modles
{
    public class Target
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Occupation { get; set; }

        public Dictionary<Pin, int>? Pin { get; set; }

        public StatusTarget? statusTarget { get; set; }

        public Target() { } 
    }
}
