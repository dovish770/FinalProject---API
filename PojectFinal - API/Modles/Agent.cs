using PojectFinal___API.Enums;
using System.ComponentModel.DataAnnotations;

namespace PojectFinal___API.Modles
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public Dictionary<Pin, int>? Pin { get; set; }

        public string? Image {  get; set; }

        public StatusAgent? Status {  get; set; }

        public Agent() { }
    }
}
