// <summary>Implements the brokerstringextensions class</summary>
using System.Text;

namespace Eq2BrokerCalc2Lib.Code
{
    /// <summary>   A broker string extensions. </summary>
    public static class BrokerStringExtensions
    {
        /// <summary>   A TransactionAmount extension method that output total. </summary>
        /// <param name="transactionObj">   The transactionObj to act on. </param>
        /// <returns>   A string. </returns>
        public static string OutputTotal(this TransactionAmount transactionObj)
        {
            var sb = new StringBuilder();

            if (transactionObj.PlatinumAmount > 0)
            {
                sb.Append(transactionObj.PlatinumAmount + "p");
            }

            if (transactionObj.GoldAmount > 0)
            {
                sb.Append(transactionObj.GoldAmount + "g");
            }

            if (transactionObj.SilverAmount > 0)
            {
                sb.Append(transactionObj.SilverAmount + "s");
            }

            if (transactionObj.CopperAmount > 0)
            {
                sb.Append(transactionObj.CopperAmount + "c");
            }

            return sb.ToString();
        }
    }
}