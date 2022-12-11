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
                if (number >= (int)RomanSymbol.X)
                {
                    result.Append(RomanSymbol.X);
                    number -= (int)RomanSymbol.X;
                }
                else if (number >= (int)RomanSymbol.V)
                {
                    result.Append(RomanSymbol.V);
                    number -= (int)RomanSymbol.V;
                }
                else
                {
                    result.Append(RomanSymbol.I);
                    number -= (int)RomanSymbol.I;
                }
            }
            return result.ToString();
        }
    }
}