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
        [TestCase (4, ExpectedResult = "IV")]
        [TestCase (5, ExpectedResult = "V")]
        [TestCase (7, ExpectedResult = "VII")]
        [TestCase (8, ExpectedResult = "VIII")]
        [TestCase (9, ExpectedResult = "IX")]
        [TestCase (10, ExpectedResult = "X")]
        [TestCase (13, ExpectedResult = "XIII")]
        [TestCase (14, ExpectedResult = "XIV")]
        [TestCase (15, ExpectedResult = "XV")]
        [TestCase (17, ExpectedResult = "XVII")]
        [TestCase (20, ExpectedResult = "XX")]
        [TestCase (25, ExpectedResult = "XXV")]
        [TestCase (30, ExpectedResult = "XXX")]
        [TestCase (40, ExpectedResult = "XL")]
        [TestCase (50, ExpectedResult = "L")]
        public string Convert_To_Roman_Number(int number)
        {
            return romanNumber.ConvertToRoman(number);
        }
    }
}