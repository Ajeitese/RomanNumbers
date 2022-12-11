namespace RomanNumbers
{
    public class RomanNumber
    {
        public string ConvertToRoman(int number)
        {
            if (number > 0)
                return "I";
            return string.Empty;
        }
    }
}