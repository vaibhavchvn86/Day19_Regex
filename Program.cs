using System;

namespace Day19_Regex_PP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******Welcome to Regex Program******");
            #region UC1
            UC1_FirstName fname = new UC1_FirstName();
            Console.WriteLine(fname.ValidateFName("John"));
            #endregion

            #region UC2
            UC2_LastName lname = new UC2_LastName();
            Console.WriteLine(lname.ValidateLName("Wick"));
            #endregion

            #region UC3
            UC3_OptEmail emailopt = new UC3_OptEmail();
            Console.WriteLine(emailopt.ValidateEmail("abc.xyz@bl.co.in"));
            #endregion

            #region UC4
            UC4_MobileNo mobile = new UC4_MobileNo();
            Console.WriteLine(mobile.Validatemobile("91 9919819801"));
            #endregion

            #region UC5
            UC5_Password passR1 = new UC5_Password();
            Console.WriteLine(passR1.Validatepassword("avsvtbbb"));
            #endregion

            #region UC6
            UC6_PassWord passR2 = new UC6_PassWord();
            Console.WriteLine(passR2.Validatepassword("AvSvtbbb"));
            #endregion

            #region UC7
            UC7_PassWorD passR4 = new UC7_PassWorD();
            Console.WriteLine(passR4.Validatepassword("AvS58bbb"));
            #endregion

            #region UC8
            UC8_PassWD passR5 = new UC8_PassWD();
            Console.WriteLine(passR5.Validatepassword("AvS5-8bbb"));
            #endregion

            #region UC9
            UC9_Email email = new UC9_Email();
            Console.WriteLine(email.ValidateEmail("abc.xyz@bl.co.in"));
            Console.WriteLine(email.ValidateEmail("abc.100@yahoo.com"));
            Console.WriteLine(email.ValidateEmail("abc@abc@gmail.com"));
            Console.WriteLine(email.ValidateEmail("abc.100@abc.com.au"));
            Console.WriteLine(email.ValidateEmail("abc-100@abc.net"));
            Console.WriteLine(email.ValidateEmail("abc123@.com.com"));
            Console.WriteLine(email.ValidateEmail("abc@%*.com"));
            Console.WriteLine(email.ValidateEmail("abc.xyz11@blll.com"));
            #endregion

            Console.ReadKey();
        }
    }
}
