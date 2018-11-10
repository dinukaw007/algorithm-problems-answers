using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAnswersTest
{
    [TestClass]
    public class PalindromeNumberUnitTest
    {
        [TestMethod]
        public void PalindromeNumberTestMethod1()
        {
            bool value = Palindrome.IsPalindrome(123);
            Assert.AreEqual(false, value);
        }

        [TestMethod]
        public void PalindromeNumberTestMethod2()
        {
            bool value = Palindrome.IsPalindrome(0);
            Assert.AreEqual(true, value);
        }

        [TestMethod]
        public void PalindromeNumberTestMethod3()
        {
            bool value = Palindrome.IsPalindrome(-121);
            Assert.AreEqual(false, value);
        }

        [TestMethod]
        public void PalindromeNumberTestMethod5()
        {
            bool value = Palindrome.IsPalindrome(121);
            Assert.AreEqual(true, value);
        }
    }
}
