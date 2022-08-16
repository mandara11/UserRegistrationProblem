using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Rule4 – Has exactly 1 Special Character
- NOTE – All rules must be passed
*/

namespace UserRegistrationProblem
{
    public class Password4
    {
        public static string REGEX_Password4 = "^[A-Z]{1}[A-Z a-z]{7,}[!*@#$%^&+=]?[0-9]{1,}$"; //Mandaram@1234

        public bool ValidatePassword4(string password)
        {
            return Regex.IsMatch(password, REGEX_Password4);
        }
    }
}
