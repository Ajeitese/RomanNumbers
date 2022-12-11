using NUnit.Framework;
using RomanNumbers;

namespace RomanNumbersTests
{
    [TestFixture]
    public class RomanNumberShould
    {
        RomanNumber romanNumber;

        [SetUp]
        public void Setup()
        {
            romanNumber = new RomanNumber();
        }
        
        [Test]
        public void Convert_To_Roman_Number()
        {
            Assert.That(romanNumber.ConvertToRoman(0), Is.EqualTo(string.Empty));
            Assert.That(romanNumber.ConvertToRoman(1), Is.EqualTo("I"));
            Assert.That(romanNumber.ConvertToRoman(2), Is.EqualTo("II"));

        }
    }
}