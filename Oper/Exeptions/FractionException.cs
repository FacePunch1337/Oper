using System;
using System.Collections.Generic;
using System.Text;

namespace Oper.Exeptions
{
    class FractionException : Exception
    {
        public FractionException() : base("Invalid operation with Fraction number (s)")
        {

        }
        public FractionException(String message) : base(message)
        {

        }
    }
}
