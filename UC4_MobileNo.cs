using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_PP1
{
    class UC4_MobileNo
    {
        public static string Regex_mobilenum = "^[1-9][0-9][ ]?[6-9][0-9]{9}$";
        public bool Validatemobile(string mobilenum)
        {
            return Regex.IsMatch(mobilenum, Regex_mobilenum);
        }

    }
}
