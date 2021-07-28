using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21_ExceptionHandlingUserRegistration
{
    public class Pattern
    {
        public static String Regex_Name = "^[A-Z]{1}[A-Za-z]{1}[a-zA-Z]*$";
        public static string Regex_lName = "^[A-Z]{1}[A-Za-z]{1}[a-zA-Z]*$";

        public bool validateFirstName(string firstName)
        {
            if (firstName == null)
            {
                throw new RegisterUser(RegisterUser.ExceptionsType.Invalid_MESSAGE, "Entered Invalid First Name");
            }
            return Regex.IsMatch(firstName, Regex_Name);
        }

        public bool validateLastName(string lastName)
        {
            if (lastName == null)
            {
                throw new RegisterUser(RegisterUser.ExceptionsType.Invalid_MESSAGE, "Entered Invalid Last Name");
            }
            return Regex.IsMatch(lastName, Regex_lName);
        }
    }
}
