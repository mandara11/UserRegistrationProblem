using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*
Rule2 – Should have at least 1 Upper Case
*/

namespace UserRegistrationProblem
{
    public class Password2
    {
        public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$"; //Mandara

        public bool ValidatePassword2(string password)
        {
            return Regex.IsMatch(password, REGEX_Password2);
        }
    }
}
