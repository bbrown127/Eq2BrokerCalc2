using System;

namespace Eq2BrokerCalc2Lib.Code.Exceptions
{
    public class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message)
        {
        }
    }
}