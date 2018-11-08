using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ZigZagConversion;

namespace AlgorithmAnswersTest
{
    [TestClass]
    public class ZigZagConversionUnitTest
    {
        [TestMethod]
        public void ZigZagConversionMethod1()
        {
            string value = ZigZag.ConvertZigZag("PAYPALISHIRING",1);
            Assert.AreEqual("PAYPALISHIRING", value);
        }

        [TestMethod]
        public void ZigZagConversionMethod2()
        {
            string value = ZigZag.ConvertZigZag("PAYPALISHIRING", 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", value);
        }

        [TestMethod]
        public void ZigZagConversionMethod3()
        {
            string value = ZigZag.ConvertZigZag("PAYPALISHIRING", 4);
            Assert.AreEqual("PINALSIGYAHRPI", value);
        }
    }
}
