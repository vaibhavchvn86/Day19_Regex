using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_PP1
{
    class UC1_FirstName
    {
        public static string Regex_FName = "^[A-Z][a-z]{2,}$";
        public bool ValidateFName(string Firstname)
        {
            return Regex.IsMatch(Firstname, Regex_FName);
        }

    }
}
