using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

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
        }

    }

    public class RomanNumber
    {
        public string ConvertToRoman(int number)
        {
            return string.Empty;
        }
    }
}