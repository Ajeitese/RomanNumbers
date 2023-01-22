using System.Text;

namespace RomanNumbers
{

    public static class RomanNumber
    {
        public static string ConvertFromDecimal(int number)
        {
            StringBuilder result = new StringBuilder();
            var symbolArray = Enum.GetValues(typeof(RomanSymbols));
            Array.Reverse(symbolArray);
            foreach (RomanSymbols romanSymbols in symbolArray)
            {
                while (number >= (int)romanSymbols)
                {
                    result.Append(romanSymbols);
                    number -= (int)romanSymbols;
                }
            }
            return result.ToString();
        }
    }
}