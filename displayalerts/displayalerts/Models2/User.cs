using System;
using System.Collections.Generic;
using System.Text;

namespace displayalerts.Models2
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserTypeId { get; set; }
        public long Ssn { get; set; }
        public string Password { get; set; }
        public long Phonenumber { get; set; }
        public string Email { get; set; }

    }
}
