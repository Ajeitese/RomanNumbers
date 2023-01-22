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
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(7, ExpectedResult = "VII")]
        public string Convert_A_Decimal_Number_To_Roman_Number(int number)
        {
            return RomanNumber.ConvertFromDecimal(number);
        }
    }
}