using System;
using System.Collections.Generic;
using System.Text;

namespace ClientServerServices.Exceptions
{
    class FillDataGridException:Exception
    {
        public FillDataGridException(string message) : base(message)
        {
        }

        public FillDataGridException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public FillDataGridException():base()
        {
        }
    }
}
