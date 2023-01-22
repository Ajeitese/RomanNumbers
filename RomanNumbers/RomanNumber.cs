namespace RomanNumbers
{

    public static class RomanNumber
    {
        public static string ConvertFromDecimal(int number)
        {
            string result = string.Empty;
            var symbolArray = Enum.GetValues(typeof(RomanSymbols));
            Array.Reverse(symbolArray);
            foreach (RomanSymbols romanSymbols in symbolArray)
            {
                while (number >= (int)romanSymbols)
                {
                    result += romanSymbols;
                    number -= (int)romanSymbols;
                }
            }
            return result;
        }
    }
}