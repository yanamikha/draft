using System;
using System.Collections.Generic;
using System.Text;

namespace ClientServerServices.Exceptions
{
    public class AuthorizationException : Exception
    {
        public AuthorizationException(string message) : base(message)
        {
        }

        public AuthorizationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public AuthorizationException() : base()
        {
        }
    }
}
