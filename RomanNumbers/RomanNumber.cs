using System.Text;

namespace RomanNumbers
{
    public class RomanNumber
    {
        public string ConvertToRoman(int number)
        {
            StringBuilder result = new StringBuilder(); 
            while (number > 0)
            {
                if (number >= 10)
                {
                    result.Append("X");
                    number -= 10;
                }
                else if (number >= 5)
                {
                    result.Append("V");
                    number -= 5;
                }
                else
                {
                    result.Append("I");
                    number -= 1;
                }
            }
            return result.ToString();
        }
    }
}