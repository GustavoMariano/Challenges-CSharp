using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzSolution
    {
        public static IList<string> Solution(int n)
        {
            string[] result = new string[n];

            for (int i = 0; i < n; i++)
            {
                int x = i + 1;
                if (x % 3 == 0 && x % 5 == 0)
                    result[i] = "FizzBuzz";
                else if (x % 3 == 0)
                    result[i] = "Fizz";
                else if (x % 5 == 0)
                    result[i] = "Buzz";
                else
                    result[i] = x.ToString();
            }

            return result;
        }
    }
}
