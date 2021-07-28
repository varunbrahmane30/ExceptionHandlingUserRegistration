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
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_MobileNo = "(0|91)?[ ][6-9][0-9]{9}";
        public static string Regex_Password = "^*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).*$";

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

        public bool validateEmail(string email)
        {
            if (email == null)
            {
                throw new RegisterUser(RegisterUser.ExceptionsType.Invalid_MESSAGE, "Entered Invalid Email Address");
            }
            return Regex.IsMatch(email, Regex_Email);
        }

        public bool validateMobileNO(string mobileNo)
        {
            if (mobileNo == null)
            {
                throw new RegisterUser(RegisterUser.ExceptionsType.Invalid_MESSAGE, "Entered Invalid Mobile Number");
            }
            return Regex.IsMatch(mobileNo, Regex_MobileNo);
        }

        public bool validatePassword(string pass)
        {
            if (pass == null)
            {
                throw new RegisterUser(RegisterUser.ExceptionsType.Invalid_MESSAGE, "Entered Invalid Password");
            }
            return Regex.IsMatch(pass, Regex_Password);
        }


    }

}
