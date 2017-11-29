// <summary>Implements the transactionamounttests class</summary>
using Eq2BrokerCalc2Lib.Code;
using Eq2BrokerCalc2Lib.Code.Exceptions;
using Eq2BrokerCalc2LibTests.Mocks;
using NUnit.Framework;

namespace Eq2BrokerCalc2LibTests.Code
{
    /// <summary>   (Unit Test Fixture) a transaction amount tests. </summary>
    [TestFixture()]
    public class TransactionAmountTests
    {
        /// <summary>
        ///     Transaction constructor test provide total copper in constructor equal new object.
        /// </summary>
        /// <param name="totalCopper">  The total copper. </param>
        /// <param name="platAmount">   The plat amount. </param>
        /// <param name="goldAmount">   The gold amount. </param>
        /// <param name="silverAmount"> The silver amount. </param>
        /// <param name="copperAmount"> The copper amount. </param>
        [TestCase(100023004, 100, 2, 30, 4)]
        [TestCase(40, 0, 0, 0, 40)]
        [TestCase(3004, 0, 0, 30, 4)]
        [TestCase(23004, 0, 2, 30, 4)]
        public void TransactionConstructorTest_ProvideTotalCopperInConstructor_EqualNewObject(int totalCopper, int platAmount, int goldAmount, int silverAmount, int copperAmount)
        {
            var expectedObject = new TransactionAmount();
            expectedObject.CallNonPublicSetter(x => x.CopperTotal, totalCopper);
            expectedObject.CallNonPublicSetter(x => x.PlatinumAmount, platAmount);
            expectedObject.CallNonPublicSetter(x => x.GoldAmount, goldAmount);
            expectedObject.CallNonPublicSetter(x => x.SilverAmount, silverAmount);
            expectedObject.CallNonPublicSetter(x => x.CopperAmount, copperAmount);

            var actualObject = new TransactionAmount(totalCopper);

            Assert.AreEqual(expectedObject, actualObject);
        }

        /// <summary>
        ///     (Unit Test Method) transaction constructor test default constructor equals new object.
        /// </summary>
        [Test()]
        public void TransactionConstructorTest_DefaultConstructor_EqualsNewObject()
        {
            var expectedObject = new TransactionAmount();
            expectedObject.CallNonPublicSetter(x => x.CopperTotal, 0);
            expectedObject.CallNonPublicSetter(x => x.PlatinumAmount, 0);
            expectedObject.CallNonPublicSetter(x => x.GoldAmount, 0);
            expectedObject.CallNonPublicSetter(x => x.SilverAmount, 0);
            expectedObject.CallNonPublicSetter(x => x.CopperAmount, 0);

            var actualObject = new TransactionAmount();

            Assert.AreEqual(expectedObject, actualObject);
        }

        /// <summary>
        ///     (Unit Test Method) transaction amount constructor test negative copper amount throws
        ///     invalid amount exception.
        /// </summary>
        [Test]
        public void TransactionAmountConstructorTest_NegativeCopperAmount_ThrowsInvalidAmountException()
        {
            Assert.Throws<InvalidAmountException>(() => new TransactionAmount(-100));
        }

        /// <summary>
        ///     (Unit Test Method) equals test expected object compared to null expect unequal.
        /// </summary>
        [Test()]
        public void EqualsTest_ExpectedObjectComparedToNull_ExpectUnequal()
        {
            //// Arrange

            TransactionAmount expectedObject = null;

            //// Act

            TransactionAmount actualObject = new TransactionAmount(10);

            //// Assert

            Assert.IsFalse(actualObject.Equals(expectedObject));
            Assert.IsTrue(expectedObject != actualObject);
        }

        /// <summary>
        ///     (Unit Test Method) equals test expected object references actual object expect true.
        /// </summary>
        [Test()]
        public void EqualsTest_ExpectedObjectReferencesActualObject_ExpectTrue()
        {
            //// Arrange

            TransactionAmount expectedObject = new TransactionAmount(100);

            //// Act

            TransactionAmount actualObject = expectedObject;

            //// Assert

            Assert.IsTrue(actualObject.Equals(expectedObject));
            Assert.IsTrue(actualObject == expectedObject);
        }

        /// <summary>   (Unit Test Method) tests get hash code. </summary>
        [Test()]
        public void GetHashCodeTest()
        {
            var expectedObject = new TransactionAmount();
            expectedObject.CallNonPublicSetter(x => x.CopperTotal, 10);
            expectedObject.CallNonPublicSetter(x => x.PlatinumAmount, 0);
            expectedObject.CallNonPublicSetter(x => x.GoldAmount, 0);
            expectedObject.CallNonPublicSetter(x => x.SilverAmount, 0);
            expectedObject.CallNonPublicSetter(x => x.CopperAmount, 10);

            var actualObject = new TransactionAmount(10);

            Assert.AreEqual(expectedObject.GetHashCode(), actualObject.GetHashCode());
        }
    }
}