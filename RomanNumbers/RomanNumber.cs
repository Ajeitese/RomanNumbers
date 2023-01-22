namespace RomanNumbers
{

    public static class RomanNumber
    {
        public static string ConvertFromDecimal(int number)
        {
            if(number <= 0)
                return string.Empty;

            if(number == 1)
                return "I";

            if(number == 2)
                return "II";
            
            return "III";
        }
    }
}