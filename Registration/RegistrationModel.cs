using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registration
{
    public class RegistrationModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public int Zipcode { get; set; }
        public string About { get; set; }

    }
}
