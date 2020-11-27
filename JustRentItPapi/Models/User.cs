using System;
using System.Collections.Generic;

#nullable disable

namespace JustRentItPapi.Models
{
    public partial class User
    {
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? Joiningdate { get; set; }
    }
}
