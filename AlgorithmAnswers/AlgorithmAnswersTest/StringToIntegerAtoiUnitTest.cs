using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringToIntegerAtoi;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAnswersTest
{
    [TestClass]
   public class StringToIntegerAtoiUnitTest
    {
        [TestMethod]
        public void StringToIntegerTestMethod1()
        {
            int value = StringToInteger.MyAtoi("42");
            Assert.AreEqual(42, value);
        }

        [TestMethod]
        public void StringToIntegerTestMethod2()
        {
            int value = StringToInteger.MyAtoi("   -42");
            Assert.AreEqual(-42, value);
        }

        [TestMethod]
        public void StringToIntegerTestMethod3()
        {
            int value = StringToInteger.MyAtoi("4193 with words");
            Assert.AreEqual(4193, value);
        }

        [TestMethod]
        public void StringToIntegerTestMethod4()
        {
            int value = StringToInteger.MyAtoi("words and 987");
            Assert.AreEqual(0, value);
        }

        [TestMethod]
        public void StringToIntegerTestMethod5()
        {
            int value = StringToInteger.MyAtoi("-91283472332");
            Assert.AreEqual(-2147483648, value);
        }
    }
}
