using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class FirstName
    {
        public bool ValidateFirstName(string fName)
        {
            string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

            return Regex.IsMatch(fName, FIRST_NAME_REGEX);
        }
    }
}
