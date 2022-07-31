using System;
using System.Collections.Generic;

namespace JWTProject.Core.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime LastActivity { get; set; }
        public ICollection<Person> People { get; set; }
    }
}
