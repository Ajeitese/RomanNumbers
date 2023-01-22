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
        
        [Test]
        public void Convert_A_Decimal_Number_To_Roman_Number()
        {
            Assert.That(RomanNumber.ConvertFromDecimal(1), Is.EqualTo("I"));
        }
        
    }
}