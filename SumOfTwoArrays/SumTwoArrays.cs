using System.Linq;

namespace SumOfTwoArrays
{
    public class SumTwoArrays
    {
        public static int[] Sum(int[] num1, int[] num2)
        {
            string number1 = string.Join("", num1);
            string number2 = string.Join("", num2);

            int sum = int.Parse(number1) + int.Parse(number2);

            return sum.ToString().Select(c => c - '0').ToArray();
        }
    }
}
