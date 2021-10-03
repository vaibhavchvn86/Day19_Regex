using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_PP1
{
    class UC7_PassWorD
    {
        public static string Regex_password = "^[a-zA-Z0-9]{8,}$";
        public bool Validatepassword(string password)
        {
            return Regex.IsMatch(password, Regex_password);
        }

    }
}
