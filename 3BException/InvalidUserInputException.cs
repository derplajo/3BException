using System;
using System.Collections.Generic;
using System.Text;

namespace _3BException
{
    public class InvalidUserInputException : Exception
    {
        public InvalidUserInputException(string age): base(age) { }
    }
}
