namespace RomanNumbers
{

    public static class RomanNumber
    {
        public static string ConvertFromDecimal(int number)
        {
            string result = string.Empty;
            while (number > 0)
            {
                if (number >= (int)RomanSymbols.X)
                {
                    result += RomanSymbols.X;
                    number -= (int)RomanSymbols.X;
                }
                else if (number >= (int)RomanSymbols.V)
                {
                    result += RomanSymbols.V;
                    number -= (int)RomanSymbols.V;
                }
                else
                {
                    result += RomanSymbols.I;
                    number -= (int)RomanSymbols.I;
                }
            }
            return result;
        }
    }
}