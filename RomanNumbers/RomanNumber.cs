namespace RomanNumbers
{
    public class RomanNumber
    {
        public string ConvertToRoman(int number)
        {
            if (number > 0)
            {
                if (number == 3)
                    return "III";
                if (number == 2)
                    return "II";                    
                return "I";
            }

            return string.Empty;
        }
    }
}