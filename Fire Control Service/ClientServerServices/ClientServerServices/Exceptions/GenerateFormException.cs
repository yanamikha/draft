using System;
using System.Collections.Generic;
using System.Text;

namespace ClientServerServices.Exceptions
{
    class GenerateFormException : Exception
    {
        public GenerateFormException(string message) : base(message)
        {
        }

        public GenerateFormException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public GenerateFormException():base()
        {
        }
    }
}
