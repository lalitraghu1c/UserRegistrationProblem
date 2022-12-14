using System;
namespace UserRegistrationProblem
{
    public class Program
    {
        public static string emailsFilePath = @"D:\Projects-Bridgelabz\UserRegistrationProblem\UserRegistrationProblem\Emails.txt";
        public static void Main(string[] args)
        {
            UserRegistration user = new UserRegistration();
            Console.WriteLine("Welcome to User Registration Problem Statements.");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Enter First Name\n2. Enter Last Name\n3. Enter Email ID\n4. Enter Mobile Number\n5. Enter Password\n6. Validating Email Sample\n7. Enter First Name using Lambda Expression\n8. Exit");
                int condition = Convert.ToInt32(Console.ReadLine());
                switch (condition)
                {
                    case 1:
                        Console.WriteLine("Enter Name - ");
                        user.FirstName();
                        break;
                    case 2:
                        Console.WriteLine("Enter Surname - ");
                        user.LastName();
                        break;
                    case 3:
                        Console.WriteLine("Enter Email ID - ");
                        user.ValidEmail();
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile Number - ");
                        user.MobileNumber();
                        break;
                    case 5:
                        Console.WriteLine("Enter Password (min. 8 characters, atleast 1 upper case, atleast 1 numberic value & exact 1 special character {!,@,#,$,%}) - ");
                        user.Password();
                        break;
                    case 6:
                        user.ReadEmailsData(emailsFilePath);
                        break;
                    case 7:
                        user.ValidFirstNameByLambda();
                        Console.WriteLine("Successfull");
                        break;
                    default:
                        choice = false;
                        Console.WriteLine("Try Again!");
                        break;
                }
            }
        }
    }
}