namespace RomanNumbers
{

    public static class RomanNumber
    {
        public static string ConvertFromDecimal(int number)
        {
            if(number <= 0)
                return string.Empty;

            return "I";
        }
    }
}