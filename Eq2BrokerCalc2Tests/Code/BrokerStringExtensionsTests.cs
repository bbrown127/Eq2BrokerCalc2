// <summary>Implements the brokerstringextensionstests class</summary>
using Eq2BrokerCalc2Lib.Code;
using NUnit.Framework;

namespace Eq2BrokerCalc2LibTests.Code
{
    /// <summary>   (Unit Test Fixture) a broker string extensions tests. </summary>
    [TestFixture()]
    public class BrokerStringExtensionsTests
    {
        /// <summary>   Output total test supply test case output is equal. </summary>
        /// <param name="copperTotal">  The copper total. </param>
        /// <param name="output">       The output. </param>
        [TestCase(100023004, "100p2g30s4c")]
        [TestCase(23004, "2g30s4c")]
        [TestCase(3004, "30s4c")]
        [TestCase(4, "4c")]
        [TestCase(100000004, "100p4c")]
        [TestCase(100000000, "100p")]
        public void OutputTotalTest_SupplyTestCase_OutputIsEqual(int copperTotal, string output)
        {
            //// Arrange

            var expectedValue = output; 

            //// Act

            var actualValue = (new TransactionAmount(copperTotal)).OutputTotal();

            //// Assert

            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}