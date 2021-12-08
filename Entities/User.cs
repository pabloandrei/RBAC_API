using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public string Permissions { get; set; }
        public string Company { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}