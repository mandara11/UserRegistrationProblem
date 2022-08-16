using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class LastName
    {
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateFirstName(string lName)
        {
            return Regex.IsMatch(lName, LAST_NAME_REGEX);
        }
    }
}
