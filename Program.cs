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

            Console.ReadKey();
        }
    }
}
