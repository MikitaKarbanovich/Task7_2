using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7_2;

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
        public void TesetCustomersWithSumOfOrdersMoreThan()
        {
            stringToInt.Input = "100500";
            Assert.AreEqual(100500, stringToInt.Input);
        }
       
    }
}
