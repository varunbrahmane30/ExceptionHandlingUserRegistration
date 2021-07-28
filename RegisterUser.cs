using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_ExceptionHandlingUserRegistration
{
    public class RegisterUser : Exception
    {
        public enum ExceptionsType
        {
            Invalid_MESSAGE,
        }
        public ExceptionsType type;
        public RegisterUser(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
