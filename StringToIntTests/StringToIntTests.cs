using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7_2;
using Task7_2.Exceptions;

namespace StringToIntTests
{
    public class StringToIntTests
    {
        StringToInt stringToInt;
        [SetUp]
        public void Initialize()
        {
            stringToInt = new StringToInt();
        }
        [TestCase(100, "100")]
        [TestCase(100, "+100")]
        [TestCase(-100, "-100")]
        public void PositiveTest(int expectedResult, string input)
        {
            Assert.AreEqual(expectedResult, stringToInt.ConvertStringToInt(input));
        }
        [TestCase(100, "100,0")]
        [TestCase(100, "100,0000000000")]
        public void DoubleTest(int expectedResult, string input)
        {
            Assert.AreEqual(expectedResult, stringToInt.ConvertStringToInt(input));
        }
        [TestCase(100, "100   ")]
        [TestCase(100, "    100")]
        [TestCase(100, "    100     ")]
        [TestCase(100, "    100,0    ")]
        public void NegativeTest(int expectedResult, string input)
        {
            Assert.AreEqual(expectedResult, stringToInt.ConvertStringToInt(input));
        }
        [TestCase("fsdfsdfsdfsd")]
        [TestCase("120fdsf")]
        [TestCase("gfdg14")]
        [TestCase("144   f")]
        public void NotANumberExceptionExceptionTest(string input)
        {
            Assert.Throws<NotANumberException>(() => stringToInt.ConvertStringToInt(input));
        }
        [TestCase("100,50")]
        [TestCase("0,5")]
        [TestCase("55,02")]
        public void NotAnIntegerExceptionExceptionTest(string input)
        {
            Assert.Throws<NotAnIntegerException>(() => stringToInt.ConvertStringToInt(input));
        }
        [TestCase("999999999999999999")]
        [TestCase("111111111111111")]
        public void OverflowExceptionExceptionTest(string input)
        {
            Assert.Throws<OverflowException>(() => stringToInt.ConvertStringToInt(input));
        }
    }
}
