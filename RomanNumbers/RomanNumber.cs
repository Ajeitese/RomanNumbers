using System.Text;

namespace RomanNumbers
{
    public class RomanNumber
    {
        public string ConvertToRoman(int number)
        {
            StringBuilder result = new StringBuilder(); 
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                    result.Append("I");
            }
            return result.ToString();
        }
    }
}