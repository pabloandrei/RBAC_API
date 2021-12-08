using WebApi.Entities;
using System.Collections.Generic;

namespace WebApi.Models.Users
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public string Permissions { get; set; }
        public string JwtToken { get; set; }

        public AuthenticateResponse(){}

        public AuthenticateResponse(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Role = user.Role;
            Permissions = user.Permissions;
        }
    }
}