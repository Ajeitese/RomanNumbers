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
        
        [TestCase (0, ExpectedResult = "")]
        [TestCase (1, ExpectedResult = "I")]
        [TestCase (2, ExpectedResult = "II")]
        [TestCase (3, ExpectedResult = "III")]
        [TestCase (5, ExpectedResult = "V")]
        [TestCase (7, ExpectedResult = "VII")]
        [TestCase (8, ExpectedResult = "VIII")]
        [TestCase (10, ExpectedResult = "X")]
        public string Convert_To_Roman_Number(int number)
        {
            return romanNumber.ConvertToRoman(number);
        }
    }
}