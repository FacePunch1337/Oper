using System;
using System.Collections.Generic;
using System.Text;

namespace Oper.Exeptions
{
    class ComplexExeption : Exception
    {
        public ComplexExeption() : base("Invalid operation with Complex number(s)")
        {

        }

        public ComplexExeption(String message) : base(message) 
        {

        }
    }
}
