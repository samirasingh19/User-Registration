using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Password1
    {
        public static string PassWord = "^[a-z]{8,}$";
        public bool ValidatePassword(string passWord)
        {
            return Regex.IsMatch(passWord, PassWord);
        }
    }
}
