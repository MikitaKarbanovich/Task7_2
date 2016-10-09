using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7_2;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        StringToInt stringToInt;
        [TestInitialize]
        public void Initialize()
        {
            stringToInt = new StringToInt();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            stringToInt = null;
        }

        [TestMethod]
        public void PositiveTest()
        {
            Assert.AreEqual(100, stringToInt.ConvertStringToInt("100"));
        }
        [TestMethod]
        public void DoubleTest()
        {
            int a = stringToInt.ConvertStringToInt("100,0");
            Assert.AreEqual(100, a);
        }
        [TestMethod]
        public void NegativeNumberTest()
        {
            Assert.AreEqual(-100, stringToInt.ConvertStringToInt("-100"));
        }
        [TestMethod]
        public void NumbereWithPlusTest()
        {
            Assert.AreEqual(100, stringToInt.ConvertStringToInt("+100"));
        }
    }
}
