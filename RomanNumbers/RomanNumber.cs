namespace RomanNumbers
{

    public static class RomanNumber
    {
        public static string ConvertFromDecimal(int number)
        {
            string result = string.Empty;
            while (number > 0)
            {
                if (number >= 10)
                {
                    result += "X";
                    number -= 10;
                }
                else if (number >= 5)
                {
                    result += "V";
                    number -= 5;
                }
                else
                {
                    result += "I";
                    number -= 1;
                }
            }
            return result;
        }
    }
}