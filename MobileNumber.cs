using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class MobileNumber
    {
        public static string MobileNumber = "^[1-9]{1,3} [0-9]{10}$";
        public bool ValidatMoNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MobileNumber);
        }
    }
}
