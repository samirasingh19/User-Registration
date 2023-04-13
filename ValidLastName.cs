using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidLastName
    {
        public static string LastName = "^[A-Z]{1}[A-Za-z]{3,}$";
        public bool ValidateLastName(string LName)
        {
            return Regex.IsMatch(LName, LastName);
        }
    }
}
