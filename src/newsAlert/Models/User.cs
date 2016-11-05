using System;
using System.Collections.Generic;

namespace newsAlert.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}
