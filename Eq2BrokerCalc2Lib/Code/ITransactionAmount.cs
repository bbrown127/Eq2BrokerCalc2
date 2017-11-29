// <summary>Implements the itransactionamount class</summary>
namespace Eq2BrokerCalc2Lib.Code
{
    /// <summary>   Interface for transaction amount. </summary>
    public interface ITransactionAmount
    {
        /// <summary>   Gets the copper total. </summary>
        /// <value> The copper total. </value>
        int CopperTotal { get; }

        /// <summary>   Gets the platinum amount. </summary>
        /// <value> The platinum amount. </value>
        int PlatinumAmount { get; }

        /// <summary>   Gets the gold amount. </summary>
        /// <value> The gold amount. </value>
        int GoldAmount { get; }

        /// <summary>   Gets the silver amount. </summary>
        /// <value> The silver amount. </value>
        int SilverAmount { get; }

        /// <summary>   Gets the copper amount. </summary>
        /// <value> The copper amount. </value>
        int CopperAmount { get; }
    }
}