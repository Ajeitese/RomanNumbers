using NUnit.Framework;
using RomanNumbers;

namespace RomanNumbersTests
{
    public class RomanNumberShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Convert_Zero_To_Empty_String()
        {
            Assert.That(RomanNumber.ConvertFromDecimal(0), Is.EqualTo(string.Empty));
        }
        
        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(3, ExpectedResult = "III")]
        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(7, ExpectedResult = "VII")]
        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(12, ExpectedResult = "XII")]
        [TestCase(15, ExpectedResult = "XV")]
        [TestCase(16, ExpectedResult = "XVI")]
        [TestCase(24, ExpectedResult = "XXIV")]
        [TestCase(30, ExpectedResult = "XXX")]
        [TestCase(39, ExpectedResult = "XXXIX")]
        [TestCase(40, ExpectedResult = "XL")]
        [TestCase(50, ExpectedResult = "L")]
        public string Convert_A_Decimal_Number_To_Roman_Number(int number)
        {
            return RomanNumber.ConvertFromDecimal(number);
        }
    }
}