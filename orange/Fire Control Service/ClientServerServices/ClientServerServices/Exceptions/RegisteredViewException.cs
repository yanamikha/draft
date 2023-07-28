using System;
using System.Collections.Generic;
using System.Text;

namespace ClientServerServices.Exceptions
{
    class RegisteredViewException : Exception
    {
        public RegisteredViewException(string message) : base(message)
        {
        }

        public RegisteredViewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public RegisteredViewException() : base()
        {
        }
    }
}
