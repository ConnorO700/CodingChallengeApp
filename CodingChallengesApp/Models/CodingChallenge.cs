using System.Text.Json.Serialization;

namespace CodingChallengesApp.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Difficulty
    {
        Trivial = 0,
        Easy = 1,
        Medium = 2,
        Hard = 4
    }
    public class CodingChallenge
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Difficulty DifficultyRating { get; set; }
        public string? Path { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
