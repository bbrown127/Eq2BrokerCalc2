// <summary>Implements the transaction amount class</summary>

using Eq2BrokerCalc2Lib.Code.Exceptions;

namespace Eq2BrokerCalc2Lib.Code
{
    /// <summary>   A transaction amount. </summary>
    public class TransactionAmount : ITransactionAmount
    {
        /// <summary>
        ///     Initializes a new instance of the Eq2BrokerCalc2.Code.TransactionAmount class.
        /// </summary>
        public TransactionAmount() { }

        /// <summary>
        ///     Initializes a new instance of the Eq2BrokerCalc2.Code.TransactionAmount class.
        /// </summary>
        /// <exception cref="InvalidAmountException">   Thrown when an Invalid Amount error condition
        ///                                             occurs. </exception>
        /// <param name="totalCopper">  The total copper. </param>
        public TransactionAmount(int totalCopper)
        {
            if (totalCopper < 0)
            {
                throw new InvalidAmountException("Copper amount must be 0 or greater");
            }

            ParseAmounts(totalCopper);
        }

        /// <summary>   Gets the copper total. </summary>
        /// <value> The copper total. </value>
        public int CopperTotal { get; private set; }

        /// <summary>   Gets the platinum amount. </summary>
        /// <value> The platinum amount. </value>
        public int PlatinumAmount { get; private set; }

        /// <summary>   Gets the gold amount. </summary>
        /// <value> The gold amount. </value>
        public int GoldAmount { get; private set; }

        /// <summary>   Gets the silver amount. </summary>
        /// <value> The silver amount. </value>
        public int SilverAmount { get; private set; }

        /// <summary>   Gets the copper amount. </summary>
        /// <value> The copper amount. </value>
        public int CopperAmount { get; private set; }

        /// <summary>   Parse amounts. </summary>
        /// <param name="totalCopper">  The total copper. </param>
        protected void ParseAmounts(int totalCopper)
        {
            CopperTotal = totalCopper;

            CopperAmount = CopperTotal % 100;
            var tempWholeNumber = CopperTotal / 100;

            SilverAmount = tempWholeNumber % 100;
            tempWholeNumber = tempWholeNumber / 100;

            GoldAmount = tempWholeNumber % 100;
            PlatinumAmount = tempWholeNumber / 100;
        }

        /// <summary>   Determines whether the specified object is equal to the current object. </summary>
        /// <param name="other">    The transaction amount to compare to this object. </param>
        /// <returns>
        ///     true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        protected bool Equals(TransactionAmount other)
        {
            return CopperTotal == other.CopperTotal && PlatinumAmount == other.PlatinumAmount && GoldAmount == other.GoldAmount && SilverAmount == other.SilverAmount && CopperAmount == other.CopperAmount;
        }

        /// <summary>   Determines whether the specified object is equal to the current object. </summary>
        /// <param name="obj">  The object to compare with the current object. </param>
        /// <returns>
        ///     true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals((TransactionAmount) obj);
        }

        /// <summary>   Serves as the default hash function. </summary>
        /// <returns>   A hash code for the current object. </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = CopperTotal;
                hashCode = (hashCode * 397) ^ PlatinumAmount;
                hashCode = (hashCode * 397) ^ GoldAmount;
                hashCode = (hashCode * 397) ^ SilverAmount;
                hashCode = (hashCode * 397) ^ CopperAmount;
                return hashCode;
            }
        }

        /// <summary>   Equality operator. </summary>
        /// <param name="left">     The left. </param>
        /// <param name="right">    The right. </param>
        /// <returns>   The result of the operation. </returns>
        public static bool operator ==(TransactionAmount left, TransactionAmount right)
        {
            return Equals(left, right);
        }

        /// <summary>   Inequality operator. </summary>
        /// <param name="left">     The left. </param>
        /// <param name="right">    The right. </param>
        /// <returns>   The result of the operation. </returns>
        public static bool operator !=(TransactionAmount left, TransactionAmount right)
        {
            return !Equals(left, right);
        }
    }
}