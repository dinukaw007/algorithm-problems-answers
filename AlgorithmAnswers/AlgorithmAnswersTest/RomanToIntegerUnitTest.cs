using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToInteger;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAnswersTest
{
    [TestClass]
    public class RomanToIntegerUnitTest
    {
        [TestMethod]
        public void RomanToIntegerTestMethod1()
        {            
            int value = RomanToIntegerNumber.RomanToIntTwo("III");
            Assert.AreEqual(3, value);
        }

        [TestMethod]
        public void RomanToIntegerTestMethod2()
        {
            int value = RomanToIntegerNumber.RomanToIntTwo("IV");
            Assert.AreEqual(4, value);
        }

        [TestMethod]
        public void RomanToIntegerTestMethod3()
        {
            int value = RomanToIntegerNumber.RomanToIntTwo("IX");
            Assert.AreEqual(9, value);
        }

        [TestMethod]
        public void RomanToIntegerTestMethod4()
        {
            int value = RomanToIntegerNumber.RomanToIntTwo("LVIII");
            Assert.AreEqual(58, value);
        }

        [TestMethod]
        public void RomanToIntegerTestMethod5()
        {
            int value = RomanToIntegerNumber.RomanToIntTwo("MCMXCIV");
            Assert.AreEqual(1994, value);
        }
    }
}
