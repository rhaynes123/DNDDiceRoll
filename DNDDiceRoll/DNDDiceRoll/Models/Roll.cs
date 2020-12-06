using System.Text.Json.Serialization;
namespace DNDDiceRoll.Models
{
    public class Roll
    {
        [JsonPropertyName("sides")]
        public int Sides { get; set; }
        [JsonPropertyName("qty")]
        public int Qty { get; set; } = 1;
        [JsonPropertyName("bonus")]
        public int Bonus { get; set; } = 0;
        public Roll()
        {
            // empty constructor
        }
    }
}
