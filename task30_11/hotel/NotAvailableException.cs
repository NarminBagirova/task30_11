using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task30_11.hotel
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message) { }

    }
}
