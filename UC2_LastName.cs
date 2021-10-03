using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_PP1
{
    class UC2_LastName
    {
        public static string Regex_LName = "^[A-Z][a-z]{2,}$";
        public bool ValidateLName(string Lastname)
        {
            return Regex.IsMatch(Lastname, Regex_LName);
        }

    }
}
