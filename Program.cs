using System;

namespace Day21_ExceptionHandlingUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problem using Exception Handling ");

            Pattern pattern = new Pattern();

            Console.Write("Enter FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Test Result Is : " + pattern.validateFirstName(firstName));

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Test Result Is : " + pattern.validateLastName(lastName));


            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Test Result Is : " + pattern.validateEmail(email));



            Console.ReadKey();
        }
    }
}
