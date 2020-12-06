using System;
namespace DNDDiceRoll.Models
{
    public class Dice
    {
        public int NumberOfSides { get; set; }
        public string Name
        {
            get
            {
                return $"d{NumberOfSides}";
            }
        }
        public Dice(int NumberOfSides)
        {
            this.NumberOfSides = NumberOfSides;
        }
    }
}
