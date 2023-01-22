namespace RomanNumbers
{

    public static class RomanNumber
    {
        public static string ConvertFromDecimal(int number)
        {
            string result = string.Empty;
            while (number > 0)
            {
                result += "I";
                number -= 1;
            }
            return result;
        }
    }
}