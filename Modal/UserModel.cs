using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LearnAPI.Modal
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Name { get; set; } 
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? Isactive { get; set; }
        public string? Statusname { get; set; }
        public string Role { get; set; }
    }
}
