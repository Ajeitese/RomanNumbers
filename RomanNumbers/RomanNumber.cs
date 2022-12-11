using System;
using System.Text;

namespace RomanNumbers
{
    public class RomanNumber
    {
        public string ConvertToRoman(int number)
        {
            StringBuilder result = new StringBuilder();
            var enumValues = Enum.GetValues(typeof(RomanSymbol));
            Array.Reverse(enumValues);
            foreach (RomanSymbol romanSymbol in enumValues)
            {
                while (number >= (int)romanSymbol)
                {
                    result.Append(romanSymbol);
                    number -= (int)romanSymbol;
                }
            }
            return result.ToString();
        }
    }
}