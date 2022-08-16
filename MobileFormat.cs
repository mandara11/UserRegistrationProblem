using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
As a User need to follow pre-defined Mobile Format
- E.g. 91 9919819801
- Country code follow by space and 10 digit number
*/

namespace UserRegistrationProblem
{
    public class MobileFormat
    {
        public static string REGEX_MobileNo = "^[0-9]{1,3}[ ][6789][0-9]{9}$"; // 91 9919819801

        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, REGEX_MobileNo);
        }
    }
}
