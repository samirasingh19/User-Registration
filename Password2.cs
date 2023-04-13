using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Password2
    {
        public static string PassWord = "^(?=.*[A-Z]).{8,}$";
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PassWord);
        }
    }
}
