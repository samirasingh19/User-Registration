using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Email
    {
        public static string Email = "^[a-z0-9._+-]+@[a-z0-9.-]+\\.[a-z.]{2,}$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Email);
        }
    }
}
