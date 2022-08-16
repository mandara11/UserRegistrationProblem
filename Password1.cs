using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


/*
As a User need to follow pre-defined Password rules.
Rule1 – minimum 8Characters
- NOTE – All rules must be passed
*/

namespace UserRegistrationProblem
{
    public class Password1
    {
        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$"; //mandaraM, MandaraM

        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }
    }
}
