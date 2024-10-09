//User.cs
using System.Text.Json.Serialization;

namespace aspapi.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; }
        public required string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
        public bool isActive { get; set; }
    }
}