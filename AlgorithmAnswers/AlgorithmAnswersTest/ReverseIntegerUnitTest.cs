using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInteger;
using ZigZagConversion;
namespace AlgorithmAnswersTest
{
    [TestClass]
    public class ReverseIntegerUnitTest
    {
        [TestMethod]
        public void ReverseIntegerTestMethod1()
        {
            int value = ReverseInt.Reverse(123);
            Assert.AreEqual(321, value);
        }

        [TestMethod]
        public void ReverseIntegerTestMethod2()
        {
            int value = ReverseInt.Reverse(-123);
            Assert.AreEqual(-321, value);
        }

        [TestMethod]
        public void ReverseIntegerTestMethod3()
        {
            int value = ReverseInt.Reverse(1534236469);
            Assert.AreEqual(0, value);
        }


        [TestMethod]
        public void ReverseIntegerTwoTestMethod1()
        {
            int value = ReverseInt.ReverseTwo(123);
            Assert.AreEqual(321, value);
        }

        [TestMethod]
        public void ReverseIntegerTwoTestMethod2()
        {
            int value = ReverseInt.ReverseTwo(-123);
            Assert.AreEqual(-321, value);
        }

        [TestMethod]
        public void ReverseIntegerTwoTestMethod3()
        {
            int value = ReverseInt.ReverseTwo(1534236469);
            Assert.AreEqual(0, value);
        }
    }
}
