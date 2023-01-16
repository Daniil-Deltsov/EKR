using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    public class TransportException : Exception
    {
        public TransportException(string message) : base(message) { }
    }
}
