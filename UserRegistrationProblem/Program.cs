using System;
namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserRegistration user = new UserRegistration();
            Console.WriteLine("Welcome to User Registration Problem Statements.");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1. Enter First Name\n2. Exit");
                int condition = Convert.ToInt32(Console.ReadLine());
                switch (condition)
                {
                    case 1:
                        Console.WriteLine("Enter name - ");
                        user.FirstName();
                        break;
                    default:
                        Console.WriteLine("Try Again! Bro.");
                        break;
                }
            }
        }
    }
}