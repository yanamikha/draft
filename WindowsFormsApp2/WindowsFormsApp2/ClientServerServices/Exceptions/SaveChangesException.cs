using System;
using System.Collections.Generic;
using System.Text;

namespace ClientServerServices.Exceptions
{
    class SaveChangesException:Exception
    {
        public SaveChangesException(string message) : base(message)
        {
        }

        public SaveChangesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public SaveChangesException():base()
        {
        }
    }
}
