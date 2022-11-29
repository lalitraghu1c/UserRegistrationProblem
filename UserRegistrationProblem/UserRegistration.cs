using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$", LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        const string VALID_EMAIL ="^[a-z]{3,}[.]{0,1}[a-z]{0,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{0,1}[a-z]{0,}$";
        const string MOBILE_FORMAT = "^[0-9]{2}[ ]{1}[0-9]{10}", PASSWORD = "^(?=.*[A-Z])[A-Za-z0-9]{8,}$";
        public void FirstName()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, FIRST_NAME))
                Console.WriteLine("Valid First Name - " + input);
            else
                Console.WriteLine("Invalid");
        }
        public void LastName()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, LAST_NAME))
                Console.WriteLine("Valid Last Name - " + input);
            else
                Console.WriteLine("Invalid");
        }
        public void ValidEmail()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, VALID_EMAIL))
                Console.WriteLine("Valid Email id - " + input);
            else
                Console.WriteLine("Invalid");
        }
        public void MobileNumber()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, MOBILE_FORMAT))
                Console.WriteLine("Valid Mobile Number - " + input);
            else
                Console.WriteLine("Invalid");
        }
        public void Password()
        {
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, PASSWORD))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid");
        }
    }
}
